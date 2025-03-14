using User.Models;

namespace Parameter.Models {
    public class ParameterModel {
        public ParameterModel(string name, string description, string value, bool isSystemParameter, bool isActive, DateTime createdDate, DateTime updatedDate, UserModel? createdBy, UserModel? updatedBy) {
            Id = Guid.NewGuid();
            Name = name;
            Description = description;
            Value = value;
            IsActive = isActive;
            CreatedDate = createdDate;
            UpdatedDate = updatedDate;
            CreatedBy = createdBy;
            UpdatedBy = updatedBy;
        }
        public Guid Id { get; init; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Value { get; set; }
        public bool IsSystemParameter { get; set; }
        public bool IsActive { get; set; }
        public int CreatedById { get; set; }
        public virtual UserModel? CreatedBy { get; set; } 
        public DateTime CreatedDate { get; set;}
        public int UpdatedById { get; set; }
        public virtual UserModel? UpdatedBy { get; set; }
        public DateTime UpdatedDate { get; set;}
    }
}