using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace User.Models;

public class UserModel
{

    public UserModel(int id, string name, string email, string password, string mobilePhone, string externalId, DateTime creationDate, DateTime lastLogin, bool isActive)
    {
        Id = id;
        Name = name;
        Email = email;
        Password = password;
        MobilePhone = mobilePhone;
        ExternalId = externalId;
        CreationDate = creationDate;
        LastLogin = lastLogin;
        IsActive = isActive;
    }
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; init; }
    public string Name { get; set; }
    public string Password { get; set; }
    public string Email { get; set; }
    public string MobilePhone { get; set; }
    public string ExternalId { get; set; }
    public DateTime CreationDate { get; set; }
    public DateTime LastLogin { get; set; }
    public bool IsActive { get; set; }

}