using Microsoft.Data.SqlClient;

namespace FirstMvcApp.Models
{
    public class SqlHelper
    {
        public static SqlConnection CreateConnection()
        {
            var ConnString = @"server=200411LTP2721\SQLEXPRESS; database = testdb; integrated security=true; Encrypt=false;";
            SqlConnection sqlcn = new SqlConnection (ConnString);
            return sqlcn;

        }

    }
}
