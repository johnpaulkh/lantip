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
	public partial class FormListJenisBarang : Form
	{

		private static FormListJenisBarang thisForm;

		public FormListJenisBarang()
		{
			InitializeComponent();
		}

		private void FormListJenisBarang_Load(object sender, EventArgs e)
		{
			PopulateGridView();
		}

		private void PopulateGridView()
		{
			gridView.DataSource = null;
			gridView.Rows.Clear();
			JenisBarangService service = new JenisBarangService();
			List<JenisBarang> items = service.GetAllJenisBarang();
			gridView.DataSource = items;
		}

		public static void ShowForm(Form parentForm)
		{
			if (thisForm != null)
			{
				thisForm.BringToFront();
			}
			else
			{
				thisForm = new FormListJenisBarang();
				thisForm.MdiParent = parentForm;
				thisForm.Show();
			}
		}

		private void FormListJenisBarang_FormClosed(object sender, FormClosedEventArgs e)
		{
			thisForm = null;
		}

		private void btnTambahJenisBarang_Click(object sender, EventArgs e)
		{
			FormTambahJenisBarang fTambahJenisBarang = new FormTambahJenisBarang();
			fTambahJenisBarang.ShowDialog();
			PopulateGridView();
		}
	}
}
