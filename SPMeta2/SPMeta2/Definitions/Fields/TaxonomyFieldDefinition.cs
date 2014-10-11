﻿using SPMeta2.Attributes;
using SPMeta2.Attributes.Regression;
using SPMeta2.Enumerations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPMeta2.Definitions.Fields
{
    /// <summary>
    /// Allows to define and deploy taxonomy field.
    /// </summary>
    /// 
    [SPObjectTypeAttribute(SPObjectModelType.SSOM, "Microsoft.SharePoint.Taxonomy.TaxonomyField", "Microsoft.SharePoint.Taxonomy")]
    [SPObjectTypeAttribute(SPObjectModelType.CSOM, "Microsoft.SharePoint.Client.Taxonomy.TaxonomyField", "Microsoft.SharePoint.Client.Taxonomy")]

    [DefaultParentHostAttribute(typeof(SiteDefinition))]
    [DefaultRootHostAttribute(typeof(SiteDefinition))]

    [Serializable]
    public class TaxonomyFieldDefinition : FieldDefinition
    {
        #region constructors

        public TaxonomyFieldDefinition()
        {
            FieldType = BuiltInFieldTypes.TaxonomyFieldType;

            TermSetLCID = 1033;
            TermLCID = 1033;
        }

        #endregion

        #region properties

        public bool IsMulti { get; set; }

        public string SspName { get; set; }
        public Guid? SspId { get; set; }

        public string TermSetName { get; set; }
        public Guid? TermSetId { get; set; }
        public int TermSetLCID { get; set; }

        public string TermName { get; set; }
        public Guid? TermId { get; set; }
        public int TermLCID { get; set; }

        #endregion
    }
}
