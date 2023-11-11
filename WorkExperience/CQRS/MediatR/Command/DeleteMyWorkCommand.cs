using MediatR;
using MyCV.ViewModel;
using MyCV.ViewModel.APIViewModel;
using WorkExperience.ViewModel.APIViewModel;

namespace WorkExperience.CQRS.MediatR.Command
{
    public class DeleteMyWorkCommand : IRequest<CommandReponseViewModel<MyWorkExperienceViewModel>>
    {
        public string Id { get; set; }
        public bool IsActive { get; set; }
        public DeleteMyWorkCommand(string id)
        {
            Id = id;
            IsActive = false;
        }
    }
}
