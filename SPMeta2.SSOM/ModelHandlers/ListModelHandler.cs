﻿using System;
using Microsoft.SharePoint;
using Microsoft.SharePoint.Utilities;
using SPMeta2.Definitions;
using SPMeta2.ModelHandlers;
using SPMeta2.SSOM.DefaultSyntax;
using SPMeta2.SSOM.ModelHosts;
using SPMeta2.Utils;

namespace SPMeta2.SSOM.ModelHandlers
{
    public class ListModelHandler : SSOMModelHandlerBase
    {
        #region methods

        public override Type TargetType
        {
            get { return typeof(ListDefinition); }
        }

        public override void WithResolvingModelHost(object modelHost, DefinitionBase model, Type childModelType, Action<object> action)
        {
            var web = modelHost as SPWeb;

            var listDefinition = model as ListDefinition;

            if (web != null && listDefinition != null)
            {
                var list = web.GetList(SPUtility.ConcatUrls(web.ServerRelativeUrl, listDefinition.GetListUrl()));

                if (childModelType == typeof(ModuleFileDefinition))
                {
                    action(list.RootFolder);
                }
                else if (childModelType == typeof(FolderDefinition))
                {
                    var folderModelHost = new FolderModelHost
                    {
                        CurrentLibrary = list as SPDocumentLibrary,
                        CurrentLibraryFolder = list.RootFolder,

                        CurrentList = (list as SPDocumentLibrary != null) ? null : list,
                        CurrentListItem = null,
                    };

                    action(folderModelHost);
                }
                else
                {
                    action(list);
                }

                list.Update();
            }
            else
            {
                action(modelHost);
            }
        }

        protected override void DeployModelInternal(object modelHost, DefinitionBase model)
        {
            var web = modelHost.WithAssertAndCast<SPWeb>("modelHost", value => value.RequireNotNull());
            var listModel = model.WithAssertAndCast<ListDefinition>("model", value => value.RequireNotNull());

            // min provision
            var targetList = GetOrCreateList(web, listModel);

            targetList.Title = listModel.Title;

            // SPBug, again & again, must not be null
            targetList.Description = listModel.Description = listModel.Description ?? string.Empty;
            targetList.ContentTypesEnabled = listModel.ContentTypesEnabled;

            targetList.Update();
        }

        private static SPList GetOrCreateList(SPWeb web, ListDefinition listModel)
        {
            var result = GetListByUrl(web, listModel);

            if (result == null)
            {
                var listId = default(Guid);

                // "SPBug", there are two ways to create lists 
                // (1) by TemplateName (2) by TemplateType 
                if (listModel.TemplateType > 0)
                {
                    listId = web.Lists.Add(listModel.Url, listModel.Description, (SPListTemplateType)listModel.TemplateType);
                }
                else if (!string.IsNullOrEmpty(listModel.TemplateName))
                {
                    // TODO, add some validation
                    var listTemplate = web.ListTemplates[listModel.TemplateName];

                    web.Lists.Add(listModel.Url, listModel.Description, listTemplate);
                }
                else
                {
                    throw new ArgumentException("TemplateType or TemplateName must be defined");
                }

                result = web.Lists[listId];
            }

            return result;
        }

        private static SPList GetListByUrl(SPWeb web, ListDefinition listModel)
        {
            SPList result;

            try
            {
                var targetListUrl = SPUrlUtility.CombineUrl(web.Url, listModel.GetListUrl());
                result = web.GetList(targetListUrl);
            }
            catch
            {
                result = null;
            }

            return result;
        }

        #endregion
    }
}