using MediatR;
using WorkExperience.ViewModel.APIViewModel;

namespace WorkExperience.CQRS.MediatR.Query
{
    public class GetListMyWorkQuery : IRequest<List<MyWorkExperienceViewModel>>
    {

    }
}
