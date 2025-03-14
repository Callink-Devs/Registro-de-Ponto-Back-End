using User.Models;

namespace UserSubscription.Models {
    public class UserSubscriptionModel {
        public UserSubscriptionModel(UserModel? userId, string subscriptionJSON, bool isActive, UserModel createdBy, UserModel updatedBy, DateTime createdDate, DateTime updatedDate) {
            UserId = userId;
            SubscriptionJSON = subscriptionJSON;
            IsActive = isActive;
            CreatedBy = createdBy;
            UpdatedBy = updatedBy;
            CreatedDate = createdDate;
            UpdatedDate = updatedDate;
        }
        public UserModel? UserId { get; init; }
        public string SubscriptionJSON { get; set; }
        public bool IsActive { get; set; }
        public int CreatedById { get; set; }
        public virtual UserModel? CreatedBy { get; set; } 
        public DateTime CreatedDate { get; set;}
        public int UpdatedById { get; set; }
        public virtual UserModel? UpdatedBy { get; set; }
        public DateTime UpdatedDate { get; set;}
    }
}