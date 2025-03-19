using System.ComponentModel.DataAnnotations.Schema;
using User.Models;

namespace UserSubscription.Models
{
    public class UserSubscriptionModel
    {
        public UserSubscriptionModel(int userId, string subscriptionJSON, bool isActive, int createdBy, int updatedBy, DateTime createdDate, DateTime updatedDate)
        {
            UserId = userId;
            SubscriptionJSON = subscriptionJSON;
            IsActive = isActive;
            CreatedBy = createdBy;
            UpdatedBy = updatedBy;
            CreatedDate = createdDate;
            UpdatedDate = updatedDate;
        }
        [ForeignKey("UserId")]
        public int UserId { get; init; }
        public string SubscriptionJSON { get; set; }
        public bool IsActive { get; set; }
        [ForeignKey("UserId")]
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        [ForeignKey("UserId")]
        public int UpdatedBy { get; set; }
        public DateTime UpdatedDate { get; set; }
    }
}