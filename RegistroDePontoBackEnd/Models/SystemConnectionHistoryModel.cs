using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SystemConnectionHistory.Models
{
    public class SystemConnectionHistoryModel
    {
        public SystemConnectionHistoryModel(int id, string username, string ip, string hostname, bool whitelistToDisregard, int createdBy, int updatedBy, DateTime createdDate, DateTime updatedDate, bool isActive)
        {
            Id = id;
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
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; init; }
        public string Username { get; set; }
        public string Ip { get; set; }
        public string Hostname { get; set; }
        public bool WhitelistToDisregard { get; set; }
        public bool IsActive { get; set; }
        [ForeignKey("UserId")]
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        [ForeignKey("UserId")]
        public int UpdatedBy { get; set; }
        public DateTime UpdatedDate { get; set; }
    }
}