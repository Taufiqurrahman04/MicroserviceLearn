using MediatR;
using MyCV.Entity;
using MyCV.ViewModel;
using MyCV.ViewModel.APIViewModel;

namespace MyCV.MediatR.Command
{
    public class DeleteCVCommand : IRequest<CommandReponseViewModel<ProfileViewModel>>
    {
        public string Id { get; set; }
        public bool IsActive { get; set; }
        public DeleteCVCommand(string id)
        {
            Id = id;
            IsActive = false;
        }
    }
}
