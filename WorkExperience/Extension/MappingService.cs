using AutoMapper;
using MyCV.Entity;
using MyCV.ViewModel.APIViewModel;
using WorkExperience.ViewModel.APIViewModel;

namespace MyCV.Extension
{
    public class MappingService : Profile
    {
        public MappingService()
        {
            CreateMap<Profile, ProfileViewModel>().ReverseMap();
            CreateMap<MyWorkExperience, MyWorkExperienceViewModel>().ReverseMap();
        }
    }
}
