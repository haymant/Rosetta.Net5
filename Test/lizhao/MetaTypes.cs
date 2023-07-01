// This file is auto-generated from the ISDA Common Domain Model, do not edit.
//
// Version: ${project.version}
//
namespace Org.Isda.Cdm.Meta
{
    using System.Collections.Generic;

    using Rosetta.Lib;
    using Rosetta.Lib.Attributes;
    using Rosetta.Lib.Meta;
    using Rosetta.Lib.Validation;
    
    using Org.Isda.Cdm.Validation.ChoiceRule;
    using Org.Isda.Cdm.Validation.DataRule;
    
    /// <summary>
    /// MetaData definition for Product
    /// </summary>
    [RosettaMeta(typeof(Product))]
    public class ProductMeta : IRosettaMetaData<Product>
    {
        public IEnumerable<IValidator<Product>> DataRules {
            get {
                yield break;
            }
        }
    
        public IEnumerable<IValidator<Product>> ChoiceRuleValidators {
            get {
                yield break;
            }
        }
        
        public IValidatorWithArg<Product, ISet<string>> OnlyExistsValidator => new ProductOnlyExistsValidator();

        public IValidator<Product> Validator => new ProductValidator();
    }
}
