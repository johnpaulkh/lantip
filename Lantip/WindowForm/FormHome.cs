using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Lantip.Util;
using Lantip.Model;

namespace Lantip.WindowForm
{
	public partial class FormHome : Form
	{

		public FormHome()
		{
			InitializeComponent();
		}

		private void FormHome_Load(object sender, EventArgs e)
		{
			//hide menu based on tipeUser
			HideMenu();
		}

		private void HideMenu()
		{
			User currentOperator = CurrentOperator.CURRENT_OPERATOR;
			if (currentOperator.tipeUser == User.EMPLOYEE)
			{
				this.dataPenjualanToolStripMenuItem.Visible = false;
				this.stokToolStripMenuItem.Visible = false;
				this.barangToolStripMenuItem.Visible = false;
				this.jenisBarangToolStripMenuItem.Visible = false;
			}
		}

		private void barangToolStripMenuItem_Click(object sender, EventArgs e)
		{
			FormListBarang.ShowForm(this);
		}

		private void jenisBarangToolStripMenuItem_Click(object sender, EventArgs e)
		{
			FormListJenisBarang.ShowForm(this);
		}

		private void penjualanToolStripMenuItem_Click(object sender, EventArgs e)
		{
			FormPenjualan.ShowForm(this);
		}

		private void dataPenjualanToolStripMenuItem_Click_1(object sender, EventArgs e)
		{
			FormDataPenjualan.ShowForm(this);
		}

		private void daftarBarangToolStripMenuItem_Click(object sender, EventArgs e)
		{
			FormDaftarBarang.ShowForm(this);
		}
	}
}
