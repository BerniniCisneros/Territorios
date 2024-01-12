namespace Models
{
    public class JobModel
    {
        public int Id { get; set; }
        public JobStatuses Status { get; set; }
        public string Description { get; set; }
        public DateTime LastUpdated { get; set; }
    }

    public enum JobStatuses
    {
        Superintendente,
        Alex,
        Tito
    }
}
