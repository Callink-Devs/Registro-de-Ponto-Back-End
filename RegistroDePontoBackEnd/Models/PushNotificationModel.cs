using ProcessStatus.Models;
using User.Models;
using UserSubscription.Models;
using WorkHour.Models;
using WorkloadAlert.Models;

namespace PushNotification.Models {
    
    public class PushNotificationModel {
        public PushNotificationModel(UserSubscriptionModel userSubscriptionId, ProcessStatusModel processStatusId, WorkHourModel lastWorkHourId, WorkloadAlertModel workloadAlertId, bool sendOnlyToBPI, UserModel createdBy, UserModel updatedBy, DateTime createdDate, DateTime updatedDate, bool isActive) {
            Id = Guid.NewGuid();
            UserSubscriptionId = userSubscriptionId;
            ProcessStatusId = processStatusId;
            LastWorkHourId = lastWorkHourId;
            WorkloadAlertId = workloadAlertId;
            SendOnlyToBPI = sendOnlyToBPI;
            CreatedBy = createdBy;
            UpdatedBy = updatedBy;
            CreatedDate = createdDate;
            UpdatedDate = updatedDate;
            IsActive = isActive;
        }
        public Guid Id { get; init; }
        public UserSubscriptionModel UserSubscriptionId { get; set; }
        public ProcessStatusModel ProcessStatusId { get; set; }
        public WorkHourModel LastWorkHourId { get; set; }
        public WorkloadAlertModel WorkloadAlertId { get; set; }
        public bool SendOnlyToBPI { get; set; }
        public bool IsActive { get; set; }
        public int CreatedById { get; set; }
        public virtual UserModel? CreatedBy { get; set; } 
        public DateTime CreatedDate { get; set;}
        public int UpdatedById { get; set; }
        public virtual UserModel? UpdatedBy { get; set; }
        public DateTime UpdatedDate { get; set;}
    }
}