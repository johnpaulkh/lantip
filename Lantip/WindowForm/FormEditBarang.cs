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
	public partial class FormEditBarang : Form
	{
		private static int VALIDATE_OK = 0;
		private static int VALIDATE_EMPTY_FORM = 11;
		//content
		private Barang oriItem;		//original
		private Barang item;
		private List<JenisBarang> jenisBarangs = null;
		//service
		private BarangService service;

		public FormEditBarang(Barang item)
		{
			InitializeComponent();

			//initialize content
			this.item = item;
			this.oriItem = item;
			this.service = new BarangService();

			//initialize components state
			InitializeComponentState();
		}

		/// <summary>
		/// Initialize this form components state
		/// </summary>
		public void InitializeComponentState()
		{
			User user = CurrentOperator.CURRENT_OPERATOR;
			if (!user.tipeUser.Equals("owner")) {
				this.txtHargaModal.Visible = false;
				this.lblHargaModal.Visible = false;
			}
			
		}

		/// <summary>
		/// Populate cmbJenisBarang from database
		/// </summary>
		private void PopulateCmbJenisBarang()
		{
			JenisBarangService jbService = new JenisBarangService();
			jenisBarangs = jbService.GetAllJenisBarang();

			cmbJenisBarang.DataSource = jenisBarangs;
		}

		/// <summary>
		/// generate kodeBarang based on idJenisBarang and number of barang in that jenisBarang
		/// </summary>
		private void GenerateKodeBarang()
		{
			//get from service
			JenisBarang selectedJB = (JenisBarang)cmbJenisBarang.SelectedItem;
			txtKodeBarang.Text = service.GenerateKodeBarang(selectedJB.idJenisBarang);
		}

		private void FormEditBarang_Load(object sender, EventArgs e)
		{
			txtNamaBarang.Text = item.namaBarang;
			txtHargaModal.Text = item.hargaModal.ToString();
			txtHargaJual.Text = item.hargaJual.ToString();
			txtStok.Text = item.stok.ToString();

			PopulateCmbJenisBarang();
			foreach (JenisBarang i in jenisBarangs)
			{
				if (i.idJenisBarang.Equals(item.jenisBarang.idJenisBarang))
				{
					cmbJenisBarang.SelectedItem = i;
				}
			}

			txtKodeBarang.Text = item.kodeBarang;
		}

		private void txtHargaModal_KeyPress(object sender, KeyPressEventArgs e)
		{
			NonNumericPreventor.PreventNonNumberKey(sender, e);
		}

		private void txtHargaJual_KeyPress(object sender, KeyPressEventArgs e)
		{
			NonNumericPreventor.PreventNonNumberKey(sender, e);
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

			int result = EditBarang();
			String message = "";
			if (result == 1)
			{
				message = "Barang berhasil diedit";
			}
			else
			{
				message = "Terjadi kegagalan dalam mengedit barang";
			}
			MessageBox.Show(message);
			this.Close();
		}

		/// <summary>
		/// Validation function
		/// </summary>
		/// <returns>validation code</returns>
		private int DoValidation()
		{
			if (txtNamaBarang.Text.Equals("")) return VALIDATE_EMPTY_FORM;
			if (txtStok.Text.Equals("")) return VALIDATE_EMPTY_FORM;
			if (txtHargaModal.Text.Equals("")) return VALIDATE_EMPTY_FORM;
			if (txtHargaJual.Text.Equals("")) return VALIDATE_EMPTY_FORM;

			return VALIDATE_OK;
		}

		private int EditBarang()
		{
			Barang barang = new Barang();
			barang.idBarang = item.idBarang;
			barang.jenisBarang = (JenisBarang)cmbJenisBarang.SelectedItem;
			barang.kodeBarang = txtKodeBarang.Text;
			barang.namaBarang = txtNamaBarang.Text;
			barang.stok = Math.Round(double.Parse(txtStok.Text), 2);
			barang.hargaModal = Math.Round(double.Parse(txtHargaModal.Text), 2);
			barang.hargaJual = Math.Round(double.Parse(txtHargaJual.Text), 2);

			return service.EditBarang(this.oriItem, barang);
		}

		private void cmbJenisBarang_SelectedIndexChanged(object sender, EventArgs e)
		{
			GenerateKodeBarang();
		}
	}
}
