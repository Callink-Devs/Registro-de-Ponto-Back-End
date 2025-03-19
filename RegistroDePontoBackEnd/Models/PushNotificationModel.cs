using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PushNotification.Models
{

    public class PushNotificationModel
    {
        public PushNotificationModel(int id, int userSubscriptionId, int processStatusId, int lastWorkHourId, int workloadAlertId, bool sendOnlyToBPI, int createdBy, int updatedBy, DateTime createdDate, DateTime updatedDate, bool isActive)
        {
            Id = id;
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
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public bool SendOnlyToBPI { get; set; }
        public bool IsActive { get; set; }
        [ForeignKey("UserId")]
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        [ForeignKey("UserId")]
        public int UpdatedBy { get; set; }
        public DateTime UpdatedDate { get; set; }

        [ForeignKey("UserSubscriptionId")]
        public int UserSubscriptionId { get; set; }

        [ForeignKey("ProcessStatusId")]
        public int ProcessStatusId { get; set; }

        [ForeignKey("LastWorkHourId")]
        public int LastWorkHourId { get; set; }

        [ForeignKey("WorkloadAlertId")]
        public int WorkloadAlertId { get; set; }
    }
}