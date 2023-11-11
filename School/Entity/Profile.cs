namespace School.Entity
{
    public class Profile
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Major { get; set; }
        public string Degree { get; set; }
        public DateTimeOffset DateCreated { get; set; }
        public DateTimeOffset? DateUpdated { get; set; }
        public string UpdateString { get; set; }
        public bool IsActive { get; set; }
    }
}
