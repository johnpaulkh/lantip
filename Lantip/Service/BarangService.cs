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
using System.Windows.Forms;

namespace Lantip.Service
{
	class BarangService
	{

		/// <summary>
		/// Conection used by this service
		/// </summary>
		SQLiteConnection sqlConnection = new DatabaseConnection().GetConnection();

		/// <summary>
		///	Get all barang from database
		/// </summary>
		/// <returns>List of barang</returns>
		public List<Barang> GetAllBarang()
		{
			if (sqlConnection.State == System.Data.ConnectionState.Closed) sqlConnection.Open();

			//query
			var query = @"select b.idBarang, kodeBarang, namaBarang, stok, hargaModal, hargaJual, j.idJenisBarang, j.namaJenisBarang from Barang b left join JenisBarang j on b.idJenisBarang = j.idJenisBarang Order by b.idBarang";
			var items = sqlConnection.Query<Barang, JenisBarang, Barang>(query,
				(barang, jenisBarang) => { barang.jenisBarang = jenisBarang; return barang; }, splitOn: "idJenisBarang");
			sqlConnection.Close();
			return items.ToList();
		}

		/// <summary>
		/// Insert barang to database
		/// </summary>
		/// <param name="item">Barang to be inserted</param>
		/// <returns>result code</returns>
		public int InsertBarang(Barang item)
		{
			if (sqlConnection.State == System.Data.ConnectionState.Closed) sqlConnection.Open();

			//query
			var query = @"insert into Barang (idJenisBarang, kodeBarang, namaBarang, stok, hargaModal, hargaJual) 
				values (@idJenisBarang, @kodeBarang, @namaBarang, @stok, @hargaModal, @hargaJual)";
			sqlConnection.Execute(query, new
			{
				item.jenisBarang.idJenisBarang,
				item.kodeBarang,
				item.namaBarang,
				item.stok,
				item.hargaModal,
				item.hargaJual
			});

			sqlConnection.Close();
			return 1;
		}

		/// <summary>
		/// Insert multiple barang to database
		/// </summary>
		/// <param name="items">Array of barang to be inserted</param>
		/// <returns>result code</returns>
		public int InsertBarang(Barang[] items)
		{
			foreach (Barang item in items)
			{
				InsertBarang(item);
			}
			return 1;
		}

		/// <summary>
		/// Update barang to database with default JenisHistoryBarang (Edit Manual)
		/// </summary>
		/// <param name="oriItem">Barang in original states and attributes</param>
		/// <param name="item">Barang in original states and attributes</param>
		/// <returns></returns>
		public int EditBarang(Barang oriItem, Barang item) {
			return EditBarang(oriItem, item, JenisHistoryBarang.editManual);
		}

		/// <summary>
		/// Update barang to database
		/// </summary>
		/// <param name="oriItem">Barang in original states and attributes</param>
		/// <param name="item">Barang in original states and attributes</param>
		/// <returns>result code</returns>
		public int EditBarang(Barang oriItem, Barang item, JenisHistoryBarang jenisHistoryBarang)
		{
			if (sqlConnection.State == System.Data.ConnectionState.Closed) sqlConnection.Open();

			//query
			var query = @"update Barang set 
				namaBarang = @namaBarang,
				idJenisBarang = @idJenisBarang,
				kodeBarang = @kodeBarang,
				stok = @stok,
				hargaModal = @hargaModal,
				hargaJual = @hargaJual
				where idBarang = @idBarang";
			sqlConnection.Execute(query, new
			{
				item.namaBarang,
				item.jenisBarang.idJenisBarang,
				item.kodeBarang,
				item.stok,
				item.hargaModal,
				item.hargaJual,
				item.idBarang
			});

			//add Barang and original Barang to HistoryBarang
			AddBarangToHistory(oriItem, item, jenisHistoryBarang);

			sqlConnection.Close();
			return 1;
		}

		/// <summary>
		/// Do penyesuaian based on stok and harga
		/// </summary>
		/// <param name="oriItem">Barang in original states and attributes</param>
		/// <param name="item">Barang to be updated</param>
		/// <returns></returns>
		public int PenyesuaianStok(Barang oriItem, Barang item)
		{
			return EditBarang(oriItem, item, JenisHistoryBarang.penyesuaianStok);
		}

		/// <summary>
		/// Do Pembelian
		/// </summary>
		/// <param name="oriItem">Barang in original states and attributes</param>
		/// <param name="item">Barang to be edited</param>
		/// <returns></returns>
		public int Pembelian(Barang oriItem, Barang item)
		{
			return EditBarang(oriItem, item, JenisHistoryBarang.pembelian);
		}

		/// <summary>
		/// Downgrade barang, will affect two items from the origin and the downgraded one
		/// </summary>
		/// <param name="oriBarangAsal">Source Barang in original state and attributes</param>
		/// <param name="oriDgBarang">Downgraded Barang in original state and attributes</param>
		/// <param name="barangAsal">Source Barang</param>
		/// <param name="dgBarang">Downgraded Barang</param>
		/// <returns></returns>
		public int Downgradebarang(Barang oriBarangAsal, Barang oriDgBarang, Barang barangAsal, Barang dgBarang)
		{
			if (sqlConnection.State == System.Data.ConnectionState.Closed) sqlConnection.Open();

			//query
			var query = @"update Barang set 
				namaBarang = @namaBarang,
				idJenisBarang = @idJenisBarang,
				kodeBarang = @kodeBarang,
				stok = @stok,
				hargaModal = @hargaModal,
				hargaJual = @hargaJual
				where idBarang = @idBarang";
			sqlConnection.Execute(query, new
			{
				barangAsal.namaBarang,
				barangAsal.jenisBarang.idJenisBarang,
				barangAsal.kodeBarang,
				barangAsal.stok,
				barangAsal.hargaModal,
				barangAsal.hargaJual,
				barangAsal.idBarang
			});

			//add barang and original barang to HistoryBarang
			AddBarangToHistory(oriBarangAsal, barangAsal, JenisHistoryBarang.downgradeBarangAsal);

			query = @"update Barang set 
				namaBarang = @namaBarang,
				idJenisBarang = @idJenisBarang,
				kodeBarang = @kodeBarang,
				stok = @stok,
				hargaModal = @hargaModal,
				hargaJual = @hargaJual
				where idBarang = @idBarang";
			sqlConnection.Execute(query, new
			{
				dgBarang.namaBarang,
				dgBarang.jenisBarang.idJenisBarang,
				dgBarang.kodeBarang,
				dgBarang.stok,
				dgBarang.hargaModal,
				dgBarang.hargaJual,
				dgBarang.idBarang
			});

			//add dgBarang and original dgBarang to HistoryBarang
			AddBarangToHistory(oriDgBarang, dgBarang, JenisHistoryBarang.downgradeBarangTujuan);

			sqlConnection.Close();
			return 1;
		}

		/// <summary>
		/// Generate kodeBarang based on idJenisBarang
		/// </summary>
		/// <param name="idJenisBarang">idJenisBarang of a barang</param>
		/// <returns>kodeBarang</returns>
		public string GenerateKodeBarang(Int64 idJenisBarang)
		{
			if (sqlConnection.State == System.Data.ConnectionState.Closed) sqlConnection.Open();

			//query
			var stringIdJB = idJenisBarang.ToString().PadLeft(2, '0');
			var query = @"select substr(kodeBarang,3) from barang where kodeBarang like '" + stringIdJB + "%' order by kodeBarang desc limit 1";
			var sqlCommand = new SQLiteCommand(query, sqlConnection);
			string result = (string)sqlCommand.ExecuteScalar();
			if (result == null) result = "0";
			int item = int.Parse(result);

			string count = (++item).ToString();

			sqlConnection.Close();

			return idJenisBarang.ToString().PadLeft(2, '0') + count.PadLeft(4, '0');
		}

		/// <summary>
		/// Generate kodeBarang based on idJenisBarang with offset
		/// </summary>
		/// <param name="idJenisBarang">idJenisBarang of a barang</param>
		/// <param name="offset">the number of offset to last kodeBarang</param>
		/// <returns>kodeBarang</returns>
		public string GenerateKodeBarang(Int64 idJenisBarang, int offset)
		{
			if (sqlConnection.State == System.Data.ConnectionState.Closed) sqlConnection.Open();

			//query
			var stringIdJB = idJenisBarang.ToString().PadLeft(2, '0');
			var query = @"select substr(kodeBarang,3) from barang where kodeBarang like '" + stringIdJB + "%' order by kodeBarang desc limit 1";
			var sqlCommand = new SQLiteCommand(query, sqlConnection);
			string result = (string)sqlCommand.ExecuteScalar();
			if (result == null) result = "0";
			int item = int.Parse(result);

			string count = (item + 1 + offset).ToString();

			sqlConnection.Close();

			return idJenisBarang.ToString().PadLeft(2, '0') + count.PadLeft(4, '0');
		}

		/// <summary>
		/// Add Barang to table HistoryBarang
		/// </summary>
		/// <param name="original">Original Barang before edited</param>
		/// <param name="edited">Barang after edited</param>
		/// <param name="jenisHistoryBarang">JenisHistoryBarang to be inserted<see cref="JenisHistoryBarang"/></param>
		/// <returns></returns>
		private int AddBarangToHistory(Barang original, Barang edited, JenisHistoryBarang jenisHistoryBarang)
		{
			if (sqlConnection.State == System.Data.ConnectionState.Closed) sqlConnection.Open();

			//query
			var query = @"insert into HistoryBarang
				(idBarang, idJenisHistoryBarang, date,
				idJenisBarangLama, kodeBarangLama, namaBarangLama, stokLama, hargaModalLama, hargaJualLama,
				idJenisBarangBaru, kodeBarangBaru, namaBarangBaru, stokBaru, hargaModalBaru, hargaJualBaru) 
				values (
				@idBarang, @idJenisHistoryBarang, @date,
				@idJenisBarangLama, @kodeBarangLama, @namaBarangLama, @stokLama, @hargaModalLama, @hargaJualLama,
				@idJenisBarangBaru, @kodeBarangBaru, @namaBarangBaru, @stokBaru, @hargaModalBaru, @hargaJualBaru)";
			sqlConnection.Execute(query, new
			{
				original.idBarang,
				jenisHistoryBarang.idJenisHistoryBarang,
				date = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"),

				idJenisBarangLama = original.jenisBarang.idJenisBarang,
				kodeBarangLama = original.kodeBarang,
				namaBarangLama = original.namaBarang,
				stokLama = original.stok,
				hargaModalLama = original.hargaModal,
				hargaJualLama = original.hargaJual,
				
				idJenisBarangBaru = edited.jenisBarang.idJenisBarang,
				kodeBarangBaru = edited.kodeBarang,
				namaBarangBaru = edited.namaBarang,
				stokBaru = edited.stok,
				hargaModalBaru = edited.hargaModal,
				hargaJualBaru = edited.hargaJual
			});

			sqlConnection.Close();

			return 1;
		}
	}
}
