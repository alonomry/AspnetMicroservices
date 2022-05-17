using CATALOGAPI.Entities;
using MongoDB.Driver;

namespace CATALOGAPI.Data
{

    public interface ICatalogContext{
        IMongoCollection<Product> Products { get; }
    }

}