using MediatR;
using WorkExperience.ViewModel.APIViewModel;

namespace WorkExperience.CQRS.MediatR.Query
{
    public class GetDetailMyWorkQuery : IRequest<MyWorkExperienceViewModel>
    {
        public string Id { get; set; }
    }
}
