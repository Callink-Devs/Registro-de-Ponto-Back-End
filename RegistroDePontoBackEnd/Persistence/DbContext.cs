using Npgsql;

namespace RegistroDePontoDbContext.Data;

public class RegistroDePontoContext : IDisposable
{
    public NpgsqlConnection Connection { get; set; }

    public RegistroDePontoContext()
    {
        Connection = new NpgsqlConnection("Host=localhost;Port=5432;Username=postgres;Password=;Database=RegistroDePonto");
        Connection.Open();
    }


    public void Dispose()
    {
        Connection.Dispose();
    }

    internal int Execute(string query, object value)
    {
        throw new NotImplementedException();
    }

}