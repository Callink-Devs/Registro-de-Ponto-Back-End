using Company.Models;
using User.Models;
using WorkGoup.Models;

namespace Device.Models {
    public class DeviceModel {
        public DeviceModel(CompanyModel companyModel, WorkGroupModel workGroupModel, UserModel createdby, UserModel updatedBy, DateTime createdDate, DateTime updatedDate, string code, bool isActive) {
            Id = Guid.NewGuid();
            CompanyId = companyModel;
            WorkGroupId = workGroupModel;
            IsActive = isActive;
            Code = code;
            CreatedBy = createdby;
            CreatedDate = createdDate;
            UpdatedBy = updatedBy;
            UpdatedDate = updatedDate;
        }

        public Guid Id { get; init; }
        public CompanyModel CompanyId { get; set; }
        public WorkGroupModel WorkGroupId { get; set; }
        public string Code { get; set; }
        public bool IsActive { get; set; }
        public int CreatedById { get; set; }
        public virtual UserModel? CreatedBy { get; set; } 
        public DateTime CreatedDate { get; set;}
        public int UpdatedById { get; set; }
        public virtual UserModel? UpdatedBy { get; set; }
        public DateTime UpdatedDate { get; set;}
    }
}