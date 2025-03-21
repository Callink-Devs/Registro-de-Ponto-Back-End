using Dapper;
using WorkHour.Models;
using RegistroDePontoDbContext.Data;

namespace WorkHour.Infrastructure
{
    public class WorkHourRepository
    {
        public int AddWorkHour(WorkHourModel workHour, int userId, int deviceId, int processStatusId, int journeyId)
        {
            using var conn = new RegistroDePontoContext();
            string query = @"
                INSERT INTO ""WorkHour""
                (""Id"", ""UserId"", ""DeviceId"", ""ProcessStatusId"", ""JourneyId"", ""IP"", ""SyncDate"", ""IsActive"", ""CreatedBy"", ""UpdatedBy"", ""CreatedDate"", ""UpdatedDate"")
                VALUES (@Id, @UserId, @DeviceId, @ProcessStatusId, @JourneyId, @IP, @SyncDate, @IsActive, @CreatedBy, @UpdatedBy, @CreatedDate, @UpdatedDate)";

            var result = conn.Execute(query, new
            {
                workHour.Id,
                UserId = userId,
                DeviceId = deviceId,
                ProcessStatusId = processStatusId,
                JourneyId = journeyId,
                workHour.IP,
                workHour.SyncDate,
                workHour.IsActive,
                CreatedBy = userId,
                UpdatedBy = userId,
                workHour.CreatedDate,
                workHour.UpdatedDate
            });

            return result;
        }
        public List<WorkHourModel> GetWorkHours()
        {
            using var conn = new RegistroDePontoContext();
            string query = @"
                SELECT * FROM ""WorkHour"";";
            var workHours = conn.Connection.Query<WorkHourModel>(query).ToList();

            return workHours;
        }
    }
}

