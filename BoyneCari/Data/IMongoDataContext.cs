
using MongoDB.Driver;

namespace BoyneCari.Data
{
    public interface IMongoDataContext
    {
        IMongoDatabase _db { get; }
        MongoClient _mongoClient { get; }
        IMongoCollection<T> GetCollection<T>(string name);
    }
}
