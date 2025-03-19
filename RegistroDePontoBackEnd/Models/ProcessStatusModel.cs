using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProcessStatus.Models
{
    public class ProcessStatusModel(int id, string label, string order, bool isactive)
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; init; } = id;
        public string Label { get; set; } = label;
        public string Order { get; set; } = order;
        public bool IsActive { get; set; } = isactive;
    }
}