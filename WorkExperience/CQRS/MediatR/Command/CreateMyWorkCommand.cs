using MediatR;
using MyCV.ViewModel;
using MyCV.ViewModel.APIViewModel;
using WorkExperience.ViewModel.APIViewModel;

namespace WorkExperience.CQRS.MediatR.Command
{
    public class CreateMyWorkCommand : IRequest<CommandReponseViewModel<MyWorkExperienceViewModel>>
    {
        public string Id { get; set; }
        public string UserRefId { get; set; }
        public string ProfileId { get; set; }
        public DateTimeOffset? DateStart { get; set; }
        public DateTimeOffset? DateEnd { get; set; }
        public bool IsCurrent { get; set; }
        public string JobTitle { get; set; }
        public DateTimeOffset DateCreated { get; set; }
        public string UpdateString { get; set; }
        public bool IsActive { get; set; }

        public CreateMyWorkCommand(string userRefId, 
                                   string profileId, 
                                   DateTimeOffset dateStart, 
                                   DateTimeOffset? dateEnd,
                                   bool isCurrent,
                                   string jobTitle)
        {
            Id = Guid.NewGuid().ToString();
            this.UserRefId = userRefId;
            this.ProfileId = profileId;
            this.DateStart = dateStart;
            this.DateEnd = dateEnd;
            this.IsCurrent = isCurrent;
            this.JobTitle = jobTitle;
            DateCreated = DateTimeOffset.Now;
            UpdateString = "Created on " + DateTimeOffset.Now;
            IsActive = true;
        }

    }
}
