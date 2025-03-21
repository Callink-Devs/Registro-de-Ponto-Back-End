using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace UserConnectionHistory.Models
{
    public class UserConnectionHistoryModel
    {
        public UserConnectionHistoryModel(int id, int userId, int browserIPSystemConnectionId, string browserIP, string iP, string hostname, bool isMatchedIp, bool isWhitelist, bool isActive, int createdBy, int updatedBy, DateTime createdDate, DateTime updatedDate)
        {
            Id = id;
            UserId = userId;
            BrowserIPSystemConnectionId = browserIPSystemConnectionId;
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
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; init; }
        [ForeignKey("SystemConnectionHistoryId")]
        public int BrowserIPSystemConnectionId { get; set; }
        [ForeignKey("UserId")]
        public int UserId { get; set; }
        public string BrowserIP { get; set; }
        public string IP { get; set; }
        public string Hostname { get; set; }
        public bool IsMatchedIP { get; set; }
        public bool IsWhitelist { get; set; }
        public bool IsActive { get; set; }
        [ForeignKey("UserId")]
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        [ForeignKey("UserId")]
        public int UpdatedBy { get; set; }
        public DateTime UpdatedDate { get; set; }
    }
}