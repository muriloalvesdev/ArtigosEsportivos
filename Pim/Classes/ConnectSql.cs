using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pim3Semestre_Original_.Classes
{
    public class ConnectSql
    {
        public MySqlConnection conn = null;
        public String connectionString = @"server = localhost; user id = root; password=admin; port = 3306; database = artigosesportivos; SslMode = none";
        public MySqlConnection getConnection()
        {
            MySqlConnection conn = new MySqlConnection(connectionString);
            return conn;
        }
    }
}