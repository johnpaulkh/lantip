using Lantip.Model;
using Lantip.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lantip.WindowForm
{
    public partial class FormDaftarBarang : Form
    {

		private static FormDaftarBarang thisForm;

        //content
		private List<Barang> items;
		private BarangService service;
		private BindingSource bindingSource;

        public FormDaftarBarang()
        {
            InitializeComponent();

			this.service = new BarangService();
			this.items = new List<Barang>();
			this.bindingSource = new BindingSource();
        }

		/// <summary>
		/// Populate gridView with data from DB
		/// </summary>
		private void PopulateGridView()
		{
			this.gridView.DataSource = null;
			this.gridView.Rows.Clear();
			this.items = this.service.GetAllBarang();
			this.bindingSource.DataSource = this.items;
			this.gridView.DataSource = this.bindingSource;
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
				thisForm = new FormDaftarBarang();
				thisForm.Show();
				thisForm.MdiParent = parentForm;
			}
		}
    
        /// <summary>
        /// Do search mechanism
        /// </summary>
        private void DoSearch()
        {
			//BindingList<Barang> filtered = new BindingList<Barang>(items.Where(obj => obj.namaBarang.ToLower().Contains(txtSearch.Text.ToLower())).ToList());
			//gridView.DataSource = filtered;
			//gridView.Update();

			//move to current cell
			Boolean found = false;
			for (int i = this.gridView.CurrentCell.RowIndex + 1; i < items.Count; i++)
			{
				if (items[i].namaBarang.ToLower().Contains(txtSearch.Text.ToLower()))
				{
					found = true;
					gridView.CurrentCell = gridView.Rows[i].Cells[1];
					return;
				}
			}

			//if barang is not found, do the search from the beginning
			if (!found)
			{
				for (int i = 0; i < items.Count; i++)
				{
					if (items[i].namaBarang.ToLower().Contains(txtSearch.Text.ToLower()))
					{
						found = true;
						gridView.CurrentCell = gridView.Rows[i].Cells[1];
						return;
					}
				}
			}
        }

		/// <summary>
		/// initialize gridView's initial attribute
		/// </summary>
		private void InitializeGridView()
		{
			gridView.Columns["idBarang"].Visible = false;
			gridView.Columns["hargaModal"].Visible = false;
			gridView.Columns["stok"].Visible = false;
		}

        private void FormDaftarBarang_Load(object sender, EventArgs e)
        {
			PopulateGridView();
			InitializeGridView();
        }

        private void txtCari_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = e.SuppressKeyPress = true;
				DoSearch();
            }
		}

		private void btnCari_Click(object sender, EventArgs e)
		{
			DoSearch();
		}

		private void btnUbahHargaBarang_Click(object sender, EventArgs e)
		{
			//get selected barang
			Barang selectedBarang = items[gridView.CurrentCell.RowIndex];
			FormEditBarang fEditBarang = new FormEditBarang(selectedBarang);
			fEditBarang.ShowDialog();
			PopulateGridView();
		}
    }
}
