using System.ComponentModel.DataAnnotations;
using WorkExperience.Entity;

namespace MyCV.Entity
{
    public class MyWorkExperience
    {
        [Key]
        public string Id { get; set; }
        public string UserRefId { get; set; }
        public virtual Profile Profile { get; set; }
        public string ProfileId { get; set; }
        public DateTimeOffset? DateStart { get; set; }
        public DateTimeOffset? DateEnd { get; set; }
        public bool IsCurrent { get; set; }
        public string JobTitle { get; set; }
        public DateTimeOffset DateCreated { get; set; }
        public DateTimeOffset? DateUpdated { get; set; }
        public string UpdateString { get; set; }
        public bool IsActive { get; set; }
    }
}
