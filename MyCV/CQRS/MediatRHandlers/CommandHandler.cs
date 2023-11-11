using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using MyCV.AppDbContext;
using MyCV.Entity;
using MyCV.MediatR.Command;
using MyCV.ViewModel;
using MyCV.ViewModel.APIViewModel;

namespace MyCV.MediatRHandlers
{
    public class CommandHandler : IRequestHandler<DeleteCVCommand, CommandReponseViewModel<ProfileViewModel>>,
        IRequestHandler<UpdateCVCommand, CommandReponseViewModel<ProfileViewModel>>,
        IRequestHandler<CreateCVCommand, CommandReponseViewModel<ProfileViewModel>>
    {
        private readonly CommandDbContext _context;
        private readonly IMapper _mapper;

        public CommandHandler(CommandDbContext context,
            IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<CommandReponseViewModel<ProfileViewModel>> Handle(DeleteCVCommand request, CancellationToken cancellationToken)
        {
            try
            {
                var data = await _context.Profiles.FirstOrDefaultAsync(x => x.Id == request.Id, cancellationToken);
                if (data == null)
                {
                    return new CommandReponseViewModel<ProfileViewModel>
                    {
                        Data = null,
                        IsSuccess = false,
                        Message = "Data Not Found"
                    };
                }

                data.IsActive = request.IsActive;
                await _context.SaveChangesAsync(cancellationToken);

                return new CommandReponseViewModel<ProfileViewModel>
                {
                    Data = _mapper.Map<ProfileViewModel>(data),
                    IsSuccess = true,
                    Message = "Success Delete Data"
                };
            }
            catch (Exception e)
            {
                return new CommandReponseViewModel<ProfileViewModel>
                {
                    Data = null,
                    IsSuccess = false,
                    Message = "Internal Server Error "+ e.Message
                };
            }
        }

        public async Task<CommandReponseViewModel<ProfileViewModel>> Handle(CreateCVCommand request, CancellationToken cancellationToken)
        {

            try
            {
                var data = new MyCV.Entity.Profile
                {
                    Id = request.Id,
                    FulllName = request.FulllName,
                    Address = request.Address,
                    Email = request.Email,
                    PhoneNumber = request.PhoneNumber,
                    DateCreated = request.DateCreated,
                    UpdateString = request.UpdateString,
                    IsActive = request.IsActive
                };

                await _context.AddAsync(data, cancellationToken);

                await _context.SaveChangesAsync(cancellationToken);

                return new CommandReponseViewModel<ProfileViewModel>
                {
                    Data = _mapper.Map<ProfileViewModel>(data),
                    IsSuccess = true,
                    Message = "Success Create New Data"
                };
            }
            catch (Exception e)
            {
                return new CommandReponseViewModel<ProfileViewModel>
                {
                    Data = null,
                    IsSuccess = false,
                    Message = "Internal Server Error " + e.Message
                };
            }
        }

        public async Task<CommandReponseViewModel<ProfileViewModel>> Handle(UpdateCVCommand request, CancellationToken cancellationToken)
        {
            try
            {
                var data = await _context.Profiles.FirstOrDefaultAsync(x => x.Id == request.Id, cancellationToken);
                if (data == null)
                {
                    return new CommandReponseViewModel<ProfileViewModel>
                    {
                        Data = null,
                        IsSuccess = false,
                        Message = "Data Not Found"
                    };
                }

                data.FulllName = request.FulllName;
                data.Address = request.Address;
                data.Email = request.Email;
                data.PhoneNumber = request.PhoneNumber;
                data.DateUpdated = request.DateUpdated;
                data.UpdateString = request.UpdateString;


               _context.Update(data);

                await _context.SaveChangesAsync(cancellationToken);

                return new CommandReponseViewModel<ProfileViewModel>
                {
                    Data = _mapper.Map<ProfileViewModel>(data),
                    IsSuccess = true,
                    Message = "Success Modified the Data"
                };
            }
            catch (Exception e)
            {
                return new CommandReponseViewModel<ProfileViewModel>
                {
                    Data = null,
                    IsSuccess = false,
                    Message = "Internal Server Error " + e.Message
                };
            }
        }
    }
}
