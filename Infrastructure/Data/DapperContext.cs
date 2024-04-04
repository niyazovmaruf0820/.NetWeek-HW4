using System.Data;
using Microsoft.Extensions.Configuration;
using Npgsql;

namespace Infrastructure.Data;

public class DapperContext(IConfiguration configuration)
{
    public IDbConnection Connection()
    {
        return new NpgsqlConnection(configuration.GetConnectionString("Default"));
    }
}
