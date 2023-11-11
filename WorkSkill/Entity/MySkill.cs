using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;
using WorkSkill.Entity;

namespace MyCV.Entity
{
    public class MySkill
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
        public string UserRefId { get; set; }
        public string ProfileRefId { get; set; }
        public int SkillLevel { get; set; }
        public DateTimeOffset DateCreated { get; set; }
        public DateTimeOffset? DateUpdated { get; set; }
        public string UpdateString { get; set; }
        public bool IsActive { get; set; }
    }
}
