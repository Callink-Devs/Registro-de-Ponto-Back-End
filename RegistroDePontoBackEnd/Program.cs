using ConnectionAttribute.Infrastructure;
using ConnectionWhitelist.Infrastructure;
using Device.Infrastructure;
using Parameter.Infrastructure;
using ProcessStatus.Infrastructure;
using PushNotification.Infrastructure;
using RegistroDePontoDbContext.Data;
using Routes.Routes;
using User.Infrastructure;
using WorkHour.Infrastructure;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers().AddJsonOptions(options =>
{
    options.JsonSerializerOptions.Converters.Add(new DateTimeConverter());
});

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<RegistroDePontoContext>();
builder.Services.AddScoped<PushNotificationRepository>();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseRouting();

// app.MapUserRoutes();
// app.MapDeviceRoutes();
app.MapPushNotificationRoutes();
// app.MapParameterRoutes();
// app.MapConnectionAttributeRoutes();
// app.MapConnectionWhitelistRoutes();
// app.MapWorkHourRoutes();
// app.MapProcessStatusRoutes();

app.Run();

