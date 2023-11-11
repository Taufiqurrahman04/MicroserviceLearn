using MyCV.Entity;
using System.ComponentModel.DataAnnotations;

namespace WorkExperience.Entity
{
    public class Profile
    {
        [Key]
        public string Id { get; set; }
        public string CompanyName { get; set; }
        public string CompanyAddress { get; set; }
        public DateTimeOffset DateCreated { get; set; }
        public DateTimeOffset? DateUpdated { get; set; }
        public string UpdateString { get; set; }
        public bool IsActive { get; set; }

        public ICollection<MyWorkExperience> WorkExperiences { get; set; }

    }
}
