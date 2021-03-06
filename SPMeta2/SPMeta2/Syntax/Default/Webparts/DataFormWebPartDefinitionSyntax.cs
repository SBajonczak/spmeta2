using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using SPMeta2.Definitions.Webparts;
using SPMeta2.Models;

namespace SPMeta2.Syntax.Default
{

    [Serializable]
    [DataContract]
    public class DataFormWebPartModelNode : WebPartModelNode
    {

    }

    public static class DataFormWebPartDefinitionSyntax
    {
        #region methods

        public static TModelNode AddDataFormWebPart<TModelNode>(this TModelNode model, DataFormWebPartDefinition definition)
            where TModelNode : ModelNode, IWebpartHostModelNode, new()
        {
            return AddDataFormWebPart(model, definition, null);
        }

        public static TModelNode AddDataFormWebPart<TModelNode>(this TModelNode model, DataFormWebPartDefinition definition,
            Action<DataFormWebPartModelNode> action)
            where TModelNode : ModelNode, IWebpartHostModelNode, new()
        {
            return model.AddTypedDefinitionNode(definition, action);
        }

        #endregion

        #region array overload

        public static TModelNode AddDataFormWebParts<TModelNode>(this TModelNode model, IEnumerable<DataFormWebPartDefinition> definitions)
           where TModelNode : ModelNode, IWebpartHostModelNode, new()
        {
            foreach (var definition in definitions)
                model.AddDefinitionNode(definition);

            return model;
        }

        #endregion
    }
}
