using ConnectionWhitelist.Infrastructure;
using ConnectionWhitelist.Models;

namespace ConnectionWhitelistRoutes.Routes
{
    public static class ConnectionWhitelistRoute
    {
        public static void ConnectionWhitelistRoutes(this WebApplication app)
        {
            app.MapPost("post", (ConnectionWhitelistModel connectionWhitelist, ConnectionWhitelistRepository repository) =>
            {
                var newConnectionWhitelist = new ConnectionWhitelistModel(
                    connectionWhitelist.ConnectionAttributeId,
                    connectionWhitelist.Attribute,
                    connectionWhitelist.AttributeLength,
                    connectionWhitelist.Description,
                    connectionWhitelist.IsToDisregardInHitory,
                    connectionWhitelist.IsActive,
                    connectionWhitelist.CreatedBy,
                    connectionWhitelist.CreatedDate,
                    connectionWhitelist.UpdatedDate,
                    connectionWhitelist.UpdatedBy
                );
                repository.AddConnectionWhitelist(newConnectionWhitelist);
                return Results.Created($"/connectionwhitelist/{connectionWhitelist.Id}", connectionWhitelist);
            });
            app.MapGet("get", (ConnectionWhitelistRepository repository) =>
            {
                var connectionWhitelists = repository.GetConnectionWhitelists();
                return Results.Ok(connectionWhitelists);
            });
        }
    }
}