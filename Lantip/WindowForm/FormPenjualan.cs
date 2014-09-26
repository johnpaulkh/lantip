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
using System.Drawing.Printing;

namespace Lantip.WindowForm
{
	public partial class FormPenjualan : Form
	{
		private static FormPenjualan thisForm = null;
		private static int VALIDATE_OK = 0;
		private static int VALIDATE_EMPTY_FORM = 11;
		private static int VALIDATE_EMPTY_BAYAR = 12;
		private static int VALIDATE_BAYAR_NOT_SUFFICIENT = 13;

		//content
		public double bayar { get; set; }
		private List<Barang> items;
		private Barang currentItem;
		private Penjualan penjualan;
		private BindingList<PenjualanDetail> penjualanDetail;
		private AutoCompleteStringCollection sCollection;
		private PrintDocument printDocument;

		//service
		private PenjualanService service;
		private BarangService barangService;

		public FormPenjualan()
		{
			InitializeComponent();

			currentItem = new Barang();
			service = new PenjualanService();
			barangService = new BarangService();
			sCollection = new AutoCompleteStringCollection();
			penjualan = new Penjualan();
			penjualanDetail = new BindingList<PenjualanDetail>();
		}

		private void FormPenjualan_Load(object sender, EventArgs e)
		{
			//make windows maximized
			this.WindowState = FormWindowState.Maximized;
			//populate item
			PopulateItems();
			//add nama to txtNama
			txtNama.Text = CurrentOperator.CURRENT_OPERATOR.nama;
			//add item to cariBarang autoCompleteSource
			AddAutoCompleteSource();
			//bind penjualanDetail to gridView
			InitializeGridView();
		}

		public static void ShowForm(Form parentForm)
		{
			if (thisForm != null)
			{
				thisForm.BringToFront();
			}
			else
			{
				thisForm = new FormPenjualan();
				thisForm.MdiParent = parentForm;
				thisForm.Show();
			}
		}

		private void ReloadForm()
		{
			//clear all form
			txtCariBarang.Text = "";
			txtKodeBarang.Text = "";
			txtNamaBarang.Text = "";
			txtJumlah.Text = "";
			txtHarga.Text = "";
            txtSubtotal.Text = "";
            txtBayar.Text = "";
            txtKembali.Text = "";

			//clear penjualanDetail;
			penjualanDetail.Clear();
			gridView.Refresh();
		}

		/// <summary>
		/// Populate items (list of barangs) from database
		/// </summary>
		private void PopulateItems()
		{
			items = barangService.GetAllBarang();
		}

		/// <summary>
		/// Add items to txtCariBarang autoComplete
		/// </summary>
		private void AddAutoCompleteSource()
		{
			List<string> sArr = new List<string>();
			foreach (Barang i in items)
			{
				sArr.Add(i.ToString());
			}
			sCollection.AddRange(sArr.ToArray());
			txtCariBarang.AutoCompleteCustomSource = sCollection;
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
		/// Similar to <see cref="SearchItem"/> but using kodeBarang instead
		/// </summary>
		private Barang SearchItemByKodeBarang(string kodeBarang)
		{
			var result = from i in items where i.kodeBarang.ToUpper().Equals(kodeBarang.ToUpper()) select i;
			return (result.ToList().Count > 0) ? result.ToList()[0] : null;
		}

		/// <summary>
		/// Get item barang from collection and put it into forms
		/// </summary>
		private void GetItemFromCollection()
		{
			//get current item from search
			currentItem = SearchItem(txtCariBarang.Text);

			//if the result is not null
			if (currentItem != null)
			{
				txtKodeBarang.Text = currentItem.kodeBarang;
				txtNamaBarang.Text = currentItem.namaBarang;
				txtHarga.Text = currentItem.hargaJual.ToString();
			}
			else
			{
				txtKodeBarang.Text = "";
				txtNamaBarang.Text = "";
				txtHarga.Text = "";
			}
		}

		/// <summary>
		/// Get item barang from collection and put it into forms using kodeBarang
		/// </summary>
		private void GetItemFromCollectionByKodeBarang()
		{
			//get current item from search
			currentItem = SearchItemByKodeBarang(txtKodeBarang.Text);

			//if the result is not null
			if (currentItem != null)
			{
				txtKodeBarang.Text = currentItem.kodeBarang;
				txtNamaBarang.Text = currentItem.namaBarang;
				txtHarga.Text = currentItem.hargaJual.ToString();
			}
		}

		/// <summary>
		/// Add penjualan detail to gridView and penjualan
		/// </summary>
		private void AddPenjualanToGridView()
		{
			//if current item is still not selected of jumlah is empty
			if (string.IsNullOrEmpty(txtKodeBarang.Text) || string.IsNullOrEmpty(txtJumlah.Text))
			{
				return;
			}

			//if currentItem is in penjualanDetail add to that penjualanDetail
			var samePenjualanDetail = (from pd in penjualanDetail where pd.barang.idBarang == currentItem.idBarang select pd);
			if (samePenjualanDetail.ToList().Count != 0)
			{
				samePenjualanDetail.ToList().ForEach(pd => pd.jumlah += Math.Round(double.Parse(txtJumlah.Text), 2));
			}
			else
			{
				//add current item to penjualan detail
				PenjualanDetail detail = new PenjualanDetail();
				detail.barang = currentItem;
				detail.hargaModal = currentItem.hargaModal;
				detail.hargaJual = currentItem.hargaJual;
				detail.jumlah = Math.Round(double.Parse(txtJumlah.Text), 2);
				penjualanDetail.Add(detail);
			}

			//add penjualanDetail to gridView
			UpdateGridView();

			//calculate subtotal
			double subtotal = 0;
			foreach (PenjualanDetail penD in penjualanDetail)
			{
				subtotal += penD.jumlah * penD.hargaJual;
			}
			txtSubtotal.Text = subtotal.ToString();		//show subtotal in form

			//clear the form
			ClearForm();
		}

		/// <summary>
		/// Add DataSource to gridView and update it
		/// </summary>
		private void UpdateGridView()
		{
			gridView.Refresh();
			for (int i = 0; i < gridView.Rows.Count; i++)
			{
				double hargaJual = Math.Round(double.Parse(gridView.Rows[i].Cells["hargaJual"].Value.ToString()), 2);
				double jumlah = Math.Round(double.Parse(gridView.Rows[i].Cells["jumlah"].Value.ToString()), 2);
				gridView.Rows[i].Cells["totalPenjualan"].Value = hargaJual * jumlah;
			}
		}

		/// <summary>
		/// Initialize gridView's initial state and data
		/// </summary>
		private void InitializeGridView()
		{
			gridView.DataSource = penjualanDetail;

			gridView.Columns["idPenjualan"].Visible = false;
			gridView.Columns["hargaModal"].Visible = false;

			gridView.Columns.Add("totalPenjualan", "Total Penjualan");
		}

		/// <summary>
		/// Clear several forms to ensure user is ready to input another barang
		/// </summary>
		private void ClearForm()
		{
			txtCariBarang.Text = "";
			txtKodeBarang.Text = "";
			txtJumlah.Text = "";
			txtNamaBarang.Text = "";
			txtHarga.Text = "";

			txtCariBarang.Focus();
		}


		/// <summary>
		/// Validation function
		/// </summary>
		/// <returns>validation code</returns>
		private int DoValidation()
		{
			if (penjualanDetail.Count <= 0) return VALIDATE_EMPTY_FORM;
			if (string.IsNullOrEmpty(txtBayar.Text)) return VALIDATE_EMPTY_BAYAR;

			double subtotal = double.Parse(txtSubtotal.Text);
			double bayar = double.Parse(txtBayar.Text);
			if (bayar < subtotal) return VALIDATE_BAYAR_NOT_SUFFICIENT;

			return VALIDATE_OK;
		}

		/// <summary>
		/// Add penjualan to database and print the receipt
		/// </summary>
		/// <returns>service result</returns>
		private int AddPenjualan()
		{
			return service.InsertPenjualan(this.penjualan);
		}

		/// <summary>
		/// Print POS for customer
		/// </summary>
		private void PrintReceipt()
		{
			printDocument = new PrintDocument();
			printDocument.PrintPage += new PrintPageEventHandler(printDocument_PrintPage);
			printDocument.PrinterSettings.PrinterName = "GP-7645(No Cut) Series";
			printDocument.Print();
		}

		void printDocument_PrintPage(object sender, PrintPageEventArgs e)
		{
			Graphics graphics = e.Graphics;
			Font font = new Font("Lucida Console", 8);
			float fontHeight = font.GetHeight();
			int startX = 3;
			int startY = 3;
			int Offset = 10;
			double subtotal = 0;	//subtotal  of penjualan
			int whitespaceW = 0;	//width of whitespace in receipt
			string whitespace = ""; //chars of space as whitespace
			int width = 25;			//width of the total chars per line
			string rp = "Rp. ";		//Rp. string



			graphics.DrawString("Raja Ratu Fresh Mart", font,
								new SolidBrush(Color.Black), startX, startY + Offset);
			Offset += 15;

			graphics.DrawString("Tanggal" + this.penjualan.tanggal,
					 font,
					 new SolidBrush(Color.Black), startX, startY + Offset);
			Offset += 15;

			graphics.DrawString("Kasir :" + this.penjualan.user.nama,
					 font,
					 new SolidBrush(Color.Black), startX, startY + Offset);
			Offset += 15;


			String underLine = "------------------------------------------";
			graphics.DrawString(underLine, font,
					 new SolidBrush(Color.Black), startX, startY + Offset);
			Offset += 25;

			foreach (PenjualanDetail penD in this.penjualan.penjualanDetails)
			{
				//calculate grandTotal
				subtotal += (penD.hargaJual * penD.jumlah);

				//if jumlah only 1
				if (penD.jumlah == 1)
				{
					/*
					 * Daun Bawang              Rp. 4000
					 */

					//calculate whitespace width	
					whitespaceW = width - penD.barang.namaBarang.Length;
					whitespace = "".PadLeft(whitespaceW, ' ');

					graphics.DrawString(penD.barang.namaBarang + whitespace + rp + penD.hargaJual.ToString(),
						 font,
						 new SolidBrush(Color.Black), startX, startY + Offset);
					Offset += 15;
				}
				else
				{
					/*
					 * Daun Bawang
					 *   2 x Rp. 4000         Rp. 8000
					 */

					//namaBarang
					graphics.DrawString(penD.barang.namaBarang,
						 font,
						 new SolidBrush(Color.Black), startX, startY + Offset);
					Offset += 15;

					//calculate whitespace width
					int xOffset = 2; //offset for jumlah
					whitespaceW = width
										- xOffset
										- penD.jumlah.ToString().Length
										- " x ".Length
										- rp.Length
										- penD.hargaJual.ToString().Length;
					whitespace = "".PadLeft(whitespaceW, ' ');

					//jumlah and total
					string jmlAndTotal = "  "
										+ penD.jumlah.ToString()
										+ " x "
										+ rp + penD.hargaJual.ToString()
										+ whitespace
										+ rp + (penD.hargaJual * penD.jumlah).ToString();
					graphics.DrawString(jmlAndTotal,
						 font,
						 new SolidBrush(Color.Black), startX, startY + Offset);
					Offset += 15;
				}
			}


			//total
			Offset += 15;
			//calculate whitespace width
			whitespaceW = width - ("Total : " + "Total : " + Math.Round(subtotal, 2).ToString()).Length;
			whitespace = "".PadLeft(whitespaceW, ' ');
			graphics.DrawString(whitespace + "Total : " + Math.Round(subtotal, 2).ToString(),
					 font,
					 new SolidBrush(Color.Black), startX, startY + Offset);
			Offset += 25;

			//subtotal
			graphics.DrawString("Subtotal : " + Math.Round(subtotal, 2).ToString(),
					 font,
					 new SolidBrush(Color.Black), startX, startY + Offset);
			Offset += 15;

			//bayar
			graphics.DrawString("Bayar    : " + bayar.ToString(),
					 font,
					 new SolidBrush(Color.Black), startX, startY + Offset);
			Offset += 15;

			//kembali
			graphics.DrawString("Kembali  : " + (bayar - Math.Round(subtotal, 2)).ToString(),
					 font,
					 new SolidBrush(Color.Black), startX, startY + Offset);
			Offset += 15;

			//terima kasih
			graphics.DrawString("Terima kasih atas kunjungan anda",
					 font,
					 new SolidBrush(Color.Black), startX, startY + Offset);
			Offset += 15;
		}

		/// <summary>
		/// constructing proper penjualan, with penjualanDetail in it
		/// </summary>
		/// <returns></returns>
		private void ConstructPenjualan()
		{
			this.penjualan.shift = int.Parse(txtShift.Text);
			this.penjualan.tanggal = dtPicker.Value; ;
			this.penjualan.user = CurrentOperator.CURRENT_OPERATOR;
			this.penjualan.penjualanDetails = penjualanDetail.ToList();

			bayar = double.Parse(txtBayar.Text);
		}
		
		/// <summary>
		/// Do mechanism of submit penjualan by OK button and Enter on Bayar textBox
		/// </summary>
		private void DoSubmitPenjualan()
		{
			//validation
			int validationResult = DoValidation();
			if (validationResult != VALIDATE_OK)
			{
				if (validationResult == VALIDATE_EMPTY_FORM)
				{
					MessageBox.Show("Masukkan penjualan");
					return;
				}
				if (validationResult == VALIDATE_EMPTY_BAYAR)
				{
					MessageBox.Show("Masukkan pembayaran");
					return;
				}
				if (validationResult == VALIDATE_BAYAR_NOT_SUFFICIENT)
				{
					MessageBox.Show("Pembayaran tidak cukup");
					return;
				}
			}

			ConstructPenjualan(); //constructing penjualan in proper form, with penjualanDetail in it

			int result = AddPenjualan();	//insert penjualan to DB
			PrintReceipt();					//print to receipt

			String message = "";
			if (result == 1)
			{
				message = "Penjualan berhasil ditambahkan";
			}
			else
			{
				message = "Terjadi kegagalan dalam memasukkan penjualan";
			}

			MessageBox.Show(message);

			//refresh form
			ReloadForm();
		}

		//EventListeners

		private void FormPenjualan_FormClosed(object sender, FormClosedEventArgs e)
		{
			thisForm = null;
		}

		private void txtCariBarang_KeyDown(object sender, KeyEventArgs e)
		{
			//if enter is pressed
			if (e.KeyCode == Keys.Enter)
			{
				e.Handled = e.SuppressKeyPress = true;
				GetItemFromCollection();
			}
		}

		private void txtCariBarang_TextChanged(object sender, EventArgs e)
		{
			GetItemFromCollection();
		}

		private void txtKodeBarang_TextChanged(object sender, EventArgs e)
		{
			GetItemFromCollectionByKodeBarang();
		}

		private void txtJumlah_KeyDown(object sender, KeyEventArgs e)
		{
			//if enter is pressed
			if (e.KeyCode == Keys.Enter)
			{
				e.Handled = e.SuppressKeyPress = true;
				AddPenjualanToGridView();
			}
		}

		private void btnTambah_Click(object sender, EventArgs e)
		{
			AddPenjualanToGridView();
		}

		private void txtJumlah_KeyPress(object sender, KeyPressEventArgs e)
		{
			NonNumericPreventor.PreventNonNumberKey(sender, e);
		}

		private void btnBatal_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void btnOK_Click(object sender, EventArgs e)
		{
			DoSubmitPenjualan();
		}

        private void txtBayar_TextChanged(object sender, EventArgs e)
        {
            double subtotal = (!string.IsNullOrEmpty(txtSubtotal.Text)) ? double.Parse(txtSubtotal.Text) : 0;
            double bayar = (!string.IsNullOrEmpty(txtSubtotal.Text)) ? double.Parse(txtBayar.Text) : 0;
            double kembali = bayar - subtotal;
            if (kembali >= 0)
            {
                txtKembali.Text = kembali.ToString();
            }
        }

		private void txtBayar_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
			{
				e.Handled = e.SuppressKeyPress = true;
				DoSubmitPenjualan();
			}
		}

		private void btnCari_Click(object sender, EventArgs e)
		{
			GetItemFromCollection();
		}

		//eo Event Listeners
	}
}
