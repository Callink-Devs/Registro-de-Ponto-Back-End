using User.Infrastructure;
using User.Models;

namespace RegistrodePonto.Routes;

public static class RegistrodePontoRoute {
    public static void RegisterRoutes(this WebApplication app) {
        app.MapPost("post", (UserModel user, UserRepository repository) => {
            var newUser = new UserModel(
                user.Name,
                user.Email,
                user.Password,
                user.MobilePhone,
                user.ExternalId,
                user.CreationDate,
                user.LastLogin,
                user.IsActive
            );
            repository.AddUser(newUser);
            return Results.Created($"/user/{user.Id}", user);
        });
        app.MapGet("get", (UserRepository repository) => {
            var users = repository.GetUsers();
            return Results.Ok(users);
        });
    }
}