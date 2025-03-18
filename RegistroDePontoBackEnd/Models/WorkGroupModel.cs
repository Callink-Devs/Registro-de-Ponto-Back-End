using User.Models;

namespace WorkGoup.Models {
    public class WorkGroupModel {
        public WorkGroupModel(string name, long code, long priority, bool isActive, UserModel? createdBy, UserModel? updatedBy, DateTime createdDate, DateTime updatedDate) {
            Id = Guid.NewGuid();
            Name = name;
            Code = code;
            Priority = priority;
            IsActive = isActive;
            CreatedBy = createdBy;
            UpdatedBy = updatedBy;
            CreatedDate = createdDate;
            UpdatedDate = updatedDate;
        }
        public Guid Id { get; init; }
        public string Name { get; set; }
        public long Code { get; set; }
        public long Priority { get; set; }
        public bool IsActive { get; set; }
        public virtual UserModel? CreatedBy { get; set; } 
        public DateTime CreatedDate { get; set;}
        public virtual UserModel? UpdatedBy { get; set; }
        public DateTime UpdatedDate { get; set;}
    }
}