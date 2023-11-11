using MediatR;
using MyCV.Entity;
using MyCV.ViewModel.APIViewModel;

namespace MyCV.Model.MediatR.Query
{
    public class GetListCVQuery : IRequest<List<ProfileViewModel>>
    {

    }
}
