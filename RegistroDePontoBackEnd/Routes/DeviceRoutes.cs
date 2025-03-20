using Device.Infrastructure;
using Device.Models;

namespace Routes.Routes
{
    public static class DeviceRoutes
    {
        public static void MapDeviceRoutes(this IEndpointRouteBuilder endpoints)
        {
            endpoints.MapPost("/device/post", (DeviceModel device, DeviceRepository repository) =>
            {
                var newDevice = new DeviceModel(
                    device.Id,
                    device.CompanyId,
                    device.WorkGroupId,
                    device.CreatedBy,
                    device.UpdatedBy,
                    device.CreatedDate,
                    device.UpdatedDate,
                    device.Code,
                    device.IsActive
                );
                repository.AddDevice(newDevice, device.CompanyId, device.WorkGroupId, device.CreatedBy);
                return Results.Created($"/device/{device.Id}", device);
            });

            endpoints.MapGet("/device/get", (DeviceRepository repository) =>
            {
                var devices = repository.GetDevices();
                return Results.Ok(devices);
            });
        }
    }
}