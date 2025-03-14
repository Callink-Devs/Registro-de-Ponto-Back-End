using User.Models;

namespace UserDetail.Models {
    public class UserDetailModel {
        public UserDetailModel(UserModel? userId, string registration, string pis, string cpf, string networkUser, bool isActive, UserModel createdBy, UserModel updatedBy, DateTime createdDate, DateTime updatedDate) {
            UserId = userId;
            Registration = registration;
            PIS = pis;
            CPF = cpf;
            NetworkUser = networkUser;
            IsActive = isActive;
            CreatedBy = createdBy;
            UpdatedBy = updatedBy;
            CreatedDate = createdDate;
            UpdatedDate = updatedDate;
        }
        public UserModel? UserId { get; init; }
        public string Registration { get; set; }
        public string PIS { get; set; }
        public string CPF { get; set; }
        public string NetworkUser { get; set; }
        public bool IsActive { get; set; }
        public int CreatedById { get; set; }
        public virtual UserModel? CreatedBy { get; set; } 
        public DateTime CreatedDate { get; set;}
        public int UpdatedById { get; set; }
        public virtual UserModel? UpdatedBy { get; set; }
        public DateTime UpdatedDate { get; set;}
    }
}