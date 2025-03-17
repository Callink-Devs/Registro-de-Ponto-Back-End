using Device.Models;
using Journey.Models;
using ProcessStatus.Models;
using User.Models;

namespace WorkHour.Models
{
    public class WorkHourModel
    {
        public WorkHourModel(int userId, int deviceId, int processStatusId, int journeyId, string iP, DateTime syncDate, bool isActive, int createdBy, int updatedBy, DateTime createdDate, DateTime updatedDate)
        {
            Id = Guid.NewGuid();
            UserId = userId;
            DeviceId = deviceId;
            ProcessStatusId = processStatusId;
            JourneyId = journeyId;
            IP = iP;
            SyncDate = syncDate;
            IsActive = isActive;
            CreatedBy = createdBy;
            UpdatedBy = updatedBy;
            CreatedDate = createdDate;
            UpdatedDate = updatedDate;
        }

        public Guid Id { get; init; }
        public int UserId { get; init; }
        public int DeviceId { get; init; }
        public int ProcessStatusId { get; init; }
        public int JourneyId { get; init; }
        public DateTime WorkHour { get; set; }
        public string IP { get; set; }
        public DateTime SyncDate { get; set; }
        public bool IsActive { get; set; }
        public int CreatedById { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public int UpdatedById { get; set; }
        public int UpdatedBy { get; set; }
        public DateTime UpdatedDate { get; set; }

        public UserModel? User { get; set; }
        public DeviceModel? Device { get; set; }
        public ProcessStatusModel? ProcessStatus { get; set; }
        public JourneyModel? Journey { get; set; }
        public UserModel? CreatedByUser { get; set; }
        public UserModel? UpdatedByUser { get; set; }
    }
}