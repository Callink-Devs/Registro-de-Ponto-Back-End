using Dapper;
using Npgsql;
using WorkHour.Models;
using User.Models;
using ProcessStatus.Models;
using Device.Models;
using Journey.Models;

namespace WorkHour.Infrastructure
{
    public class WorkHourRepository
    {
        private readonly string _connectionString;

        public WorkHourRepository(string connectionString)
        {
            _connectionString = connectionString;
        }

        public int AddWorkHour(WorkHourModel workHour)
        {
            using var conn = new NpgsqlConnection(_connectionString);
            string query = @"
                INSERT INTO ""WorkHour""
                (""Id"", ""UserId"", ""DeviceId"", ""ProcessStatusId"", ""JourneyId"", ""IP"", ""SyncDate"", ""IsActive"", ""CreatedBy"", ""UpdatedBy"", ""CreatedDate"", ""UpdatedDate"")
                VALUES (@Id, @UserId, @DeviceId, @ProcessStatusId, @JourneyId, @IP, @SyncDate, @IsActive, @CreatedBy, @UpdatedBy, @CreatedDate, @UpdatedDate)";

            var result = conn.Execute(query, new
            {
                workHour.Id,
                workHour.UserId,
                workHour.DeviceId,
                workHour.ProcessStatusId,
                workHour.JourneyId,
                workHour.IP,
                workHour.SyncDate,
                workHour.IsActive,
                workHour.CreatedBy,
                workHour.UpdatedBy,
                workHour.CreatedDate,
                workHour.UpdatedDate
            });
            return result;
        }

        public List<WorkHourModel> GetWorkHours()
        {
            using var conn = new NpgsqlConnection(_connectionString);
            string query = @"
                SELECT wh.*, u.*, d.*, ps.*, j.*, cu.*, uu.*
                FROM ""WorkHour"" wh
                JOIN ""User"" u ON wh.""UserId"" = u.""Id""
                JOIN ""Device"" d ON wh.""DeviceId"" = d.""Id""
                JOIN ""ProcessStatus"" ps ON wh.""ProcessStatusId"" = ps.""Id""
                JOIN ""Journey"" j ON wh.""JourneyId"" = j.""Id""
                JOIN ""User"" cu ON wh.""CreatedBy"" = cu.""Id""
                JOIN ""User"" uu ON wh.""UpdatedBy"" = uu.""Id"";";

            var workHours = conn.Query<WorkHourModel, UserModel, DeviceModel, ProcessStatusModel, JourneyModel, UserModel, UserModel, WorkHourModel>(
                query,
                (workHour, user, device, processStatus, journey, createdByUser, updatedByUser) =>
                {
                    workHour.User = user;
                    workHour.Device = device;
                    workHour.ProcessStatus = processStatus;
                    workHour.Journey = journey;
                    workHour.CreatedByUser = createdByUser;
                    workHour.UpdatedByUser = updatedByUser;
                    return workHour;
                },
                splitOn: "Id,Id,Id,Id,Id,Id"
            ).ToList();

            return workHours;
        }
    }
}

