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
	public partial class FormPembelian : Form
	{
		private static int VALIDATE_OK = 0;
		private static int VALIDATE_EMPTY_FORM = 11;
		private static int VALIDATE_ZERO = 12;
		//content
		private Barang oriItem;
		private Barang item;
		//service
		private BarangService service;

		public FormPembelian(Barang item)
		{
			InitializeComponent();

			this.item = item;
			this.oriItem = item;
			service = new BarangService();
		}

		private void FormPembelian_Load(object sender, EventArgs e)
		{
			txtNamaBarang.Text = item.namaBarang;
			txtJenisBarang.Text = item.jenisBarang.namaJenisBarang;
			txtKodeBarang.Text = item.kodeBarang;
			txtStok.Text = item.stok.ToString();
			txtHargaModal.Text = item.hargaModal.ToString();
			txtStokBaru.Text = item.stok.ToString();
			txtHargaModalBaru.Text = item.hargaModal.ToString();
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

				if (validationResult == VALIDATE_ZERO)
				{
					MessageBox.Show("Tidak boleh ada isian nol (0)");
				}
				return;
			}


			int result = PembelianBarang();
			String message = "";
			if (result == 1)
			{
				message = "Pembelian barang berhasil ditambahkan";
			}
			else
			{
				message = "Terjadi kegagalan dalam memasukkan pembelian barang";
			}
			MessageBox.Show(message);
			this.Close();
		}

		//validation function
		private int DoValidation()
		{
			//empty validation
			if (txtJumlahPembelian.Text.Equals("")) return VALIDATE_EMPTY_FORM;
			if (txtHargaPembelian.Text.Equals("")) return VALIDATE_EMPTY_FORM;
			if (txtStokBaru.Text.Equals("")) return VALIDATE_EMPTY_FORM;
			if (txtHargaModalBaru.Text.Equals("")) return VALIDATE_EMPTY_FORM;

			//zero value validation
			if (txtJumlahPembelian.Text.Trim().Equals("0")) return VALIDATE_ZERO;
			if (txtHargaPembelian.Text.Trim().Equals("0")) return VALIDATE_ZERO;

			return VALIDATE_OK;
		}

		private int PembelianBarang()
		{
			Barang barang = new Barang();
			barang.idBarang = item.idBarang;
			barang.jenisBarang = item.jenisBarang;
			barang.kodeBarang = item.kodeBarang;
			barang.namaBarang = item.namaBarang;
			barang.stok = Math.Round(double.Parse(txtStokBaru.Text), 2);
			barang.hargaModal = Math.Round(double.Parse(txtHargaModalBaru.Text), 2);
			barang.hargaJual = item.hargaJual;

			return service.Pembelian(this.oriItem, barang);
		}

		private void txtJumlahPembelian_TextChanged(object sender, EventArgs e)
		{
			//if txtJumlahPembelian of txtHargaPembelian is empty don't change stok and hargaModal
			if (string.IsNullOrEmpty(txtHargaPembelian.Text) || string.IsNullOrEmpty(txtJumlahPembelian.Text)) return;
			ChangeStokAndHarga();
		}

		private void txtHargaPembelian_TextChanged(object sender, EventArgs e)
		{
			//if txtJumlahPembelian of txtHargaPembelian is empty don't change stok and hargaModal
			if (string.IsNullOrEmpty(txtHargaPembelian.Text) || string.IsNullOrEmpty(txtJumlahPembelian.Text)) return;
			ChangeStokAndHarga();
		}

		private void txtJumlahHargaPembelian_KeyPressed(object sender, KeyPressEventArgs e)
		{
			NonNumericPreventor.PreventNonNumberKey(sender, e);
		}

		//changin stokBaru and HargaModalBaru based on stok, hargaModal, jumlahPembelian, and hargaPembelian
		private void ChangeStokAndHarga()
		{
			double jumlahPembelian = Math.Round(double.Parse(txtJumlahPembelian.Text), 2);
			double hargaPembelian = Math.Round(double.Parse(txtHargaPembelian.Text), 2);

			double stok = Math.Round(double.Parse(txtStok.Text), 2);
			double hargaModal = Math.Round(double.Parse(txtHargaModal.Text), 2);
			double stokBaru = (string.IsNullOrEmpty(txtStokBaru.Text)) ? 0 : Math.Round(double.Parse(txtStokBaru.Text), 2);
			double hargaModalBaru = (string.IsNullOrEmpty(txtHargaModalBaru.Text)) ? 0 : Math.Round(double.Parse(txtHargaModalBaru.Text), 2);

			stokBaru = stok + jumlahPembelian;
			hargaModalBaru = (((stok * hargaModal) + (jumlahPembelian * hargaPembelian)) / stokBaru);
			hargaModalBaru = Math.Round(hargaModalBaru, 2);

			txtStokBaru.Text = stokBaru.ToString();
			txtHargaModalBaru.Text = hargaModalBaru.ToString();
		}

	}
}
