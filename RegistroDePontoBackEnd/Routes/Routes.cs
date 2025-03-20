namespace Routes.Routes
{
    public static class RouteExtensions
    {
        public static void MapAllRoutes(this IEndpointRouteBuilder endpoints)
        {
            endpoints.UserRoutes();
            endpoints.MapDeviceRoutes();
            endpoints.MapPushNotificationRoutes();

        }
    }
}