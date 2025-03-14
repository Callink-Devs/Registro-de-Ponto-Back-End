using SystemConnectionHistory.Models;
using User.Models;

namespace UserConnectionHistory.Models {
    public class UserConnectionHistoryModel {
        public UserConnectionHistoryModel(UserModel? userModel, SystemConnectionHistoryModel? systemConnectionHistoryModel, string browserIP, string iP, string hostname, bool isMatchedIp, bool isWhitelist, bool isActive, UserModel createdBy, UserModel updatedBy, DateTime createdDate, DateTime updatedDate) {
            Id = Guid.NewGuid();
            UserId = userModel;
            BrowserIPSystemConnectionId = systemConnectionHistoryModel;
            BrowserIP = browserIP;
            IP = iP;
            Hostname = hostname;
            IsMatchedIP = isMatchedIp;
            IsWhitelist = isWhitelist;
            IsActive = isActive;
            CreatedBy = createdBy;
            UpdatedBy = updatedBy;
            CreatedDate = createdDate;
            UpdatedDate = updatedDate;
        }
        public Guid Id { get; init; }
        public UserModel? UserId { get; set; }
        public SystemConnectionHistoryModel? BrowserIPSystemConnectionId { get; set; }
        public string BrowserIP { get; set; }
        public string IP { get; set; }
        public string Hostname { get; set; }
        public bool IsMatchedIP { get; set; }
        public bool IsWhitelist { get; set; }
        public bool IsActive { get; set; }
        public int CreatedById { get; set; }
        public virtual UserModel? CreatedBy { get; set; } 
        public DateTime CreatedDate { get; set;}
        public int UpdatedById { get; set; }
        public virtual UserModel? UpdatedBy { get; set; }
        public DateTime UpdatedDate { get; set;}
    }
}