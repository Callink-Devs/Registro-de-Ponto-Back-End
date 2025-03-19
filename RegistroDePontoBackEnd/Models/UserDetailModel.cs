using System.ComponentModel.DataAnnotations.Schema;
using User.Models;

namespace UserDetail.Models
{
    public class UserDetailModel
    {
        public UserDetailModel(int userId, string registration, string pis, string cpf, string networkUser, bool isActive, int createdBy, int updatedBy, DateTime createdDate, DateTime updatedDate)
        {
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
        [ForeignKey("UserId")]
        public int UserId { get; init; }
        public string Registration { get; set; }
        public string PIS { get; set; }
        public string CPF { get; set; }
        public string NetworkUser { get; set; }
        public bool IsActive { get; set; }
        [ForeignKey("UserId")]
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        [ForeignKey("UserId")]
        public int UpdatedBy { get; set; }
        public DateTime UpdatedDate { get; set; }
    }
}