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
	public partial class FormDataPenjualan : Form
	{
		private static FormDataPenjualan thisForm = null;

		private PenjualanService service;
		private BindingSource bindingSource;
		private List<Penjualan> items;
		private int numberOfPage;
		private int page = 1;

		public FormDataPenjualan()
		{
			InitializeComponent();

			this.bindingSource = new BindingSource();
			this.service = new PenjualanService();
		}

		private void FormDataPenjualan_Load(object sender, EventArgs e)
		{
			LoadForm();
		}

		private void LoadForm()
		{
			DateTime fromDate = dtpFrom.Value;
			DateTime toDate = dtpTo.Value;
			PopulateGridView(this.page, fromDate, toDate);

			//get number of page
			GetNumberOfPage();

			//make btnPrev disabled
			btnPrev.Enabled = false;
			//if numberOfPage == 1 btnNext disabled
			btnPrev.Enabled = !(numberOfPage == 1);
			txtPage.Text = this.page.ToString();
		}

		/// <summary>
		/// Show form as a single instance
		/// </summary>
		/// <param name="parentForm">MDI parent form</param>
		public static void ShowForm(Form parentForm)
		{
			if (thisForm != null)
			{
				thisForm.BringToFront();
			}
			else
			{
				thisForm = new FormDataPenjualan();
				thisForm.MdiParent = parentForm;
				thisForm.Show();
			}
		}

		/// <summary>
		/// get number of page
		/// </summary>
		private void GetNumberOfPage()
		{
			DateTime fromDate = dtpFrom.Value;
			DateTime toDate = dtpTo.Value;
			numberOfPage = (int)Math.Ceiling(
								(double)(Double.Parse(service.GetCountPenjualan(fromDate, toDate).ToString()) 
								/ PenjualanService.penjualanPerPage));
			txtNumberOfPage.Text = numberOfPage.ToString();
		}

		/// <summary>
		/// populate gridView with data, with date range
		/// </summary>
		private void PopulateGridView(int page, DateTime fromDate, DateTime toDate)
		{
			this.gridView.DataSource = null;
			this.gridView.Rows.Clear();
			items = service.GetAllPenjualan(page, fromDate, toDate);
			bindingSource.DataSource = items;
			gridView.DataSource = bindingSource;
		}

		/// <summary>
		/// change the data based on page
		/// </summary>
		/// <param name="page">page of data</param>
		private void ChangePage(int page)
		{
			//if page > numberOfPage page = numberOfPage
			if (page > numberOfPage)
			{
				page = numberOfPage;
				txtPage.Text = numberOfPage.ToString();
			}

			this.page = page;
			
			//if current page == 1 btnPrev disabled
			btnPrev.Enabled = !(this.page == 1);
			//if current page == numberOfPage btnNext disabled
			btnNext.Enabled = !(this.page == numberOfPage);

			DateTime fromDate = dtpFrom.Value;
			DateTime toDate = dtpTo.Value;
			//populate gridView based on page
			PopulateGridView(this.page, fromDate, toDate);
		}

		private void txtPage_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
			{
				e.Handled = e.SuppressKeyPress = true;
				ChangePage(int.Parse(txtPage.Text));
			}
		}

		private void txtPage_KeyPress(object sender, KeyPressEventArgs e)
		{
			NonNumericPreventor.PreventNonNumberKey(sender, e);
		}

		private void btnPrev_Click(object sender, EventArgs e)
		{
			ChangePage(this.page - 1);
			txtPage.Text = (this.page).ToString();
		}

		private void btnNext_Click(object sender, EventArgs e)
		{
			ChangePage(this.page + 1);
			txtPage.Text = (this.page).ToString();
		}

		private void FormDataPenjualan_FormClosed(object sender, FormClosedEventArgs e)
		{
			thisForm = null;
		}

		private void gridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			int itemIndex = gridView.CurrentCell.RowIndex;
			FormDetailPenjualan fDetailPenjualan = new FormDetailPenjualan(items[itemIndex]);
			fDetailPenjualan.ShowDialog();
		}

		private void btnCariTransaksi_Click(object sender, EventArgs e)
		{
			DateTime fromDate = dtpFrom.Value;
			DateTime toDate = dtpTo.Value;

			//populate gridView
			PopulateGridView(1, fromDate, toDate);

			//get countOfPage again
			GetNumberOfPage();

			//make btnPrev disabled
			btnPrev.Enabled = false;
			//if numberOfPage == 1 btnNext disabled
			btnPrev.Enabled = !(numberOfPage == 1);
			txtPage.Text = this.page.ToString();

			//change page to page 1
			ChangePage(1);
			txtPage.Text = "1";
		}
	}
}
