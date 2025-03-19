using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SystemParameter.Models
{
    public class SystemParameterModel
    {
        public SystemParameterModel(int id, string label, string order, bool isactive)
        {
            Label = label;
            Order = order;
            IsActive = isactive;
            Id = id;
        }
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; init; }
        public string Label { get; set; }
        public string Order { get; set; }
        public bool IsActive { get; set; }
    }
}