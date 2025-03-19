using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConnectionWhitelist.Models
{
    public class ConnectionWhitelistModel
    {
        public ConnectionWhitelistModel(int id, int connectionAttributeId, string attribute, int attributeLength, string description, string isToDisrgardInHistory, bool isActive, int createdBy, DateTime createdDate, int updatedBy, DateTime updatedDate)
        {
            Id = id;
            ConnectionAttributeId = connectionAttributeId;
            Attribute = attribute;
            AttributeLength = attributeLength;
            Description = description;
            IsToDisregardInHitory = isToDisrgardInHistory;
            IsActive = isActive;
            CreatedDate = createdDate;
            CreatedBy = createdBy;
            UpdatedBy = updatedBy;
            UpdatedDate = updatedDate;
        }
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; init; }
        [ForeignKey("ConnectionAttributeId")]
        public int ConnectionAttributeId { get; init; }
        public string Attribute { get; set; }
        public int AttributeLength { get; set; }
        public string Description { get; set; }
        public string IsToDisregardInHitory { get; set; }
        public bool IsActive { get; set; }
        [ForeignKey("UserId")]
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        [ForeignKey("UserId")]
        public int UpdatedBy { get; set; }
        public DateTime UpdatedDate { get; set; }
    }
}