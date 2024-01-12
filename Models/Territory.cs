using MongoDB.Bson;

namespace Models
{
    public class Territory
    {
        public ObjectId Id { get; set; }
        public int TerritoryId { get; set; }
        public string Name { get; set; }
        public Block[] Blocks { get; set; }
        public DateTime? LasTimeWorked { get; set; }
    }
}