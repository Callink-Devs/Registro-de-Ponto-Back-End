using Parameter.Infrastructure;
using Parameter.Models;

namespace ParameterRoute.Routes
{
    public static class ParameterRoutes
    {
        public static void ParameterRoute(this WebApplication app)
        {
            app.MapPost("post", (ParameterModel parameter, ParameterRepository repository) =>
            {
                var newParameter = new ParameterModel(
                    parameter.Id,
                    parameter.Name,
                    parameter.Description,
                    parameter.Value,
                    parameter.IsSystemParameter,
                    parameter.IsActive,
                    parameter.CreatedDate,
                    parameter.UpdatedDate,
                    parameter.CreatedBy,
                    parameter.UpdatedBy
                );
                repository.AddParameter(newParameter);
                return Results.Created($"/parameter/{parameter.Id}", parameter);
            });
            app.MapGet("get", (ParameterRepository repository) =>
            {
                var parameters = repository.GetParameters();
                return Results.Ok(parameters);
            });
        }
    }
}