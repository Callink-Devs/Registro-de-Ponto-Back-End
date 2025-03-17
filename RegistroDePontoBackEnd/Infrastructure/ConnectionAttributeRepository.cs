using ConnectionAttribute.Models;
using Dapper;
using RegistroDePontoDbContext.Data;

namespace ConnectionAttribute.Infrastructure
{
    public class ConnectionAttributeRepository
    {
        public int AddConnectionAttribute(ConnectionAttributeModel connectionAttribute)
        {
            using var conn = new RegistroDePontoContext();
            string query = @"
                INSERT INTO ""ConnectionAttribute""
                (""Id"",""ConnectionId"", ""AttributeId"", ""Value"", ""IsActive"", ""CreatedBy"", ""UpdatedBy"", ""CreatedDate"", ""UpdatedDate"")
                VALUES (@Id, @ConnectionId, @AttributeId, @Value, @IsActive, @CreatedBy, @UpdatedBy, @CreatedDate, @UpdatedDate)";

            var result = conn.Connection.Execute(query, new
            {
                connectionAttribute.Id,
                connectionAttribute.Label,
                connectionAttribute.Order,
                connectionAttribute.IsActive
            });
            return result;
        }

        public List<ConnectionAttributeModel> GetConnectionAttributes()
        {
            using var conn = new RegistroDePontoContext();
            string query = @"SELECT * FROM ""ConnectionAttribute"";";

            var result = conn.Connection.Query<ConnectionAttributeModel>(query).ToList();
            return result;
        }
    }
}