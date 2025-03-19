using Dapper;
using Device.Models;
using RegistroDePontoDbContext.Data;

namespace Device.Infrastructure
{
    public class DeviceRepository
    {
        public int AddDevice(DeviceModel device, int userId, int companyModelId, int workGroupModelId)
        {
            using var conn = new RegistroDePontoContext();
            string query = @"
                INSERT INTO ""Device""
                (""Id"", ""CompanyId"", ""WorkGroupId"", ""Code"", ""IsActive"", ""CreatedById"", ""CreatedDate"", ""UpdatedById"", ""UpdatedDate"")
                VALUES (@Id, @CompanyId, @WorkGroupId, @Code, @IsActive, @CreatedById, @CreatedDate, @UpdatedById, @UpdatedDate)";

            var result = conn.Execute(query, new
            {
                device.Id,
                CompanyId = companyModelId,
                WorkGroupId = workGroupModelId,
                device.Code,
                device.IsActive,
                CreatedBy = userId,
                UpdatedBy = userId,
                device.CreatedDate,
                device.UpdatedDate
            });
            return result;
        }
        public List<DeviceModel> GetDevices()
        {
            using var conn = new RegistroDePontoContext();
            string query = @"
                SELECT * FROM ""Device""";

            var result = conn.Connection.Query<DeviceModel>(query).ToList();
            return result;
        }
    }
}