using Dapper;
using ProcessStatus.Models;
using RegistroDePontoDbContext.Data;

namespace ProcessStatus.Infrastructure
{
    public class ProcessStatusRepository
    {
        public int AddProcessStatus(ProcessStatusModel processStatus)
        {
            using var conn = new RegistroDePontoContext();
            string query = @"
                INSERT INTO ""ProcessStatus""
                (""Id"", ""Label"", ""Order"", ""IsActive"")
                VALUES (@Id, @Name, @Description, @IsActive)";
            var result = conn.Execute(query, new
            {
                processStatus.Id,
                processStatus.Label,
                processStatus.Order,
                processStatus.IsActive
            });
            return result;
        }

        public List<ProcessStatusModel> GetProcessStatus()
        {
            using var conn = new RegistroDePontoContext();
            string query = @"
                SELECT * FROM ""ProcessStatus""";
            var result = conn.Connection.Query<ProcessStatusModel>(query).ToList();
            return result;
        }
    }
}