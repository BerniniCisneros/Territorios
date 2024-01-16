using Models;
using MongoDB.Driver;

namespace Territorios.Data
{
    
    public class TerritoryRepository
    {
        const string connectionUri = "mongodb+srv://p00gz:Mistyn23.@emaily.r9zj8.mongodb.net/?retryWrites=true&w=majority";
        private IMongoCollection<Territory> GetTerritoriesCollection()
        {
            

            var settings = MongoClientSettings.FromConnectionString(connectionUri);

            // Set the ServerApi field of the settings object to Stable API version 1
            settings.ServerApi = new ServerApi(ServerApiVersion.V1);

            // Create a new client and connect to the server
            var client = new MongoClient(settings);

            // Send a ping to confirm a successful connection
            try
            {
                var collection = client.GetDatabase("emaily").GetCollection<Territory>("Territories");
                return collection;
                
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return null;
            }
        }

        private IMongoCollection<Captain> GetCaptainsCollection()
        {


            var settings = MongoClientSettings.FromConnectionString(connectionUri);

            // Set the ServerApi field of the settings object to Stable API version 1
            settings.ServerApi = new ServerApi(ServerApiVersion.V1);

            // Create a new client and connect to the server
            var client = new MongoClient(settings);

            // Send a ping to confirm a successful connection
            try
            {
                var collection = client.GetDatabase("emaily").GetCollection<Captain>("Capitanes");
                return collection;

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return null;
            }
        }
        public Territory[] GetAllTerritories()
        {
            var collection = GetTerritoriesCollection();
            return collection.Find(s => s.TerritoryId > 0).ToList().ToArray();
        }

        public Captain[] GetAllCaptains()
        {
            var collection = GetCaptainsCollection();
            return collection.Find(s => s.CaptainId > 0).ToList().ToArray();
        }

        public void UpdateTerritory(int territoryId, int blockId, bool worked)
        {
            var territory = this.GetAllTerritories().Where(s => s.TerritoryId == territoryId).Single();
            var blocks = territory.Blocks;
            var block = blocks.Where(s => s.Id == blockId).Single();
            block.Worked = worked;

            if (worked)
            {
                territory.LasTimeWorked = DateTime.Now;
                block.WorkedOn = DateTime.Now;
            }
            else
            {
                block.WorkedOn = null;
            }
            var filter = Builders<Territory>.Filter
            .Eq(s => s.TerritoryId, territoryId);
            var update = Builders<Territory>.Update
                .Set(s => s.LasTimeWorked, DateTime.Now)
                .Set(s => s.Blocks, blocks);
            var collection = GetTerritoriesCollection();
            collection.UpdateOne(filter, update);
        }

        public void UpdateTerritoryAssignedTo(int territoryId, string assignedTo)
        {
            var territory = this.GetAllTerritories().Where(s => s.TerritoryId == territoryId).Single();
            territory.AssignedTo = assignedTo;
            var filter = Builders<Territory>.Filter
            .Eq(s => s.TerritoryId, territoryId);
            var update = Builders<Territory>.Update
                .Set(s => s.AssignedTo, assignedTo);
            var collection = GetTerritoriesCollection();
            collection.UpdateOne(filter, update);
        }
    }
    public class TerritoryService
    {
        private readonly TerritoryRepository repository;
        public TerritoryService()
        {
            repository = new TerritoryRepository();
        }
        public Territory[] GetTerritories()
        {
            return repository.GetAllTerritories();
        }

        public Captain[] GetCaptains()
        {
            return repository.GetAllCaptains();
        }
        public void MarkTerritory(int territoryId, int blockId, bool worked)
        {
            repository.UpdateTerritory(territoryId, blockId, worked);
        }

        public void AssignTerritory(int territoryId, string assignedTo)
        {
            repository.UpdateTerritoryAssignedTo(territoryId, assignedTo);
        }
    }
}
