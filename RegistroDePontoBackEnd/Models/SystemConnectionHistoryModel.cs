using User.Models;

namespace SystemConnectionHistory.Models {
    public class SystemConnectionHistoryModel {
        public SystemConnectionHistoryModel(string username, string ip, string hostname, bool whitelistToDisregard, UserModel createdBy, UserModel updatedBy, DateTime createdDate, DateTime updatedDate, bool isActive) {
            Id = Guid.NewGuid();
            Username = username;
            Ip = ip;
            Hostname = hostname;
            WhitelistToDisregard = whitelistToDisregard;
            CreatedBy = createdBy;
            UpdatedBy = updatedBy;
            CreatedDate = createdDate;
            UpdatedDate = updatedDate;
            IsActive = isActive;
        }
        public Guid Id { get; init; }
        public string Username { get; set; }
        public string Ip { get; set; }
        public string Hostname { get; set; }
        public bool WhitelistToDisregard { get; set; }
        public bool IsActive { get; set; }
        public int CreatedById { get; set; }
        public virtual UserModel? CreatedBy { get; set; } 
        public DateTime CreatedDate { get; set;}
        public int UpdatedById { get; set; }
        public virtual UserModel? UpdatedBy { get; set; }
        public DateTime UpdatedDate { get; set;}
    }
}