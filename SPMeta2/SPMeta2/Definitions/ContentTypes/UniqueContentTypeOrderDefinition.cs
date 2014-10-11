﻿using System;
using System.Collections.Generic;
using SPMeta2.Attributes;
using SPMeta2.Attributes.Regression;

namespace SPMeta2.Definitions.ContentTypes
{
    public class ContentTypeLinkValue
    {
        public string ContentTypeName { get; set; }
        public string ContentTypeId { get; set; }
    }

    public class FieldLinkValue
    {
        public string InternalName { get; set; }
        public Guid? Id { get; set; }
    }

    /// <summary>
    /// Allows to reorder content types in the particular list.
    /// </summary>
    [SPObjectType(SPObjectModelType.SSOM, "Microsoft.SharePoint.SPFolder", "Microsoft.SharePoint")]
    [SPObjectType(SPObjectModelType.CSOM, "Microsoft.SharePoint.Client.Folder", "Microsoft.SharePoint.Client")]

    [DefaultRootHost(typeof(WebDefinition))]
    [DefaultParentHost(typeof(ListDefinition))]

    [Serializable]
    public class UniqueContentTypeOrderDefinition : DefinitionBase
    {
        #region constructors

        public UniqueContentTypeOrderDefinition()
        {
            ContentTypes = new List<ContentTypeLinkValue>();
        }

        #endregion

        #region properties

        public List<ContentTypeLinkValue> ContentTypes { get; set; }

        #endregion
    }
}
