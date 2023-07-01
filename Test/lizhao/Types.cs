// This file is auto-generated from the ISDA Common Domain Model, do not edit.
//
// Version: ${project.version}
//
[assembly: Rosetta.Lib.Attributes.CdmVersion("${project.version}")]

#nullable enable // Allow nullable reference types

namespace Org.Isda.Cdm
{
    using System.Collections.Generic;

    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    using NodaTime;

    using Rosetta.Lib;
    using Rosetta.Lib.Attributes;
    using Rosetta.Lib.Meta;
    using Rosetta.Lib.Validation;

    using Org.Isda.Cdm.Meta;
    using Org.Isda.Cdm.MetaFields;
    using _MetaFields = Org.Isda.Cdm.MetaFields.MetaFields;
    
    /// <summary>
    /// Financial Derivative Product
    /// </summary>
    public class Product : AbstractRosettaModelObject<Product>
    {
        private static readonly IRosettaMetaData<Product> metaData = new ProductMeta();
        
        [JsonConstructor]
        public Product(string name, Enums.ProductType prodType)
        {
            Name = name;
            ProdType = prodType;
        }
        
        /// <inheritdoc />
        [JsonIgnore]
        public override IRosettaMetaData<Product> MetaData => metaData;
        
        public string Name { get; }
        
        [JsonConverter(typeof(StringEnumConverter))]
        public Enums.ProductType ProdType { get; }
    }
}
