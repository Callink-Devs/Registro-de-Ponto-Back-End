using ConnectionAttribute.Models;
using User.Models;

namespace ConnectionWhitelist.Models
{
    public class ConnectionWhitelistModel
    {
        public ConnectionWhitelistModel(int connectionAttributeId, string attribute, int attributeLength, string description, string isToDisrgardInHistory, bool isActive, int createdBy, DateTime createdDate, int updatedBy, DateTime updatedDate)
        {
            Id = Guid.NewGuid();
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

        public Guid Id { get; init; }
        public int ConnectionAttributeId { get; init; }
        public string Attribute { get; set; }
        public int AttributeLength { get; set; }
        public string Description { get; set; }
        public string IsToDisregardInHitory { get; set; }
        public bool IsActive { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public int UpdatedBy { get; set; }
        public DateTime UpdatedDate { get; set; }

        public UserModel? CreatedByConnectionWhiteList { get; set; }
        public UserModel? UpdatedByConnectionWhiteList { get; set; }
        public ConnectionAttributeModel? ConnectionAttribute { get; set; }
    }
}