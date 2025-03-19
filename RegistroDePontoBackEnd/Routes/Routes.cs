namespace Routes.Routes
{
    public static class RouteExtensions
    {
        public static void MapAllRoutes(this IEndpointRouteBuilder endpoints)
        {
            endpoints.MapUserRoutes();
            endpoints.MapDeviceRoutes();
            endpoints.MapPushNotificationRoutes();
        }
    }
}