using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Lantip.Service;
using Lantip.Model;

namespace Lantip.WindowForm
{
	public partial class FormListBarang : Form
	{

		private static FormListBarang thisForm;

		//content
		private List<Barang> items = null;
		private BindingSource bindingSource;
		//service
		private BarangService service;

		public FormListBarang()
		{
			InitializeComponent();

			this.bindingSource = new BindingSource();
			this.service = new BarangService();
		}

		private void FormListBarang_Load(object sender, EventArgs e)
		{
			PopulateGridView();
		}

		private void PopulateGridView()
		{
			this.gridView.DataSource = null;
			this.gridView.Rows.Clear();
			items = service.GetAllBarang();
			bindingSource.DataSource = items;
			gridView.DataSource = bindingSource;
		}

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
					gridView.CurrentCell = gridView.Rows[i].Cells[0]; 
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

		public static void ShowForm(Form parentForm)
		{
			if (thisForm != null)
			{
				thisForm.BringToFront();
			}
			else
			{
				thisForm = new FormListBarang();
				thisForm.MdiParent = parentForm;
				thisForm.Show();
			}
		}

		private void FormListBarang_FormClosing(object sender, FormClosingEventArgs e)
		{
			thisForm = null;
		}

		private void btnTambah_Click(object sender, EventArgs e)
		{
			FormTambahBarang fTambahBarang = new FormTambahBarang();
			fTambahBarang.ShowDialog();
			PopulateGridView();
		}

		private void btnEdit_Click(object sender, EventArgs e)
		{
			//get selected barang
			Barang selectedBarang = items[gridView.CurrentCell.RowIndex];
			FormEditBarang fEditBarang = new FormEditBarang(selectedBarang);
			fEditBarang.ShowDialog();
			PopulateGridView();
		}

		private void btnPenyesuaianStok_Click(object sender, EventArgs e)
		{
			//get selected barang
			Barang selectedBarang = items[gridView.CurrentCell.RowIndex];
			FormPenyesuaianStok fPenyesuaianStok = new FormPenyesuaianStok(selectedBarang);
			fPenyesuaianStok.ShowDialog();
			PopulateGridView();
		}

		private void btnPembelian_Click(object sender, EventArgs e)
		{
			//get selected barang
			Barang selectedBarang = items[gridView.CurrentCell.RowIndex];
			FormPembelian fPembelian = new FormPembelian(selectedBarang);
			fPembelian.ShowDialog();
			PopulateGridView();
		}

		private void txtSearch_KeyDown(object sender, KeyEventArgs e)
		{
			//if enter is pressed do search
			if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Tab)
			{
				e.Handled = e.SuppressKeyPress = true;
				DoSearch();
			}
		}

		private void btnDowngrade_Click(object sender, EventArgs e)
		{
			//get selected barang
			Barang selectedBarang = items[gridView.CurrentCell.RowIndex];
			FormDowngrade fDowngrade = new FormDowngrade(selectedBarang);
			fDowngrade.ShowDialog();
			PopulateGridView();
		}

        private void btnCari_Click(object sender, EventArgs e)
        {
            DoSearch();
        }
	}
}
