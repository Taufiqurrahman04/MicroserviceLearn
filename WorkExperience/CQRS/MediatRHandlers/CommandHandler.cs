using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using MyCV.Entity;
using MyCV.MediatR.Command;
using MyCV.ViewModel;
using MyCV.ViewModel.APIViewModel;
using WorkExperience.AppDbContext;
using WorkExperience.CQRS.MediatR.Command;
using WorkExperience.ViewModel.APIViewModel;

namespace MyCV.MediatRHandlers
{
    public class CommandHandler : IRequestHandler<DeleteWorkCommand, CommandReponseViewModel<ProfileViewModel>>,
        IRequestHandler<UpdateWorkCommand, CommandReponseViewModel<ProfileViewModel>>,
        IRequestHandler<CreateWorkCommand, CommandReponseViewModel<ProfileViewModel>>,
        IRequestHandler<DeleteMyWorkCommand, CommandReponseViewModel<MyWorkExperienceViewModel>>,
        IRequestHandler<UpdateMyWorkCommand, CommandReponseViewModel<MyWorkExperienceViewModel>>,
        IRequestHandler<CreateMyWorkCommand, CommandReponseViewModel<MyWorkExperienceViewModel>>
    {
        private readonly CommandDbContext _context;
        private readonly IMapper _mapper;

        public CommandHandler(CommandDbContext context,
            IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<CommandReponseViewModel<ProfileViewModel>> Handle(DeleteWorkCommand request, CancellationToken cancellationToken)
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

        public async Task<CommandReponseViewModel<ProfileViewModel>> Handle(CreateWorkCommand request, CancellationToken cancellationToken)
        {

            try
            {
                var data = new WorkExperience.Entity.Profile
                {
                    Id = request.Id,
                    CompanyAddress = request.CompanyAddress,
                    CompanyName = request.CompanyName,
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

        public async Task<CommandReponseViewModel<ProfileViewModel>> Handle(UpdateWorkCommand request, CancellationToken cancellationToken)
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

                data.CompanyName = request.CompanyName;
                data.CompanyAddress = request.CompanyAddress;
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

        public async Task<CommandReponseViewModel<MyWorkExperienceViewModel>> Handle(CreateMyWorkCommand request, CancellationToken cancellationToken)
        {
            try
            {
                var data = new MyWorkExperience
                {
                    Id = request.Id,
                    UserRefId = request.UserRefId,
                    ProfileId = request.ProfileId,
                    JobTitle = request.JobTitle,
                    IsCurrent = request.IsCurrent,
                    DateEnd = request.DateEnd,
                    DateStart = request.DateStart,
                    DateCreated = request.DateCreated,
                    UpdateString = request.UpdateString,
                    IsActive = request.IsActive
                };

                await _context.AddAsync(data, cancellationToken);

                await _context.SaveChangesAsync(cancellationToken);

                return new CommandReponseViewModel<MyWorkExperienceViewModel>
                {
                    Data = _mapper.Map<MyWorkExperienceViewModel>(data),
                    IsSuccess = true,
                    Message = "Success Create New Data"
                };
            }
            catch (Exception e)
            {
                return new CommandReponseViewModel<MyWorkExperienceViewModel>
                {
                    Data = null,
                    IsSuccess = false,
                    Message = "Internal Server Error " + e.Message
                };
            }
        }

        public async Task<CommandReponseViewModel<MyWorkExperienceViewModel>> Handle(UpdateMyWorkCommand request, CancellationToken cancellationToken)
        {
            try
            {
                var data = await _context.MyWorkExperiences.FirstOrDefaultAsync(x => x.Id == request.Id, cancellationToken);
                if (data == null)
                {
                    return new CommandReponseViewModel<MyWorkExperienceViewModel>
                    {
                        Data = null,
                        IsSuccess = false,
                        Message = "Data Not Found"
                    };
                }

                data.UserRefId = request.UserRefId;
                data.ProfileId = request.ProfileId;
                data.JobTitle = request.JobTitle;
                data.IsCurrent = request.IsCurrent;
                data.DateEnd = request.DateEnd;
                data.DateStart = request.DateStart;
                data.DateUpdated = request.DateUpdated;
                data.UpdateString = request.UpdateString;


                _context.Update(data);

                await _context.SaveChangesAsync(cancellationToken);

                return new CommandReponseViewModel<MyWorkExperienceViewModel>
                {
                    Data = _mapper.Map<MyWorkExperienceViewModel>(data),
                    IsSuccess = true,
                    Message = "Success Modified the Data"
                };
            }
            catch (Exception e)
            {
                return new CommandReponseViewModel<MyWorkExperienceViewModel>
                {
                    Data = null,
                    IsSuccess = false,
                    Message = "Internal Server Error " + e.Message
                };
            }
        }

        public async Task<CommandReponseViewModel<MyWorkExperienceViewModel>> Handle(DeleteMyWorkCommand request, CancellationToken cancellationToken)
        {
            try
            {
                var data = await _context.MyWorkExperiences.FirstOrDefaultAsync(x => x.Id == request.Id, cancellationToken);
                if (data == null)
                {
                    return new CommandReponseViewModel<MyWorkExperienceViewModel>
                    {
                        Data = null,
                        IsSuccess = false,
                        Message = "Data Not Found"
                    };
                }

                data.IsActive = request.IsActive;
                await _context.SaveChangesAsync(cancellationToken);

                return new CommandReponseViewModel<MyWorkExperienceViewModel>
                {
                    Data = _mapper.Map<MyWorkExperienceViewModel>(data),
                    IsSuccess = true,
                    Message = "Success Delete Data"
                };
            }
            catch (Exception e)
            {
                return new CommandReponseViewModel<MyWorkExperienceViewModel>
                {
                    Data = null,
                    IsSuccess = false,
                    Message = "Internal Server Error " + e.Message
                };
            }
        }
    }
}
