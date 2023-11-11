namespace MyCV.ViewModel.APIViewModel
{
    public class ProfileViewModel
    {
        public string Id { get; set; }
        public string CompanyName { get; set; }
        public string CompanyAddress { get; set; }
        public DateTimeOffset DateCreated { get; set; }
        public DateTimeOffset? DateUpdated { get; set; }
        public string UpdateString { get; set; }
        public bool IsActive { get; set; }
    }
}
