using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lantip.Model
{
	public class Barang
	{
		[DisplayName("ID Barang")]
		public Int64 idBarang { get; set; }

		[DisplayName("Jenis Barang")]
		public JenisBarang jenisBarang { get; set; }

		[DisplayName("Kode Barang")]
		public string kodeBarang { get; set; }

		[DisplayName("Nama Barang")]
		public string namaBarang { get; set; }

		[DisplayName("Stok")]
		public double stok { get; set; }

		[DisplayName("Harga Modal")]
		public double hargaModal { get; set; }

		[DisplayName("Harga Jual")]
		public double hargaJual { get; set; }

		public Barang()
		{

		}

		public override string ToString()
		{
			return namaBarang;
		}
	}
}
