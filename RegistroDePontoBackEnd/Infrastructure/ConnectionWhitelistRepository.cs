using ConnectionWhitelist.Models;
using Dapper;
using RegistroDePontoDbContext.Data;

namespace ConnectionWhitelist.Infrastructure
{
    public class ConnectionWhitelistRepository
    {
        public int AddConnectionWhitelist(ConnectionWhitelistModel connectionWhitelist)
        {
            using var conn = new RegistroDePontoContext();
            string query = @"
                INSERT INTO ""ConnectionWhitelist""
                (""Id"",""IP"",""IsActive"")
                VALUES (@Id, @IP, @IsActive)";

            var result = conn.Connection.Execute(query, new
            {
                connectionWhitelist.Id,
                connectionWhitelist.ConnectionAttributeId,
                connectionWhitelist.Attribute,
                connectionWhitelist.AttributeLength,
                connectionWhitelist.Description,
                connectionWhitelist.IsToDisregardInHitory,
                connectionWhitelist.CreatedBy,
                connectionWhitelist.CreatedDate,
                connectionWhitelist.UpdatedBy,
                connectionWhitelist.UpdatedDate,
                connectionWhitelist.IsActive
            });
            return result;
        }

        public List<ConnectionWhitelistModel> GetConnectionWhitelists()
        {
            using var conn = new RegistroDePontoContext();
            string query = @"SELECT * FROM ""ConnectionWhitelist"";";

            var result = conn.Connection.Query<ConnectionWhitelistModel>(query).ToList();
            return result;
        }
    }
}