using ConnectionWhitelist.Models;
using Dapper;
using RegistroDePontoDbContext.Data;

namespace ConnectionWhitelist.Infrastructure
{
    public class ConnectionWhitelistRepository
    {
        public int AddConnectionWhitelist(ConnectionWhitelistModel connectionWhitelist, int connectionAttributeId, int userId)
        {
            using var conn = new RegistroDePontoContext();
            string query = @"
        INSERT INTO ""ConnectionWhitelist""
        (""Id"", ""IP"", ""IsActive"", ""ConnectionAttributeId"", ""Attribute"", ""AttributeLength"", ""Description"", ""IsToDisregardInHitory"", ""CreatedBy"", ""UpdatedBy"", ""CreatedDate"", ""UpdatedDate"")
        VALUES (@Id, @IP, @IsActive, @ConnectionAttributeId, @Attribute, @AttributeLength, @Description, @IsToDisregardInHitory, @CreatedBy, @UpdatedBy, @CreatedDate, @UpdatedDate)";

            var result = conn.Connection.Execute(query, new
            {
                connectionWhitelist.Id,
                ConnectionAttributeId = connectionAttributeId,
                connectionWhitelist.Attribute,
                connectionWhitelist.AttributeLength,
                connectionWhitelist.Description,
                connectionWhitelist.IsToDisregardInHitory,
                CreatedBy = userId,
                UpdatedBy = userId,
                connectionWhitelist.IsActive,
                connectionWhitelist.CreatedDate,
                connectionWhitelist.UpdatedDate
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