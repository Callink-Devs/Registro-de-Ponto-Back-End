using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Device.Models
{
    public class DeviceModel
    {
        public DeviceModel(int id, int companyId, int workGroupId, int createdby, int updatedBy, DateTime createdDate, DateTime updatedDate, string code, bool isActive)
        {
            Id = id;
            CompanyId = companyId;
            WorkGroupId = workGroupId;
            IsActive = isActive;
            Code = code;
            CreatedBy = createdby;
            CreatedDate = createdDate;
            UpdatedBy = updatedBy;
            UpdatedDate = updatedDate;
        }
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; init; }
        public string Code { get; set; }
        public bool IsActive { get; set; }
        [ForeignKey("UserId")]
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        [ForeignKey("UserId")]
        public int UpdatedBy { get; set; }
        public DateTime UpdatedDate { get; set; }
        [ForeignKey("CompanyId")]
        public int CompanyId { get; set; }
        [ForeignKey("WorkGroupId")]
        public int WorkGroupId { get; set; }
    }
}