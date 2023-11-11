namespace MyCV.ViewModel.APIViewModel
{
    public class ProfileViewModel
    {
        public string Id { get; set; }
        public string FulllName { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public DateTimeOffset DateCreated { get; set; }
        public DateTimeOffset? DateUpdated { get; set; }
        public string UpdateString { get; set; }
        public bool IsActive { get; set; }
    }
}
