using User.Infrastructure;
using User.Models;

namespace Routes.Routes
{
    public static class UserRoutes
    {
        public static void MapUserRoutes(this IEndpointRouteBuilder endpoints)
        {
            endpoints.MapPost("/user/post", (UserModel user, UserRepository repository) =>
            {
                var newUser = new UserModel(
                    user.Id,
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

            endpoints.MapGet("/user/get", (UserRepository repository) =>
            {
                var users = repository.GetUsers();
                return Results.Ok(users);
            });
        }
    }
}