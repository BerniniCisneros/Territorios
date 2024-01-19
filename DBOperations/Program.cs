using Models;
using MongoDB.Bson;
using MongoDB.Driver;

const string connectionUri = "mongodb+srv://p00gz:Mistyn23.@emaily.r9zj8.mongodb.net/?retryWrites=true&w=majority";

var settings = MongoClientSettings.FromConnectionString(connectionUri);

// Set the ServerApi field of the settings object to Stable API version 1
settings.ServerApi = new ServerApi(ServerApiVersion.V1);

// Create a new client and connect to the server
var client = new MongoClient(settings);

Territory[] Territories = new Territory[]
        {
            new Territory
            {
                TerritoryId = 1,
                Name = "Uno",
                AssignedTo = "Tito Esquivel",
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
                    },
                    new Block
                    {
                        Id = 20,
                        WorkedOn = null,
                        Worked = false,
                    }
                }
            },
            new Territory
            {
                TerritoryId = 2,
                Name = "Dos",
                AssignedTo = "Tito Esquivel",
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
                    }
                }
            },
            new Territory
            {
                TerritoryId = 3,
                Name = "Tres",
                AssignedTo = "Tito Esquivel",
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
                    }
                }
            },
            new Territory
            {
                TerritoryId = 4,
                Name = "Cuatro",
                AssignedTo = "Tito Esquivel",
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
                    }
                }
            },
            new Territory
            {
                TerritoryId = 5,
                Name = "Cinco",
                AssignedTo = "Tito Esquivel",
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
                    }
                }
            },
            new Territory
            {
                TerritoryId = 6,
                Name = "Seis",
                AssignedTo = "Tito Esquivel",
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
                    }
                }
            },
            new Territory
            {
                TerritoryId = 7,
                Name = "Siete",
                AssignedTo = "Tito Esquivel",
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
                    }
                }
            },
            new Territory
            {
                TerritoryId = 8,
                Name = "Ocho",
                AssignedTo = "Tito Esquivel",
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
                    }
                }
            },
            new Territory
            {
                TerritoryId = 9,
                Name = "Nueve",
                AssignedTo = "Tito Esquivel",
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
                TerritoryId = 10,
                Name = "Diez",
                AssignedTo = "Tito Esquivel",
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
                    }
                }
            },
            new Territory
            {
                TerritoryId = 11,
                Name = "Once",
                AssignedTo = "Tito Esquivel",
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
                    }
                }
            },
            new Territory
            {
                TerritoryId = 12,
                Name = "Doce",
                AssignedTo = "Tito Esquivel",
                Blocks = Array.Empty<Block>()
            },
            new Territory
            {
                TerritoryId = 13,
                Name = "Trece",
                AssignedTo = "Tito Esquivel",
                Blocks = Array.Empty<Block>()
            }
        };

Captain[] captains = new Captain[]
{
    new Captain
    {
        CaptainId = 1,
        Name = "Tito Esquivel",
        Overseer = true
    },
    new Captain
    {
        CaptainId = 2,
        Name = "Norberto Valdez",
        Overseer = false
    },
    new Captain
    {
        CaptainId = 3,
        Name = "Alejandro Blanco",
        Overseer = false
    },
    new Captain
    {
        CaptainId = 4,
        Name = "Bernini Cisneros",
        Overseer = false
    },
    new Captain
    {
        CaptainId = 5,
        Name = "Samuel Silva",
        Overseer = false
    },
    new Captain
    {
        CaptainId = 6,
        Name = "Ángel Rentería",
        Overseer = false
    },
    new Captain
    {
        CaptainId = 7,
        Name = "Luis Fernando Valdez",
        Overseer = false
    }
};

// Send a ping to confirm a successful connection
try
{
    //client.GetDatabase("emaily").CreateCollection("Territories");
    var territoriesCollection = client.GetDatabase("emaily").GetCollection<Territory>("Territories");
    territoriesCollection.DeleteMany(new BsonDocument());
    territoriesCollection.InsertMany(Territories);
    //var filter = Builders<Territory>.Filter
    //        .Eq(s => s., territoryId);
    //client.GetDatabase("emaily").CreateCollection("Capitanes");
    var captainsCollection = client.GetDatabase("emaily").GetCollection<Captain>("Capitanes");
    captainsCollection.DeleteMany(new BsonDocument());
    captainsCollection.InsertMany(captains);
    //var result = client.GetDatabase("admin").RunCommand<BsonDocument>(new BsonDocument("ping", 1));
    //Console.WriteLine("Pinged your deployment. You successfully connected to MongoDB!");

}
catch (Exception ex)
{
    Console.WriteLine(ex);
}

