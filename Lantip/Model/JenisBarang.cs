using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lantip.Model
{
	public class JenisBarang
	{
		[DisplayName("ID Jenis Barang")]
		public Int64 idJenisBarang { get; set; }

		[DisplayName("Nama Jenis Barang")]
		public string namaJenisBarang { get; set; }

		public JenisBarang()
		{

		}

		public override string ToString()
		{
			return namaJenisBarang;
		}
	}
}
