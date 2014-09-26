using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lantip.Model
{
	public class JenisHistoryBarang
	{
		//static
		public static JenisHistoryBarang editManual = new JenisHistoryBarang(1, "Edit Manual");
		public static JenisHistoryBarang penyesuaianStok = new JenisHistoryBarang(2, "Penyesuaian Stok");
		public static JenisHistoryBarang pembelian = new JenisHistoryBarang(3, "Pembelian");
		public static JenisHistoryBarang downgradeBarangAsal = new JenisHistoryBarang(4, "Downgrade Barang Asal");
		public static JenisHistoryBarang downgradeBarangTujuan = new JenisHistoryBarang(5, "Downgrade Barang Tujuan");

		public JenisHistoryBarang(int idJenisHistoryBarang, string namaJenisHistoryBarang)
		{
			this.idJenisHistoryBarang = idJenisHistoryBarang;
			this.namaJenisHistoryBarang = namaJenisHistoryBarang;
		}

		public int idJenisHistoryBarang { get; set; }
		public string namaJenisHistoryBarang { get; set; }
	}
}
