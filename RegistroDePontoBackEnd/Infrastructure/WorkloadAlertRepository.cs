using RegistroDePontoDbContext.Data;
using WorkloadAlert.Models;

namespace WorkloadAlert.Infrastructure
{
    public class WorkLoadAlertRepository
    {
        public int AddWorkloadAlert(WorkloadAlertModel workLoadAlert)
        {
            using var conn = new RegistroDePontoContext();
            string query = @"
                INSERT INTO ""WorkloadAlert""
                (""Id"", ""Label"", ""Order"", ""IsActive"")";

            var result = conn.Execute(query, new
            {
                workLoadAlert.Id,
                workLoadAlert.Label,
                workLoadAlert.Order,
                workLoadAlert.IsActive
            });
            return result;
        }
    }
}

