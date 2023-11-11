using MediatR;
using MyCV.Entity;
using MyCV.ViewModel;
using MyCV.ViewModel.APIViewModel;

namespace MyCV.MediatR.Command
{
    public class UpdateCVCommand : IRequest<CommandReponseViewModel<ProfileViewModel>>
    {
        public string Id { get; set; }
        public string FulllName { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string UpdateString { get; set; }
        public DateTimeOffset? DateUpdated { get; set; }

        public UpdateCVCommand(string id, string fullName, string address, string email, string phoneNumber)
        {
            Id = id;
            FulllName = fullName;
            Address = address;
            Email = email;
            PhoneNumber = phoneNumber;
            UpdateString = "Update on "+DateTimeOffset.Now;
            DateUpdated = DateTimeOffset.Now;
        }
    }
}
