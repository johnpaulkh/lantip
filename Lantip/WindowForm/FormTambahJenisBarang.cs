using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Lantip.Model;
using Lantip.Service;

namespace Lantip.WindowForm
{
	public partial class FormTambahJenisBarang : Form
	{

		private static FormTambahJenisBarang thisForm = null;

		public FormTambahJenisBarang()
		{
			InitializeComponent();
		}

		private void FormTambahJenisBarang_FormClosed(object sender, FormClosedEventArgs e)
		{
			thisForm = null;
		}

		public static void ShowForm(Form parentForm)
		{
			if (thisForm != null)
			{
				thisForm.BringToFront();
			}
			else
			{
				thisForm = new FormTambahJenisBarang();
				thisForm.MdiParent = parentForm;
				thisForm.Show();
			}
		}

		private void btnBatal_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void btnOK_Click(object sender, EventArgs e)
		{
			int result = AddJenisBarang();
			string message = "";
			if (result == 1)
			{
				message = "Jenis barang berhasil ditambahkan";
			}
			else
			{
				message = "Terjadi kegagagalan dalam penambahan";
			}
			MessageBox.Show(message);
			this.Close();
		}

		private int AddJenisBarang()
		{
			JenisBarang jenisBarang = new JenisBarang();
			jenisBarang.namaJenisBarang = txtNamaJenisBarang.Text;

			JenisBarangService jenisBarangService = new JenisBarangService();
			return jenisBarangService.InsertJenisBarang(jenisBarang);
		}
	}
}
