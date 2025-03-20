using WorkGoup.Models;
using RegistroDePontoDbContext.Data;

namespace WorkGroup.Infrastructure
{
    public class WorkGroupRepository
    {

        public int AddWorkGroup(WorkGroupModel WorkGroup)
        {
            using var conn = new RegistroDePontoContext();
            string query = @"
                INSERT INTO ""WorkGroup""
                (""Id"", ""Name"", ""Code"", ""Priority"", ""IsActive"",
                 ""CreatedBy"", ""CreatedDate"", ""UpdatedBy"", ""UpdatedDate"")";

            var result = conn.Execute(query, new
            {
                WorkGroup.Id,
                WorkGroup.Name,
                WorkGroup.Code,
                WorkGroup.Priority,
                WorkGroup.IsActive,
                WorkGroup.CreatedBy,
                WorkGroup.CreatedDate,
                WorkGroup.UpdatedBy,
                WorkGroup.UpdatedDate
            });
            return result;
        }
    }
}

