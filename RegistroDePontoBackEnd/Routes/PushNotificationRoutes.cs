using PushNotification.Infrastructure;
using PushNotification.Models;

namespace Routes.Routes
{
    public static class PushNotificationRoutes
    {
        public static void MapPushNotificationRoutes(this IEndpointRouteBuilder endpoints)
        {
            endpoints.MapPost("/pushNotification/post", (PushNotificationModel pushNotification, PushNotificationRepository repository) =>
            {
                var newPushNotification = new PushNotificationModel(
                    pushNotification.Id,
                    pushNotification.UserSubscriptionId,
                    pushNotification.ProcessStatusId,
                    pushNotification.LastWorkHourId,
                    pushNotification.WorkloadAlertId,
                    pushNotification.SendOnlyToBPI,
                    pushNotification.CreatedBy,
                    pushNotification.UpdatedBy,
                    pushNotification.CreatedDate,
                    pushNotification.UpdatedDate,
                    pushNotification.IsActive
                );
                repository.AddPushNotification(newPushNotification, pushNotification.UserSubscriptionId, pushNotification.ProcessStatusId, pushNotification.LastWorkHourId, pushNotification.WorkloadAlertId);
                return Results.Created($"/pushNotification/{pushNotification.Id}", pushNotification);
            });

            endpoints.MapGet("/pushNotification/get", (PushNotificationRepository repository) =>
            {
                var pushNotifications = repository.GetPushNotification();
                return Results.Ok(pushNotifications);
            });
        }
    }
}