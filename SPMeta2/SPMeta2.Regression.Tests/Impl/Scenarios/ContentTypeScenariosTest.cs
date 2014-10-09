﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using SPMeta2.Containers;
using SPMeta2.Definitions;
using SPMeta2.Definitions.ContentTypes;
using SPMeta2.Enumerations;
using SPMeta2.Models;
using SPMeta2.Regression.Tests.Base;
using SPMeta2.Regression.Tests.Impl.Scenarios.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SPMeta2.Syntax.Default;

namespace SPMeta2.Regression.Tests.Impl.Scenarios
{
    [TestClass]
    public class ContentTypeScenariosTest : SPMeta2RegresionScenarioTestBase
    {
        #region internal

        [ClassInitializeAttribute]
        public static void Init(TestContext context)
        {
            InternalInit();
        }

        [ClassCleanupAttribute]
        public static void Cleanup()
        {
            InternalCleanup();
        }

        #endregion

        #region default

        [TestMethod]
        [TestCategory("Regression.Scenarios.ContentTypes")]
        public void CanDeploy_CustomListItemContentType()
        {
            TestRandomDefinition<ContentTypeDefinition>(def =>
            {
                def.ParentContentTypeId = BuiltInContentTypeId.Item;
            });
        }

        [TestMethod]
        [TestCategory("Regression.Scenarios.ContentTypes")]
        public void CanDeploy_CustomDocumentContentType()
        {
            TestRandomDefinition<ContentTypeDefinition>(def =>
            {
                def.ParentContentTypeId = BuiltInContentTypeId.Document;
            });
        }

        protected class ContentTypeEnvironment
        {
            public FieldDefinition First { get; set; }
            public FieldDefinition Second { get; set; }
            public FieldDefinition Third { get; set; }

            public ContentTypeDefinition ContentType { get; set; }

            public ModelNode SiteModel { get; set; }
        }

        private ContentTypeEnvironment GetContentTypeSandbox(
            Action<ModelNode, ContentTypeEnvironment> siteModelConfig,
            Action<ModelNode, ContentTypeEnvironment> contentTypeModelConfig)
        {
            var result = new ContentTypeEnvironment();

            // site model

            FieldDefinition fldFirst = null;
            FieldDefinition fldSecond = null;
            FieldDefinition fldThird = null;

            var siteModel = SPMeta2Model
                 .NewSiteModel(site =>
                 {
                     site
                         .AddRandomField(ct => { fldFirst = ct.Value as FieldDefinition; })
                         .AddRandomField(ct => { fldSecond = ct.Value as FieldDefinition; })
                         .AddRandomField(ct => { fldThird = ct.Value as FieldDefinition; })
                         .AddRandomContentType(contentType =>
                         {
                             fldFirst.Title = "first_" + fldFirst.Title;
                             fldSecond.Title = "second_" + fldSecond.Title;
                             fldThird.Title = "third_" + fldThird.Title;

                             result.First = fldFirst;
                             result.Second = fldSecond;
                             result.Third = fldThird;

                             result.ContentType = contentType.Value as ContentTypeDefinition;

                             contentType
                                 .AddContentTypeFieldLink(fldFirst)
                                 .AddContentTypeFieldLink(fldSecond)
                                 .AddContentTypeFieldLink(fldThird);

                             if (contentTypeModelConfig != null)
                                 contentTypeModelConfig(contentType, result);
                         });
                 });

            result.SiteModel = siteModel;

            if (siteModelConfig != null)
                siteModelConfig(result.SiteModel, result);

            return result;
        }

        [TestMethod]
        [TestCategory("Regression.Scenarios.Lists.ContentTypes")]
        public void CanDeploy_CanHideContentTypeFieldLinks()
        {
            var env = GetContentTypeSandbox(
                (siteModel, e) =>
                {

                },
                (contentTypeModel, e) =>
                {
                    contentTypeModel
                       .AddHideContentTypeFieldLinks(new HideContentTypeFieldLinksDefinition
                       {
                           Fields = new List<FieldLinkValue>
                           {
                                          new FieldLinkValue { InternalName = e.Second.InternalName },
                                          new FieldLinkValue { InternalName = e.First.InternalName },
                           }
                       });
                });

            TestModel(env.SiteModel);
        }

        #endregion

        #region hierarchical content types

        // TODO

        #endregion
    }
}
