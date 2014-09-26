using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using Lantip.Model;
using System.Data.SQLite;
using Lantip.Connection;
using System.Data.SqlClient;
using Dapper;

namespace Lantip.Service
{
	class JenisBarangService
	{

		private SQLiteConnection sqlConnection = new DatabaseConnection().GetConnection();



		public List<JenisBarang> GetAllJenisBarang()
		{
			if (sqlConnection.State == System.Data.ConnectionState.Closed) sqlConnection.Open();
			var query = @"select j.idJenisBarang, j.namaJenisBarang from JenisBarang j Order by j.idJenisBarang";
			var items = sqlConnection.Query<JenisBarang>(query);
			sqlConnection.Close();
			return items.ToList();
		}

		public int InsertJenisBarang(JenisBarang item)
		{
			if (sqlConnection.State == System.Data.ConnectionState.Closed) sqlConnection.Open();

			var query = @"insert into JenisBarang (namaJenisBarang) 
				values (@namaJenisBarang)";
			sqlConnection.Execute(query, new { item.namaJenisBarang });

			sqlConnection.Close();
			return 1;
		}
	}
}
