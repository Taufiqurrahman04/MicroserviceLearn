namespace WorkSkill.AppDbContext
{
    public class MongoDatabaseSettings
    {
        public string ConnectionString { get; set; } = null!;

        public string DatabaseName { get; set; } = null!;

        public string ProfileCollectionName { get; set; } = null!;
        public string MySkillCollectionName { get; set; } = null!;
    }
}
