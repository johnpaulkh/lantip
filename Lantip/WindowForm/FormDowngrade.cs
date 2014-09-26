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
	public partial class FormDowngrade : Form
	{
		private static int VALIDATE_OK = 0;
		private static int VALIDATE_EMPTY_FORM = 11;

		//content
		private Barang oriBarang;		//original
		private Barang oriDgBarang;		//original
		private Barang barang;
		private Barang dgBarang;
		private List<Barang> items;
		private AutoCompleteStringCollection sCollection;

		//service
		private BarangService service;

		public FormDowngrade(Barang barang)
		{
			InitializeComponent();

			this.barang = barang;
			this.oriBarang = barang;
			this.service = new BarangService();
			sCollection = new AutoCompleteStringCollection();
		}

		private void FormDowngrade_Load(object sender, EventArgs e)
		{
			InitializeBarangAsal();
			//get items from database
			items = service.GetAllBarang();
			//add items to barangDowngrade autoCompleteSource
			AddAutoCompleteSource();
		}

		/// <summary>
		/// set forms initial value
		/// </summary>
		private void InitializeBarangAsal()
		{
			txtBarangAsal.Text = barang.namaBarang;
			txtBAStokAwal.Text = barang.stok.ToString();
			txtBAJmlDowngrade.Text = "0";
			txtBAStokAkhir.Text = barang.stok.ToString();
			txtBAHargaModal.Text = barang.hargaModal.ToString();
			txtBAHargaJual.Text = barang.hargaJual.ToString();
		}

		/// <summary>
		/// Add items to txtBarangDowngrade autoComplete
		/// </summary>
		private void AddAutoCompleteSource()
		{
			List<string> sArr = new List<string>();
			foreach (Barang i in items)
			{
				sArr.Add(i.ToString());
			}
			sCollection.AddRange(sArr.ToArray());
			txtBarangDowngrade.AutoCompleteCustomSource = sCollection;
		}


		/// <summary>
		/// Get item barang from collection and put it into forms
		/// </summary>
		private void GetItemFromCollection()
		{
			//get current item from search
			this.dgBarang = SearchItem(txtBarangDowngrade.Text);

			//if the result is not null
			if (dgBarang != null)
			{
				//get current item for original dgBarang
				this.oriDgBarang = this.dgBarang;

				txtBDStokAwal.Text = this.dgBarang.stok.ToString();
				txtBDStokAkhir.Text = this.dgBarang.stok.ToString();
				txtBDHMAwal.Text = this.dgBarang.hargaModal.ToString();
				txtBDHMAkhir.Text = this.dgBarang.hargaModal.ToString();
				txtBDHargaJual.Text = this.dgBarang.hargaJual.ToString();
			}
		}

		/// <summary>
		/// Search barang based on nama barang
		/// </summary>
		private Barang SearchItem(string namaBarang)
		{
			var result = from i in items where i.namaBarang.ToUpper().Equals(namaBarang.ToUpper()) select i;
			return (result.ToList().Count > 0) ? result.ToList()[0] : null;
		}

		/// <summary>
		/// calculating downgrade mechanism
		/// </summary>
		private void CalculateDowngrade()
		{
			//if dgBarang is null stop
			if(dgBarang == null) return;
			//if barang downgrade is still empty
			if(txtBDStokAwal.Text == "") return;

			double jmlDowngrade = (string.IsNullOrEmpty(txtBAJmlDowngrade.Text)) ? 0 : Math.Round(double.Parse(txtBAJmlDowngrade.Text), 2);

			double baStokAwal = barang.stok;
			double baStokAkhir = barang.stok;

			double bdStokAwal = dgBarang.stok;
			double bdStokAkhir = dgBarang.stok;
			double bdHargaModalAwal = dgBarang.hargaModal;
			double bdHargaModalAkhir = dgBarang.hargaModal;

			baStokAkhir = baStokAwal - jmlDowngrade;
			bdStokAkhir = bdStokAwal + jmlDowngrade;

			//hargaModal barangDowngrade using hargaModal from barangAsal
			bdHargaModalAkhir = ((bdStokAwal * bdHargaModalAwal) + (jmlDowngrade * barang.hargaModal)) / bdStokAkhir;
			bdHargaModalAkhir = Math.Round(bdHargaModalAkhir, 2);
			
			//put them on the forms
			txtBAStokAkhir.Text = baStokAkhir.ToString();
			txtBDStokAkhir.Text = bdStokAkhir.ToString();
			txtBDHMAkhir.Text = bdHargaModalAkhir.ToString();
		}

		/// <summary>
		/// Validation function
		/// </summary>
		/// <returns>validation result</returns>
		private int DoValidation()
		{
			if (txtBarangDowngrade.Text.Equals("")) return VALIDATE_EMPTY_FORM;
			if (txtBAJmlDowngrade.Text.Equals("")) return VALIDATE_EMPTY_FORM;
			if (txtBDHargaJual.Text.Equals("")) return VALIDATE_EMPTY_FORM;

			return VALIDATE_OK;
		}

		private int DowngradeBarang()
		{
			Barang submittedDgBarang = dgBarang;
			submittedDgBarang.stok = Math.Round(double.Parse(txtBDStokAkhir.Text), 2);
			submittedDgBarang.hargaModal = Math.Round(double.Parse(txtBDHMAkhir.Text), 2);
			submittedDgBarang.hargaJual = Math.Round(double.Parse(txtBDHargaJual.Text), 2);

			Barang submittedOriBarang = barang;
			submittedOriBarang.stok = Math.Round(double.Parse(txtBAStokAkhir.Text), 2);

			return service.Downgradebarang(oriBarang, oriDgBarang, submittedOriBarang, submittedDgBarang);
		}

		private void btnBatal_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void txtBarangDowngrade_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Tab)
			{
				e.Handled = e.SuppressKeyPress = true;

				//add barang downgrade's information to form
				GetItemFromCollection();
			}
		}

		private void txtBAJmlDowngrade_KeyPress(object sender, KeyPressEventArgs e)
		{
			NonNumericPreventor.PreventNonNumberKey(sender, e);
		}

		private void btnCari_Click(object sender, EventArgs e)
		{
			//add barang downgrade's information to form
			GetItemFromCollection();
		}

		private void txtBAJmlDowngrade_TextChanged(object sender, EventArgs e)
		{
			CalculateDowngrade();
		}

		private void txtBarangDowngrade_TextChanged(object sender, EventArgs e)
		{
			//add barang downgrade's information to form
			GetItemFromCollection();
		}

		private void btnOK_Click(object sender, EventArgs e)
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


			int result = DowngradeBarang();
			String message = "";
			if (result == 1)
			{
				message = "Barang berhasil di-downgrade";
			}
			else
			{
				message = "Terjadi kegagalan dalam melakukan downgrade barang";
			}
			MessageBox.Show(message);
			this.Close();
		}
	}
}
