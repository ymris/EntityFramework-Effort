﻿namespace Effort.Internal.StorageSchema
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Xml.Linq;
    using Effort.Internal.Common.XmlProcessing;

    internal class FunctionParameterElementSelector : IElementSelector
    {
        private StorageSchemaContentNameProvider nameProvider;

        public FunctionParameterElementSelector(StorageSchemaContentNameProvider nameProvider)
        {
            this.nameProvider = nameProvider;
        }

        public IEnumerable<XElement> SelectElements(XElement root)
        {
            return root
                .Elements(this.nameProvider.FunctionElement)
                .SelectMany(e =>
                    e.Elements(this.nameProvider.ParameterElement));
        }
    }
}
