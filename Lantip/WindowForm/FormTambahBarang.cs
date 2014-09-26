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
	public partial class FormTambahBarang : Form
	{
		private static FormTambahBarang thisForm = null;
		private static int VALIDATE_OK = 0;
		private static int VALIDATE_EMPTY_FORM = 11;
		//service
		private BarangService service;

		public FormTambahBarang()
		{
			InitializeComponent();

			this.service = new BarangService();
		}

		private void FormDaftarBarangBaru_FormClosed(object sender, FormClosedEventArgs e)
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
				thisForm = new FormTambahBarang();
				thisForm.MdiParent = parentForm;
				thisForm.Show();
			}
		}

		private void FormTambahBarang_Load(object sender, EventArgs e)
		{
			PopulateCmbJenisBarang();
			GenerateKodeBarang();
		}

		/// <summary>
		/// Populate cmbJenisBarang from database
		/// </summary>
		private void PopulateCmbJenisBarang()
		{
			JenisBarangService jbService = new JenisBarangService();
			List<JenisBarang> jenisBarangs = jbService.GetAllJenisBarang();

			cmbJenisBarang.DataSource = jenisBarangs;
		}

		/// <summary>
		/// generate kodeBarang based on idJenisBarang and number of barang in that jenisBarang
		/// </summary>
		private void GenerateKodeBarang()
		{
			//get from service
			JenisBarang selectedJB = (JenisBarang) cmbJenisBarang.SelectedItem;
			txtKodeBarang.Text = service.GenerateKodeBarang(selectedJB.idJenisBarang);
		}

		private void btnOk_Click(object sender, EventArgs e)
		{
			//validation
			int validationResult = DoValidation();
			if(validationResult != VALIDATE_OK)
			{
				if(validationResult == VALIDATE_EMPTY_FORM)
				{
					MessageBox.Show("Isi semua form");
				}
				return;
			}


			int result = AddBarang();
			String message = "";
			if (result == 1)
			{
				message = "Barang berhasil ditambahkan";
			}
			else
			{
				message = "Terjadi kegagalan dalam memasukkan barang";
			}
			MessageBox.Show(message);
			//this.Close();
			ClearForm();
			GenerateKodeBarang();
		}

		/// <summary>
		/// Validation function
		/// </summary>
		/// <returns>validation result</returns>
		private int DoValidation()
		{
			if (txtNamaBarang.Text.Equals("")) return VALIDATE_EMPTY_FORM;
			//if (txtStok.Text.Equals("")) return VALIDATE_EMPTY_FORM;
			//if (txtHargaModal.Text.Equals("")) return VALIDATE_EMPTY_FORM;
			//if (txtHargaJual.Text.Equals("")) return VALIDATE_EMPTY_FORM;

			if (txtStok.Text.Equals("")) txtStok.Text = "0";
			if (txtHargaModal.Text.Equals("")) txtHargaModal.Text = "0";
			if (txtHargaJual.Text.Equals("")) txtHargaJual.Text = "0";

			return VALIDATE_OK;
		}

		/// <summary>
		/// clear form
		/// </summary>
		private void ClearForm()
		{
			txtNamaBarang.Text = "";
			txtStok.Text = "";
			txtHargaModal.Text = "";
			txtHargaJual.Text = "";

			txtNamaBarang.Focus();
		}

		private int AddBarang()
		{
			Barang barang = new Barang();
			barang.jenisBarang = (JenisBarang)cmbJenisBarang.SelectedItem;
			barang.kodeBarang = txtKodeBarang.Text;
			barang.namaBarang = txtNamaBarang.Text;
			barang.stok = Math.Round(double.Parse(txtStok.Text), 2);
			barang.hargaModal = Math.Round(double.Parse(txtHargaModal.Text), 2);
			barang.hargaJual = Math.Round(double.Parse(txtHargaJual.Text), 2);

			//if user want to create downgraded version of the item
			if (chkBarangDG.Checked)
			{
				Barang dgBarang = new Barang();
				dgBarang.jenisBarang = (JenisBarang)cmbJenisBarang.SelectedItem;
				//generate kodeBarang with offset 1 (1 + last kodeBarang, last kodeBarang is for original Barang)
				dgBarang.kodeBarang = service.GenerateKodeBarang(barang.jenisBarang.idJenisBarang, 1);
				dgBarang.namaBarang = txtNamaBarang.Text + " grade 2";
				dgBarang.stok = 0;
				dgBarang.hargaModal = 0;
				dgBarang.hargaJual = 0;

				return service.InsertBarang(new Barang[]{ barang, dgBarang });
			}

			return service.InsertBarang(barang);
		}

		private void txtHargaModal_KeyPress(object sender, KeyPressEventArgs e)
		{
			NonNumericPreventor.PreventNonNumberKey(sender, e);
		}

		private void txtHargaJual_KeyPress(object sender, KeyPressEventArgs e)
		{
			NonNumericPreventor.PreventNonNumberKey(sender, e);
		}

		private void txtStok_KeyPress(object sender, KeyPressEventArgs e)
		{
			NonNumericPreventor.PreventNonNumberKey(sender, e);
		}

		private void btnBatal_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void cmbJenisBarang_SelectedIndexChanged(object sender, EventArgs e)
		{
			GenerateKodeBarang();
		}
	}
}
