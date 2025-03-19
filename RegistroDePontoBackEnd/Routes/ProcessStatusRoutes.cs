using ProcessStatus.Infrastructure;
using ProcessStatus.Models;

namespace ProcessStatusRoute.Routes
{
    public static class ProcessStatusRoutes
    {
        public static void ProcessStatusRoute(this WebApplication app)
        {
            app.MapPost("post", (ProcessStatusModel processStatus, ProcessStatusRepository repository) =>
            {
                var newProcessStatus = new ProcessStatusModel(
                    processStatus.Id,
                    processStatus.Label,
                    processStatus.Order,
                    processStatus.IsActive
                );
                repository.AddProcessStatus(newProcessStatus);
                return Results.Created($"/processstatus/{processStatus.Id}", processStatus);
            });
            app.MapGet("get", (ProcessStatusRepository repository) =>
            {
                var processStatus = repository.GetProcessStatus();
                return Results.Ok(processStatus);
            });
        }
    }
}