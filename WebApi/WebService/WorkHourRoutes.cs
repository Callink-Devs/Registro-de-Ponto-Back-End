using WorkHour.Infrastructure;
using WorkHour.Models;

namespace WorkHourRoutes
{
    public static class WorkHourRote
    {
        public static void WorkHourRoutes(this WebApplication app)
        {
            app.MapPost("post", (WorkHourModel workHour, WorkHourRepository repository) =>
            {
                var newWork = new WorkHourModel(
                    workHour.Id,
                    workHour.UserId,
                    workHour.DeviceId,
                    workHour.ProcessStatusId,
                    workHour.JourneyId,
                    workHour.IP,
                    workHour.SyncDate,
                    workHour.SyncDate,
                    workHour.IsActive,
                    workHour.CreatedBy,
                    workHour.UpdatedBy,
                    workHour.CreatedDate,
                    workHour.UpdatedDate
                );
                repository.AddWorkHour(newWork, workHour.UserId, workHour.DeviceId, workHour.ProcessStatusId, workHour.JourneyId);
                return Results.Created($"/workhour/{workHour.Id}", workHour);
            });
            app.MapGet("get", (WorkHourRepository repository) =>
            {
                var workHours = repository.GetWorkHours();
                return Results.Ok(workHours);
            });
        }
    }
}