using MediatR;
using MyCV.ViewModel;
using WorkExperience.ViewModel.APIViewModel;

namespace WorkExperience.CQRS.MediatR.Command
{
    public class UpdateMyWorkCommand : IRequest<CommandReponseViewModel<MyWorkExperienceViewModel>>
    {
        public string Id { get; set; }
        public string UserRefId { get; set; }
        public string ProfileId { get; set; }
        public DateTimeOffset? DateStart { get; set; }
        public DateTimeOffset? DateEnd { get; set; }
        public bool IsCurrent { get; set; }
        public string JobTitle { get; set; }
        public DateTimeOffset? DateUpdated { get; set; }
        public string UpdateString { get; set; }

        public UpdateMyWorkCommand(
                                   string id,
                                   string userRefId,
                                   string profileId,
                                   DateTimeOffset dateStart,
                                   DateTimeOffset? dateEnd,
                                   bool isCurrent,
                                   string jobTitle)
        {
            Id = id;
            this.UserRefId = userRefId;
            this.ProfileId = profileId;
            this.DateStart = dateStart;
            this.DateEnd = dateEnd;
            this.IsCurrent = isCurrent;
            this.JobTitle = jobTitle;
            DateUpdated = DateTimeOffset.Now;
            UpdateString = "Update on " + DateTimeOffset.Now;
        }

    }
}
