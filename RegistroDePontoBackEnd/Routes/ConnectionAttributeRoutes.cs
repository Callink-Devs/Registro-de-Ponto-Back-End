using ConnectionAttribute.Infrastructure;
using ConnectionAttribute.Models;

namespace ConnectionAttributeRoutes.Routes
{
    public static class ConnectionAttributeRoute
    {
        public static void ConnectionAttributeRoutes(this WebApplication app)
        {
            app.MapPost("post", (ConnectionAttributeModel connectionAttribute, ConnectionAttributeRepository repository) =>
            {
                var newConnectionAttribute = new ConnectionAttributeModel(
                    connectionAttribute.Label,
                    connectionAttribute.Order,
                    connectionAttribute.IsActive
                );
                repository.AddConnectionAttribute(newConnectionAttribute);
                return Results.Created($"/connectionattribute/{connectionAttribute.Id}", connectionAttribute);
            });
        }
    }
}