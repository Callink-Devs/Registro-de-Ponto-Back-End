using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Parameter.Models
{
    public class ParameterModel
    {
        public ParameterModel(int id, string name, string description, string value, bool isSystemParameter, bool isActive, DateTime createdDate, DateTime updatedDate, int createdBy, int updatedBy)
        {
            Id = id;
            Name = name;
            Description = description;
            Value = value;
            IsSystemParameter = isSystemParameter;
            IsActive = isActive;
            CreatedDate = createdDate;
            UpdatedDate = updatedDate;
            CreatedBy = createdBy;
            UpdatedBy = updatedBy;
        }
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; init; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Value { get; set; }
        public bool IsSystemParameter { get; set; }
        public bool IsActive { get; set; }
        [ForeignKey("UserId")]
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        [ForeignKey("UserId")]
        public int UpdatedBy { get; set; }
        public DateTime UpdatedDate { get; set; }
    }
}