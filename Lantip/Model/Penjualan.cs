using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lantip.Model
{
	public class Penjualan
	{
		[DisplayName("ID Penjualan")]
		public Int64 idPenjualan { get; set; }

		[DisplayName("Tanggal")]
		public DateTime tanggal { get; set; }

		[DisplayName("Shift")]
		public int shift { get; set; }

		[DisplayName("User")]
		public User user { get; set; }

		[DisplayName("Detail Penjualan")]
		public List<PenjualanDetail> penjualanDetails { get; set; }
	}
}
