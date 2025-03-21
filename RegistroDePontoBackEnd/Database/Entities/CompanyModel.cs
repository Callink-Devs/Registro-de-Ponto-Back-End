using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using User.Models;

namespace Company.Models;

public class CompanyModel
{

    public CompanyModel(int id, string name, string code, bool isactive, int createdby, DateTime createddate, int updatedby, DateTime updateddate)
    {
        Name = name;
        Code = code;
        IsActive = isactive;
        CreatedDate = createddate;
        CreatedBy = createdby;
        UpdatedBy = updatedby;
        UpdatedDate = updateddate;
        Id = id;
    }
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; init; }
    public string Name { get; set; }
    public string Code { get; set; }
    public bool IsActive { get; set; }
    public int CreatedBy { get; set; }
    public DateTime CreatedDate { get; set; }
    public int UpdatedBy { get; set; }
    public UserModel? User { get; set; }
    public DateTime UpdatedDate { get; set; }
}