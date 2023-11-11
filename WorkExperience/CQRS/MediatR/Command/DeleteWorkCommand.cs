using MediatR;
using MyCV.Entity;
using MyCV.ViewModel;
using MyCV.ViewModel.APIViewModel;

namespace MyCV.MediatR.Command
{
    public class DeleteWorkCommand : IRequest<CommandReponseViewModel<ProfileViewModel>>
    {
        public string Id { get; set; }
        public bool IsActive { get; set; }
        public DeleteWorkCommand(string id)
        {
            Id = id;
            IsActive = false;
        }
    }
}
