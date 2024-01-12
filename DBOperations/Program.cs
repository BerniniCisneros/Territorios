using Models;
using MongoDB.Bson;
using MongoDB.Driver;

const string connectionUri = "mongodb+srv://p00gz:Mistyn23.@emaily.r9zj8.mongodb.net/?retryWrites=true&w=majority";

var settings = MongoClientSettings.FromConnectionString(connectionUri);

// Set the ServerApi field of the settings object to Stable API version 1
settings.ServerApi = new ServerApi(ServerApiVersion.V1);

// Create a new client and connect to the server
var client = new MongoClient(settings);

Territory[] Territories = new Territory[2]
        {
            new Territory
            {
                TerritoryId = 1,
                Name = "Uno",
                Blocks = new Block[]
                {
                    new Block
                    {
                        Id = 1,
                        WorkedOn = null,
                        Worked = false,
                    },
                    new Block
                    {
                        Id = 2,
                        WorkedOn = null,
                        Worked = false,
                    },
                    new Block
                    {
                        Id = 3,
                        WorkedOn = null,
                        Worked = false,
                    },
                    new Block
                    {
                        Id = 4,
                        WorkedOn = null,
                        Worked = false,
                    },
                    new Block
                    {
                        Id = 5,
                        WorkedOn = null,
                        Worked = false,
                    },
                    new Block
                    {
                        Id = 6,
                        WorkedOn = null,
                        Worked = false,
                    },
                    new Block
                    {
                        Id = 7,
                        WorkedOn = null,
                        Worked = false,
                    },
                    new Block
                    {
                        Id = 8,
                        WorkedOn = null,
                        Worked = false,
                    },
                    new Block
                    {
                        Id = 9,
                        WorkedOn = null,
                        Worked = false,
                    },
                    new Block
                    {
                        Id = 10,
                        WorkedOn = null,
                        Worked = false,
                    },
                    new Block
                    {
                        Id = 11,
                        WorkedOn = null,
                        Worked = false,
                    },
                    new Block
                    {
                        Id = 12,
                        WorkedOn = null,
                        Worked = false,
                    },
                    new Block
                    {
                        Id = 13,
                        WorkedOn = null,
                        Worked = false,
                    },
                    new Block
                    {
                        Id = 14,
                        WorkedOn = null,
                        Worked = false,
                    },
                    new Block
                    {
                        Id = 15,
                        WorkedOn = null,
                        Worked = false,
                    },
                    new Block
                    {
                        Id = 16,
                        WorkedOn = null,
                        Worked = false,
                    },
                    new Block
                    {
                        Id = 17,
                        WorkedOn = null,
                        Worked = false,
                    },
                    new Block
                    {
                        Id = 18,
                        WorkedOn = null,
                        Worked = false,
                    },
                    new Block
                    {
                        Id = 19,
                        WorkedOn = null,
                        Worked = false,
                    }
                }
            },
            new Territory
            {
                TerritoryId = 2,
                Name = "Dos",
                Blocks = new Block[]
                {
                    new Block
                    {
                        Id = 1,
                        WorkedOn = null,
                        Worked = false,
                    },
                    new Block
                    {
                        Id = 2,
                        WorkedOn = null,
                        Worked = false,
                    },
                    new Block
                    {
                        Id = 3,
                        WorkedOn = null,
                        Worked = false,
                    }
                }
            }
        };

// Send a ping to confirm a successful connection
try
{
    client.GetDatabase("emaily").CreateCollection("Territories");
    var collection = client.GetDatabase("emaily").GetCollection<Territory>("Territories");
    collection.InsertMany(Territories);
    //var result = client.GetDatabase("admin").RunCommand<BsonDocument>(new BsonDocument("ping", 1));
    //Console.WriteLine("Pinged your deployment. You successfully connected to MongoDB!");

}
catch (Exception ex)
{
    Console.WriteLine(ex);
}

