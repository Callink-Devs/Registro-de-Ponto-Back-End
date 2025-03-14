using User.Models;

namespace Journey.Models {
    public class JourneyModel {

        public JourneyModel() { }
        public JourneyModel(DateTime startIn, bool isActive, UserModel? createdBy, UserModel? updatedBy, DateTime createdDate, DateTime updatedDate) {
            Id = Guid.NewGuid();
            StartIn = startIn;
            IsActive = isActive;
            CreatedBy = createdBy;
            UpdatedBy = updatedBy;
            CreatedDate = createdDate;
            UpdatedDate = updatedDate;
        }
        public Guid Id { get; init; }
        public DateTime StartIn { get; set; }
        public bool IsActive { get; set; }
        public int CreatedById { get; set; }
        public virtual UserModel? CreatedBy { get; set; } 
        public DateTime CreatedDate { get; set;}
        public int UpdatedById { get; set; }
        public virtual UserModel? UpdatedBy { get; set; }
        public DateTime UpdatedDate { get; set;}

    }
}