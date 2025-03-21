using Dapper;
using RegistroDePontoDbContext.Data;
using User.Models;

namespace User.Infrastructure
{
    public class UserRepository
    {
        public int AddUser(UserModel user)
        {
            using var conn = new RegistroDePontoContext();
            string query = @"
                INSERT INTO ""User""
                (""Id"", ""Name"", ""Email"", ""Password"", ""MobilePhone"", ""ExternalId"", ""CreationDate"", ""LastLogin"", ""IsActive"")
                VALUES (@Id, @Name, @Email, @Password, @MobilePhone, @ExternalId, @CreationDate, @LastLogin, @IsActive)";

            var result = conn.Connection.Execute(query, new
            {
                user.Id,
                user.Name,
                user.Email,
                user.Password,
                user.MobilePhone,
                user.ExternalId,
                user.CreationDate,
                user.LastLogin,
                user.IsActive
            });
            return result;
        }

        public List<UserModel> GetUsers()
        {
            using var conn = new RegistroDePontoContext();
            string query = @"SELECT * FROM ""User"";";

            var result = conn.Connection.Query<UserModel>(query).ToList();
            return result;
        }
    }
}
