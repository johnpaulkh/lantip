using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lantip.Model
{
	public class PenjualanDetail
	{
		[DisplayName("ID Penjualan")]
		public Int64 idPenjualan { get; set; }

		[DisplayName("Barang")]
		public Barang barang { get; set; }

		[DisplayName("Jumlah")]
		public double jumlah { get; set; }

		[DisplayName("Harga Modal")]
		public double hargaModal { get; set; }

		[DisplayName("Harga Jual")]
		public double hargaJual { get; set; }
	}
}
