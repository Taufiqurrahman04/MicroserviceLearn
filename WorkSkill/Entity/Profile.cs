using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;

namespace WorkSkill.Entity
{
    public class Profile
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
        public string SkillName { get; set; }
        public string SkillDescription { get; set; }
        public bool IsSoftwareTools { get; set; }
        public DateTimeOffset DateCreated { get; set; }
        public DateTimeOffset? DateUpdated { get; set; }
        public string UpdateString { get; set; }
        public bool IsActive { get; set; }
    }
}
