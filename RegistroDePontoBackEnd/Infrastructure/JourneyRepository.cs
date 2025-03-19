using Dapper;
using Journey.Models;
using RegistroDePontoDbContext.Data;

namespace Journey.Infrastructure
{
    public class JourneyRepository
    {
        public int AddJourney(JourneyModel journey, int userId)
        {
            using var conn = new RegistroDePontoContext();
            string query = @"
                INSERT INTO ""Journey""
                (""Id"", ""StartIn"", ""IsActive"",""CreatedById"", ""CreatedDate"", ""UpdatedById"", ""UpdatedDate"")
                VALUES (@Id, @StartIn, @IsActive, @CreatedBy, @CreatedDate, @UpdatedBy, @UpdatedDate)";

            var result = conn.Execute(query, new
            {
                journey.Id,
                journey.StartIn,
                journey.IsActive,
                CreatedBy = userId,
                UpdatedBy = userId,
                journey.CreatedDate,
                journey.UpdatedDate
            });
            return result;
        }
        public List<JourneyModel> GetJourneys()
        {
            using var conn = new RegistroDePontoContext();
            string query = @"
                SELECT * FROM ""Journey""";

            var result = conn.Connection.Query<JourneyModel>(query).ToList();
            return result;
        }
    }
}