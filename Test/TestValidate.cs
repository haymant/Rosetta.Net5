#nullable enable // Allow nullable reference types


using Org.Isda.Cdm;
using Org.Isda.Cdm.Enums;

namespace Cdm.Test
{
    using System.IO;
    using Xunit;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Serialization;
    
    public class TestValidate
    {
        // Assume trade is one part of a larger JSON packet.
        [Fact]
        public void TestValidation()
        {
            // Load a json file deserialize it into an object and validate it.
            const string fileName = "product.json";

            JsonSerializerSettings settings = GetSerializerSettings();

            string json = File.ReadAllText(fileName);
            var product = JsonConvert.DeserializeObject<Product>(json, settings);
            Assert.True(product != null);
#pragma warning disable CS8602 // Dereference of a possibly null reference.
            var type = product.ProdType;
#pragma warning restore CS8602 // Dereference of a possibly null reference.
            Assert.True(type == ProductType.FCN);
            Assert.True(product.Name == "lizhao");

#pragma warning disable CS8602 // Dereference of a possibly null reference.
            Assert.True(product.Validate().IsSuccess);
#pragma warning restore CS8602 // Dereference of a possibly null reference.
        }

        private static JsonSerializerSettings GetSerializerSettings()
        {
            return new JsonSerializerSettings()
            {
                ContractResolver = new CamelCasePropertyNamesContractResolver(),
                NullValueHandling = NullValueHandling.Ignore,
                Formatting = Formatting.Indented
            };
        }
    }
}
