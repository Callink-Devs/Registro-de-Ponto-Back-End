using Dapper;
using Parameter.Models;
using RegistroDePontoDbContext.Data;
using User.Models;

namespace Parameter.Infrastructure
{
    public class ParameterRepository
    {
        public int AddParameter(ParameterModel parameter, int userId)
        {
            using var conn = new RegistroDePontoContext();
            string query = @"
                INSERT INTO ""Parameter""
                (""Id"", ""Name"", ""Description"", ""Value"", ""IsSystemParameter"", ""CreatedBy"", ""UpdatedBy"", ""CreatedDate"", ""UpdatedDate"", ""IsActive"")
                VALUES (@Id, @CompanyId, @WorkGroupId, @CreatedBy, @UpdatedBy, @CreatedDate, @UpdatedDate, @Code, @IsActive)";
            var result = conn.Execute(query, new
            {
                parameter.Id,
                parameter.Name,
                parameter.Description,
                parameter.Value,
                parameter.IsSystemParameter,
                CreatedBy = userId,
                UpdatedBy = userId,
                parameter.CreatedDate,
                parameter.UpdatedDate,
                parameter.IsActive
            });
            return result;
        }

        public List<ParameterModel> GetParameters()
        {
            using var conn = new RegistroDePontoContext();
            string query = @"
                SELECT * FROM ""Parameter"";";
            var parameters = conn.Connection.Query<ParameterModel>(query).ToList();
            return parameters;
        }
    }
}