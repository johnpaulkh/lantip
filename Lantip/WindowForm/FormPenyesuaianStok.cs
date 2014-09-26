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
using Lantip.Util;

namespace Lantip.WindowForm
{
	public partial class FormPenyesuaianStok : Form
	{
		private static int VALIDATE_OK = 0;
		private static int VALIDATE_EMPTY_FORM = 11;
		//content
		private Barang oriItem;	//original
		private Barang item;
		//service
		private BarangService service;

		public FormPenyesuaianStok(Barang item)
		{
			InitializeComponent();

			this.item = item;
			this.oriItem = item;
			this.service = new BarangService();
		}

		private void FormPenyesuaianStok_Load(object sender, EventArgs e)
		{
			txtNamaBarang.Text = item.namaBarang;
			txtKodeBarang.Text = item.kodeBarang;
			txtJenisBarang.Text = item.jenisBarang.namaJenisBarang;
			txtStok.Text = item.stok.ToString();
			txtHargaModal.Text = item.hargaModal.ToString();
			txtHargaJual.Text = item.hargaJual.ToString();
		}

		private void btnBatal_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void btnOk_Click(object sender, EventArgs e)
		{
			//validation
			int validationResult = DoValidation();
			if (validationResult != VALIDATE_OK)
			{
				if (validationResult == VALIDATE_EMPTY_FORM)
				{
					MessageBox.Show("Isi semua form");
				}
				return;
			}

			int result = PenyesuaianStok();
			String message = "";
			if (result == 1)
			{
				message = "Stok barang berhasil disesuaikan";
			}
			else
			{
				message = "Terjadi kegagalan dalam menyesuaikan stok barang";
			}
			MessageBox.Show(message);
			this.Close();
		}

		private int PenyesuaianStok()
		{
			Barang barang = new Barang();
			barang.idBarang = item.idBarang;
			barang.namaBarang = item.namaBarang;
			barang.kodeBarang = item.kodeBarang;
			barang.jenisBarang = item.jenisBarang;
			barang.stok = Math.Round(double.Parse(txtStokBaru.Text), 2);
			//if hargaModal is 0 use old hargaModal
			barang.hargaModal = (double.Parse(txtHargaModalBaru.Text) != 0) ? Math.Round(double.Parse(txtHargaModalBaru.Text), 2) : item.hargaModal;
			barang.hargaJual = item.hargaJual;

			return service.PenyesuaianStok(this.oriItem, barang);
		}

		private void txtStokBaru_TextChanged(object sender, EventArgs e)
		{
			EditHargaModal();
		}

		//edit hargaModal based on stok and current hargaModal
		private void EditHargaModal()
		{
			double stok = Math.Round(double.Parse(txtStok.Text), 2);
			double stokBaru = string.IsNullOrEmpty(txtStokBaru.Text) ? 0 : Math.Round(double.Parse(txtStokBaru.Text), 2);
			double hargaModal = Math.Round(double.Parse(txtHargaModal.Text), 2);
			double hargaModalBaru = Math.Round(double.Parse(txtHargaModalBaru.Text), 2);

			if (stokBaru != 0) { hargaModalBaru = Math.Round(((hargaModal * stok) / stokBaru), 2); }

			txtHargaModalBaru.Text = hargaModalBaru.ToString();
		}

		//validation function
		private int DoValidation()
		{
			if (txtNamaBarang.Text.Equals("")) return VALIDATE_EMPTY_FORM;
			if (txtStok.Text.Equals("")) return VALIDATE_EMPTY_FORM;
			if (txtHargaModal.Text.Equals("")) return VALIDATE_EMPTY_FORM;
			if (txtHargaJual.Text.Equals("")) return VALIDATE_EMPTY_FORM;

			return VALIDATE_OK;
		}

		private void txtStokBaru_KeyPress(object sender, KeyPressEventArgs e)
		{
			NonNumericPreventor.PreventNonNumberKey(sender, e);
		}
	}
}
