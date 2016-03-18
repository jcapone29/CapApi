using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace DataAccess.Repositories
{
    public class DataConnectionProvider
    {
        public static IDbConnection GetProdConnection()
        {
            return new SqlConnection(ConfigurationManager.ConnectionStrings["conn"].ToString());
        }

    }
}
