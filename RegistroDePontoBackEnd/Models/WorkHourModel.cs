using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Device.Models;
using Journey.Models;
using ProcessStatus.Models;
using User.Models;

namespace WorkHour.Models
{
    public class WorkHourModel
    {
        public WorkHourModel(int id, int userId, int deviceId, int processStatusId, int journeyId, string iP, DateTime syncDate, bool isActive, int createdBy, int updatedBy, DateTime createdDate, DateTime updatedDate)
        {
            Id = id;
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
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; init; }
        [ForeignKey("UserId")]
        public int UserId { get; init; }
        [ForeignKey("DeviceId")]
        public int DeviceId { get; init; }
        [ForeignKey("ProcessStatusId")]
        public int ProcessStatusId { get; init; }
        [ForeignKey("JourneyId")]
        public int JourneyId { get; init; }
        public DateTime WorkHour { get; set; }
        public string IP { get; set; }
        public DateTime SyncDate { get; set; }
        public bool IsActive { get; set; }
        [ForeignKey("UserId")]
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        [ForeignKey("UserId")]
        public int UpdatedBy { get; set; }
        public DateTime UpdatedDate { get; set; }
    }
}