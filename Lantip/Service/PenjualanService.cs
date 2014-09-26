using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using Dapper;
using Lantip.Connection;
using Lantip.Model;

namespace Lantip.Service
{
	class PenjualanService
	{
		/// <summary>
		/// Conection used by this service
		/// </summary>
		public SQLiteConnection sqlConnection = new DatabaseConnection().GetConnection();

		/// <summary>
		/// Number of penjualan displayed per query
		/// </summary>
		public static double? penjualanPerPage = 50;


		/// <summary>
		/// Insert penjualan to database
		/// </summary>
		/// <param name="item">penjualan to be inserted</param>
		/// <returns>result code</returns>
		public int InsertPenjualan(Penjualan item)
		{
			if (sqlConnection.State == System.Data.ConnectionState.Closed) sqlConnection.Open();

			//change item.tanggal to proper format yyyy-MM-dd HH:mm:ss
			String tanggal = item.tanggal.ToString("yyyy-MM-dd HH:mm:ss");

			//query to penjualan
			var query = @"insert into Penjualan (tanggal, shift, username) 
				values (@tanggal, @shift, @username)";
			sqlConnection.Execute(query, new
			{
				tanggal, item.shift, item.user.username
			});

			//query to penjualanDetail and stok
			foreach (PenjualanDetail pd in item.penjualanDetails)
			{
				query = @"insert into PenjualanDetail (idPenjualan, idBarang, jumlah, hargaModal, hargaJual) 
				values ((select idPenjualan from penjualan order by idPenjualan desc limit 1)
						, @idBarang, @jumlah, @hargaModal, @hargaJual)";
				sqlConnection.Execute(query, new
				{
					pd.barang.idBarang,
					pd.jumlah,
					pd.hargaModal,
					pd.hargaJual
				});

				query = @"update barang set stok = round((stok - " + pd.jumlah + "), 2) where idBarang = " + pd.barang.idBarang;
				sqlConnection.Execute(query);
			}

			sqlConnection.Close();
			return 1;
		}

		/// <summary>
		/// Get count of all penjualan from database
		/// </summary>
		/// <returns>count of all penjualan</returns>
		public int GetCountPenjualan(DateTime fromDate, DateTime toDate)
		{
			if (sqlConnection.State == System.Data.ConnectionState.Closed) sqlConnection.Open();

			//query to get count of transaction
			var query = @"select count(*) from penjualan 
							where strftime('%Y-%m-%d', tanggal) between 
							'" + fromDate.ToString("yyyy-MM-dd") + "' and '" + toDate.ToString("yyyy-MM-dd") + "'";
			var sqlCommand = new SQLiteCommand(query, sqlConnection);
			Int64 count = (Int64)sqlCommand.ExecuteScalar();

			sqlConnection.Close();

			return (int) count;
		}

		/// <summary>
		/// Get list of penjualan
		/// </summary>
		/// <param name="page">page of the data</param>
		/// <returns>list of penjualan</returns>
		public List<Penjualan> GetAllPenjualan(int page)
		{
			if (sqlConnection.State == System.Data.ConnectionState.Closed) sqlConnection.Open();

			int start = (page - 1) * ((int) penjualanPerPage);

			//query to get all penjualan
			var query = @"select 
							p.idPenjualan, tanggal, shift, p.username,
							nama, tipeUser
							
							from penjualan p left join user u on p.username = u.username

							order by p.idPenjualan desc
							limit " + start + "," + penjualanPerPage;
			var items = sqlConnection.Query<Penjualan, User, Penjualan>(query,
				(penjualan, user) =>
				{
					penjualan.user = user;
					penjualan.penjualanDetails = null;
					return penjualan;
				}
				, splitOn: "username");

			sqlConnection.Close();
			return items.ToList();
		}

		/// <summary>
		/// Get list of penjualan
		/// </summary>
		/// <param name="page">page of the data</param>
		/// <returns>list of penjualan</returns>
		public List<Penjualan> GetAllPenjualan(int page, DateTime fromDate, DateTime toDate)
		{
			if (sqlConnection.State == System.Data.ConnectionState.Closed) sqlConnection.Open();

			int start = (page - 1) * ((int)penjualanPerPage);

			//query to get all penjualan
			var query = @"select 
							p.idPenjualan, tanggal, shift, p.username, 
							nama, tipeUser 
							from penjualan p left join user u on p.username = u.username 
							where strftime('%Y-%m-%d', tanggal) between 
							'" + fromDate.ToString("yyyy-MM-dd") + "' and '" + toDate.ToString("yyyy-MM-dd") + "' " +
							" order by p.idPenjualan desc limit " + start + "," + penjualanPerPage;
			var items = sqlConnection.Query<Penjualan, User, Penjualan>(query,
				(penjualan, user) =>
				{
					penjualan.user = user;
					penjualan.penjualanDetails = null;
					return penjualan;
				}
				, splitOn: "username");

			sqlConnection.Close();
			return items.ToList();
		}

		public List<PenjualanDetail> GetPenjualanDetail(Penjualan penjualan)
		{
			if (sqlConnection.State == System.Data.ConnectionState.Closed) sqlConnection.Open();

			string idPenjualan = penjualan.idPenjualan.ToString();

			var query = @"select 
							idPenjualan, jumlah, pd.hargaModal, pd.hargaJual, 
							pd.idBarang, kodeBarang, namaBarang, stok, b.hargaModal, b.hargaJual, 
							b.idJenisBarang, namaJenisBarang

							from penjualanDetail pd join barang b on pd.idBarang = b.idBarang
							join jenisBarang jb on b.idJenisBarang = jb.idJenisBarang

							where idPenjualan = " + idPenjualan;
			var items = sqlConnection.Query<PenjualanDetail, Barang, JenisBarang, PenjualanDetail>(query,
				(penjualanDetail, barang, jenisBarang) =>
				{
					penjualanDetail.barang = barang;
					barang.jenisBarang = jenisBarang;
					return penjualanDetail;
				}
				, splitOn: "idBarang, idJenisBarang"); 

			sqlConnection.Close();
			return items.ToList();
		}
	}
}
