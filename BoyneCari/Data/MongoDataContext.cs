using BoyneCari.Models.Settings;
using Microsoft.Extensions.Options;
using MongoDB.Driver;
namespace BoyneCari.Data
{
    public class MongoDataContext : IMongoDataContext
    {
        #region .ctor
        private IMongoDatabase _db { get; set; }
        private MongoClient client { get; set; }
        IMongoDatabase IMongoDataContext._db { get { return _db; } }
        MongoClient IMongoDataContext._mongoClient { get { return client; } }
        public MongoDataContext(IOptions<MongoDbSettings> configuration)
        {
            client = new MongoClient(configuration.Value.ConnectionString);
            _db = client.GetDatabase(configuration.Value.DatabaseName);
        }
        #endregion
        public IMongoCollection<T> GetCollection<T>(string name)
        {
            return _db.GetCollection<T>(name);
        }
    }
}
