using ESourcing.Products.Entities;
using MongoDB.Driver;

namespace ESourcing.Products.Data.Interface
{
    public interface IProductContext
    {
        IMongoCollection<Product> Products { get; }
    }
}
