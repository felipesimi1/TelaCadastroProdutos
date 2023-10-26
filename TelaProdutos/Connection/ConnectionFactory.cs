using Microsoft.Data.SqlClient;
using System.Configuration;

namespace TelaProdutos.Connection
{
    public class ConnectionFactory
    {
        public SqlConnection GetConnection()
        {
            string conexao = ConfigurationManager.ConnectionStrings["OuroBase"].ConnectionString;
            return new SqlConnection(conexao);
        }
    }
}
