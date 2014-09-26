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
	public partial class FormDetailPenjualan : Form
	{
		private PenjualanService service;
		private List<PenjualanDetail> items;
		private Penjualan penjualan;
		private BindingSource bindingSource;

		public FormDetailPenjualan(Penjualan penjualan)
		{
			InitializeComponent();

			this.bindingSource = new BindingSource();
			this.service = new PenjualanService();
			this.items = new List<PenjualanDetail>();
			this.penjualan = penjualan;
		}

		private void FormDetailPenjualan_Load(object sender, EventArgs e)
		{
			PopulateGridView();
		}

		/// <summary>
		/// populate grid view with penjualanDetail data
		/// </summary>
		private void PopulateGridView()
		{
			this.gridView.DataSource = null;
			this.gridView.Rows.Clear();
			this.items = this.service.GetPenjualanDetail(penjualan);
			this.bindingSource.DataSource = this.items;
			this.gridView.DataSource = this.bindingSource;
		}

		/// <summary>
		/// Calculate subtotal of this penjualan
		/// </summary>
		private void CalculateSubtotal()
		{
			double subtotal = 0;
			foreach (PenjualanDetail pd in this.items)
			{
				subtotal += (pd.jumlah * pd.hargaModal);
			}
			txtSubtotal.Text = subtotal.ToString();
		}
	}
}
