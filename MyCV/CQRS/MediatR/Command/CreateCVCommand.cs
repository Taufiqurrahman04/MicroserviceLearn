using MediatR;
using MyCV.Entity;
using MyCV.ViewModel;
using MyCV.ViewModel.APIViewModel;

namespace MyCV.MediatR.Command
{
    public class CreateCVCommand : IRequest<CommandReponseViewModel<ProfileViewModel>>
    {
        public string Id { get; set; }
        public string FulllName { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public DateTimeOffset DateCreated { get; set; }
        public string UpdateString { get; set; }
        public bool IsActive { get; set; }

        public CreateCVCommand(string fullName, string address, string email, string phoneNumber)
        {
            Id = Guid.NewGuid().ToString();
            FulllName = fullName;
            Address = address;
            Email = email;
            PhoneNumber = phoneNumber;
            DateCreated = DateTimeOffset.Now;
            UpdateString = "Created on "+DateTimeOffset.Now;
            IsActive = true;
        }

    }
}
