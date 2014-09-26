using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Lantip.Connection
{
	public class DatabaseConnection
	{
        private static String connectionString = System.IO.File.ReadAllLines(Application.StartupPath + @"\DBPath.txt")[0];
		private SQLiteConnection conn;

		public DatabaseConnection()
		{
            try
            {
                conn = new SQLiteConnection(connectionString);
            }
            catch (Exception)
            {
                throw;
            }
		}

		public SQLiteConnection GetConnection()
		{
			return conn;
		}
	}
}