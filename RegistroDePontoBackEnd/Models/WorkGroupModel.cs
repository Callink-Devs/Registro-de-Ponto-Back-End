using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using User.Models;

namespace WorkGoup.Models
{
    public class WorkGroupModel
    {
        public WorkGroupModel(int id, string name, long code, long priority, bool isActive, int createdBy, int updatedBy, DateTime createdDate, DateTime updatedDate)
        {
            Id = id;
            Name = name;
            Code = code;
            Priority = priority;
            IsActive = isActive;
            CreatedBy = createdBy;
            UpdatedBy = updatedBy;
            CreatedDate = createdDate;
            UpdatedDate = updatedDate;
        }
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; init; }
        public string Name { get; set; }
        public long Code { get; set; }
        public long Priority { get; set; }
        public bool IsActive { get; set; }
<<<<<<< HEAD
        [ForeignKey("UserId")]
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        [ForeignKey("UserId")]
        public int UpdatedBy { get; set; }
        public DateTime UpdatedDate { get; set; }
=======
        public virtual UserModel? CreatedBy { get; set; } 
        public DateTime CreatedDate { get; set;}
        public virtual UserModel? UpdatedBy { get; set; }
        public DateTime UpdatedDate { get; set;}
>>>>>>> 56323271f8cf092ce1e3b116470146fa4e55748f
    }
}