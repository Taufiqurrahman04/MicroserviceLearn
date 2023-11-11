using AutoMapper;
using MyCV.ViewModel.APIViewModel;

namespace MyCV.Extension
{
    public class MappingService : Profile
    {
        public MappingService()
        {
            CreateMap<Profile, ProfileViewModel>().ReverseMap();
        }
    }
}
