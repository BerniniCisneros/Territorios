using MongoDB.Bson;

namespace Models
{
    public class Captain
    {
        public ObjectId Id { get; set; }
        public int CaptainId { get; set; }
        public string Name { get; set; }
        public bool Overseer { get; set; }
    }
}
