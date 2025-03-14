using ConnectionAttribute.Models;
using User.Models;

namespace ConnectionWhitelist.Models {
    public class ConnectionWhitelistModel {
        public ConnectionWhitelistModel(ConnectionAttributeModel? connectionAttributeId, string attribute, int attributeLength, string description, string isToDisrgardInHistory, bool isActive, UserModel? createdby, DateTime createddate, UserModel? updatedby, DateTime updatedDate) {
            Id = Guid.NewGuid();
            ConnectionAttributeId = connectionAttributeId;
            Attribute = attribute;
            AttributeLength = attributeLength;
            Description = description;
            IsToDisregardInHitory = isToDisrgardInHistory;
            IsActive = isActive;
            CreatedDate = createddate;
            CreatedBy = createdby;
            UpdatedBy = updatedby;
            UpdatedDate = updatedDate;
        }

        public Guid Id { get; init; }
        public ConnectionAttributeModel? ConnectionAttributeId { get; init; }
        public string Attribute { get; init; }
        public int AttributeLength { get; init; }
        public string Description { get; init; }
        public string IsToDisregardInHitory { get; init; }
        public bool IsActive { get; init; }
        public int CreatedById { get; set; }
        public virtual UserModel? CreatedBy { get; set; } 
        public DateTime CreatedDate { get; set;}
        public int UpdatedById { get; set; }
        public virtual UserModel? UpdatedBy { get; set; }
        public DateTime UpdatedDate { get; set;}
    }
}