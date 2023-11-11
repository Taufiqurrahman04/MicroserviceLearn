using Portfolio.Entity;

namespace MyCV.Entity
{
    public class MyPortofolio
    {
        public string Id { get; set; }
        public virtual Profile Profile { get; set; }
        public string ProfileId { get; set; }
        public string MyWorkExperienceId { get; set; }
        public string UserRefId { get; set; }
        public DateTimeOffset DateCreated { get; set; }
        public DateTimeOffset? DateUpdated { get; set; }
        public string UpdateString { get; set; }
        public bool IsActive { get; set; }
    }
}
