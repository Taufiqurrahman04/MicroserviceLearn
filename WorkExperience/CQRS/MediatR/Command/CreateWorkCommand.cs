using MediatR;
using MyCV.Entity;
using MyCV.ViewModel;
using MyCV.ViewModel.APIViewModel;

namespace MyCV.MediatR.Command
{
    public class CreateWorkCommand : IRequest<CommandReponseViewModel<ProfileViewModel>>
    {
        public string Id { get; set; }
        public string CompanyName { get; set; }
        public string CompanyAddress { get; set; }
        public DateTimeOffset DateCreated { get; set; }
        public string UpdateString { get; set; }
        public bool IsActive { get; set; }

        public CreateWorkCommand(string companyName, string companyAddress)
        {
            Id = Guid.NewGuid().ToString();
            CompanyName = companyName;
            CompanyAddress = companyAddress;
            DateCreated = DateTimeOffset.Now;
            UpdateString = "Created on "+DateTimeOffset.Now;
            IsActive = true;
        }

    }
}
