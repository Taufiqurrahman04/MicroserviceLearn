using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using MyCV.Model.MediatR.Query;
using MyCV.ViewModel.APIViewModel;
using WorkExperience.AppDbContext;
using WorkExperience.CQRS.MediatR.Query;
using WorkExperience.ViewModel.APIViewModel;

namespace MyCV.MediatRHandlers
{
    public class QueryHandler : IRequestHandler<GetDetailWorkQuery, ProfileViewModel>,
        IRequestHandler<GetListWorkQuery, List<ProfileViewModel>>,
        IRequestHandler<GetDetailMyWorkQuery, MyWorkExperienceViewModel>,
        IRequestHandler<GetListMyWorkQuery, List<MyWorkExperienceViewModel>>
    {

        private readonly QueryDbContext _context;
        private readonly IMapper _mapper;
        public QueryHandler(QueryDbContext context,
            IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<List<ProfileViewModel>> Handle(GetListWorkQuery request, CancellationToken cancellationToken)
        {
            return await _context.Profiles
                .Select(p=> _mapper.Map<ProfileViewModel>(p))
                .ToListAsync(cancellationToken);
        }

        public async Task<ProfileViewModel> Handle(GetDetailWorkQuery request, CancellationToken cancellationToken)
        {
            return await _context.Profiles
                .Select(p=> _mapper.Map<ProfileViewModel>(p))
                .FirstOrDefaultAsync(x => x.Id == request.Id, cancellationToken);
        }


        public async Task<List<MyWorkExperienceViewModel>> Handle(GetListMyWorkQuery request, CancellationToken cancellationToken)
        {
            return await _context.MyWorkExperiences
               .Select(p => _mapper.Map<MyWorkExperienceViewModel>(p))
               .ToListAsync(cancellationToken);
        }

        public async Task<MyWorkExperienceViewModel> Handle(GetDetailMyWorkQuery request, CancellationToken cancellationToken)
        {
            return await _context.Profiles
              .Select(p => _mapper.Map<MyWorkExperienceViewModel>(p))
              .FirstOrDefaultAsync(x => x.Id == request.Id, cancellationToken);
        }
    }
}
