namespace Portfolio.Entity
{
    public class Profile
    {
        public string Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set;}
        public string Url { get; set; }
        public DateTimeOffset DateCreated { get; set; }
        public DateTimeOffset? DateUpdated { get; set; }
        public string UpdateString { get; set; }
        public bool IsActive { get; set; }
    }
}
