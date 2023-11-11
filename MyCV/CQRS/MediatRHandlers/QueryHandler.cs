using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using MyCV.AppDbContext;
using MyCV.Entity;
using MyCV.Model.MediatR.Query;
using MyCV.ViewModel.APIViewModel;

namespace MyCV.MediatRHandlers
{
    public class QueryHandler : IRequestHandler<GetDetailCVQuery, ProfileViewModel>,
        IRequestHandler<GetListCVQuery, List<ProfileViewModel>>
    {

        private readonly QueryDbContext _context;
        private readonly IMapper _mapper;
        public QueryHandler(QueryDbContext context,
            IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<List<ProfileViewModel>> Handle(GetListCVQuery request, CancellationToken cancellationToken)
        {
            return await _context.Profiles
                .Select(p=> _mapper.Map<ProfileViewModel>(p))
                .ToListAsync(cancellationToken);
        }

        public async Task<ProfileViewModel> Handle(GetDetailCVQuery request, CancellationToken cancellationToken)
        {
            return await _context.Profiles
                .Select(p=> _mapper.Map<ProfileViewModel>(p))
                .FirstOrDefaultAsync(x => x.Id == request.Id, cancellationToken);
        }
    }
}
