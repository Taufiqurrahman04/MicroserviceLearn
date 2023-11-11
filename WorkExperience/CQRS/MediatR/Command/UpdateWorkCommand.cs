using MediatR;
using MyCV.Entity;
using MyCV.ViewModel;
using MyCV.ViewModel.APIViewModel;

namespace MyCV.MediatR.Command
{
    public class UpdateWorkCommand : IRequest<CommandReponseViewModel<ProfileViewModel>>
    {
        public string Id { get; set; }
        public string CompanyName { get; set; }
        public string CompanyAddress { get; set; }
        public string UpdateString { get; set; }
        public DateTimeOffset? DateUpdated { get; set; }

        public UpdateWorkCommand(string id, string companyName, string companyAddress)
        {
            Id = id;
            CompanyName = companyName;
            CompanyAddress = companyAddress;
            UpdateString = "Update on "+DateTimeOffset.Now;
            DateUpdated = DateTimeOffset.Now;
        }
    }
}
