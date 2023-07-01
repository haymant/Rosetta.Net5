// This file is auto-generated from the ISDA Common Domain Model, do not edit.
//
// Version: ${project.version}
//

#nullable enable // Allow nullable reference types

namespace Org.Isda.Cdm.Validation.DataRule
{
    using System.Collections.Generic;
    using System.Linq;
    
    using Org.Isda.Cdm;
    
    using Rosetta.Lib.Functions;
    using Rosetta.Lib.Validation;
    
    public class ProductValidator : AbstractValidator<Product>
    {
    
        public ProductValidator() {}
    
        protected override IEnumerable<IComparisonResult> GetResults(Product obj)
        {
            yield break;
        }
    }
    
    public class ProductOnlyExistsValidator : AbstractOnlyExistsValidator<Product> {
    
        protected override IDictionary<string, bool> GetFields(Product obj)
        {
            return new Dictionary<string, bool>()
            {
                { "Name", IsSet(obj.Name!) },
                { "ProdType", IsSet(obj.ProdType!) }
            };
        }
    }
    
}