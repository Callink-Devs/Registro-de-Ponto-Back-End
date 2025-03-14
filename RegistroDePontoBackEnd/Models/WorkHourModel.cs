using Device.Models;
using Journey.Models;
using ProcessStatus.Models;
using User.Models;

namespace WorkHour.Models {
    public class WorkHourModel {
        public WorkHourModel(UserModel userId, DeviceModel deviceId, ProcessStatusModel processStatusId, JourneyModel journeyId, DateTime workHour, string ip, DateTime syncDate,bool isActive, UserModel createdBy, UserModel updatedBy, DateTime createdDate, DateTime updatedDate) {
            Id = Guid.NewGuid();
            UserId = userId;
            DeviceId = deviceId;
            ProcessStatusId = processStatusId;
            JourneyId = journeyId;
            WorkHour = workHour;
            IP = ip;
            SyncDate = syncDate;
            IsActive = isActive;
            CreatedBy = createdBy;
            UpdatedBy = updatedBy;
            CreatedDate = createdDate;
            UpdatedDate = updatedDate;
        }
        public Guid Id { get; init; }
        public UserModel UserId { get; init; }
        public DeviceModel DeviceId { get; init; }
        public ProcessStatusModel ProcessStatusId { get; init; }
        public JourneyModel JourneyId { get; init; }
        public DateTime WorkHour { get; set; }
        public string IP { get; set; }
        public DateTime SyncDate { get; set; }
        public bool IsActive { get; set; }
        public int CreatedById { get; set; }
        public virtual UserModel? CreatedBy { get; set; } 
        public DateTime CreatedDate { get; set;}
        public int UpdatedById { get; set; }
        public virtual UserModel? UpdatedBy { get; set; }
        public DateTime UpdatedDate { get; set;}
    }
}