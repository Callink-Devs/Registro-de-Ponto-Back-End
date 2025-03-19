using Dapper;
using Npgsql;
using WorkHour.Models;
using User.Models;
using ProcessStatus.Models;
using Device.Models;
using Journey.Models;

namespace WorkloadAlert.Infrastructure
{
    public class WorkLoadAlertRepository
    {
        private readonly string _connectionString;

        public WorkloadalertRepository(string connectionString)
        {
            _connectionString = connectionString;
        }

        public int AddWorkloadAlert(WorkLoadAlertModel workLoadAlert)
        {
            using var conn = new NpgsqlConnection(_connectionString);
            string query = @"
                INSERT INTO ""WorkloadAlert""
                (""Id"", ""Label"", ""Order"", ""IsActive"")";

            var result = conn.Execute(query, new
            {
                WorkloadAlert.Id,
                WorkloadAlert.Label,
                WorkloadAlert.Order,
                WorkloadAlert.IsActive
            });
            return result;
        }

        public List<WorkloadAlertModel> GetWorkHours()
        {
            using var conn = new NpgsqlConnection(_connectionString);
            string query = @"
                SELECT wh.*, u.*, d.*, ps.*, j.*, cu.*, uu.*
                FROM ""WorkloadAlert"" wh
                JOIN ""User"" u ON wh.""UserId"" = u.""Id""
                JOIN ""Device"" d ON wh.""DeviceId"" = d.""Id""
                JOIN ""ProcessStatus"" ps ON wh.""ProcessStatusId"" = ps.""Id""
                JOIN ""Journey"" j ON wh.""JourneyId"" = j.""Id""
                JOIN ""User"" cu ON wh.""CreatedBy"" = cu.""Id""
                JOIN ""User"" uu ON wh.""UpdatedBy"" = uu.""Id"";";

            var workHours = conn.Query<WorkHourModel, UserModel, DeviceModel, ProcessStatusModel, JourneyModel, UserModel, UserModel, WorkHourModel>(
                query,
                (label, order, isActive) =>
                {
                    WorkloadAlert.Label = label;
                    WorkloadAlert.Order = order;
                    WorkloadAlert.IsActive = isActive;
                    return WorkloadAlert;
                },
                splitOn: "Id,Id,Id,Id,Id,Id"
            ).ToList();

            return WorkloadAlert;
        }
    }
}

