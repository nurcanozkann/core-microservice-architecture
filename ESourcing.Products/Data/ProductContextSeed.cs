using ESourcing.Products.Entities;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ESourcing.Products.Data
{
    public class ProductContextSeed
    {
        public static void SeedData(IMongoCollection<Product> productCollection)
        {
            bool existProduct = productCollection.Find(p => true).Any();
            if (!existProduct)
            {
                productCollection.InsertManyAsync(GetConfigureProducts());

            }
        }

        private static IEnumerable<Product> GetConfigureProducts()
        {
            return new List<Product>()
            {
                new Product
                {
                    Name="Xiaomi Mi 9",
                    Summary ="This phone is the company's biggest change to its flagship smartphone in years.",
                    Description="",
                    ImageFile="product-4.png",
                    Price=470.00M,
                    Category="White Appliances"
                },
                new Product
                {
                    Name="HTC U11+ Plus",
                    Summary ="This phone is the company's biggest change to its flagship smartphone in years.",
                    Description="",
                    ImageFile="product-5.png",
                    Price=380.00M,
                    Category="Smart Phone"
                },
                new Product
                {
                    Name="LG G7 ThinQ",
                    Summary ="This phone is the company's biggest change to its flagship smartphone in years.",
                    Description="",
                    ImageFile="product-6.png",
                    Price=240.00M,
                    Category="Home Kitchen"
                }
            };
        }
    }
}
