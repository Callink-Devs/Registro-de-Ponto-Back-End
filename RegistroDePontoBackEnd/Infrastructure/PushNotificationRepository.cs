using Dapper;
using PushNotification.Models;
using RegistroDePontoDbContext.Data;

namespace PushNotification.Infrastructure
{
    public class PushNotificationRepository
    {
        public int AddPushNotification(PushNotificationModel pushNotificationModel, int userId, int processStatusId, int workHourId, int workloadAlertId)
        {
            using var conn = new RegistroDePontoContext();
            string query = @"
                INSERT INTO ""PushNotification""
                (""Id"", ""UserSubscriptionId"", ""ProcessStatusId"", ""LastWorkHourId"", ""WorkloadAlertId"", ""SendOnlyToBPI"", ""CreatedById"", ""CreatedDate"", ""UpdatedById"", ""UpdatedDate"", ""IsActive"")
                VALUES (@Id, @UserSubscriptionId, @ProcessStatusId, @LastWorkHourId, @WorkloadAlertId, @SendOnlyToBPI, @CreatedById, @CreatedDate, @UpdatedById, @UpdatedDate, @IsActive)";
            var result = conn.Execute(query, new
            {
                pushNotificationModel.Id,
                UserSubscriptionId = userId,
                ProcessStatusId = processStatusId,
                LastWorkHourId = workHourId,
                WorkloadAlertId = workloadAlertId,
                pushNotificationModel.SendOnlyToBPI,
                CreatedBy = userId,
                UpdatedBy = userId,
                pushNotificationModel.CreatedDate,
                pushNotificationModel.UpdatedDate,
                pushNotificationModel.IsActive
            });
            return result;
        }
        public List<PushNotificationModel> GetPushNotification()
        {
            using var conn = new RegistroDePontoContext();
            string query = @"
                SELECT * FROM ""PushNotification""";
            var result = conn.Connection.Query<PushNotificationModel>(query).ToList();
            return result;
        }
    }
}