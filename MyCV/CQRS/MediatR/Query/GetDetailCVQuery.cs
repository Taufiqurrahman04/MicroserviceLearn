using MediatR;
using MyCV.Entity;
using MyCV.ViewModel.APIViewModel;

namespace MyCV.Model.MediatR.Query
{
    public class GetDetailCVQuery : IRequest<ProfileViewModel>
    {
        public string Id { get; set; }
    }
}
