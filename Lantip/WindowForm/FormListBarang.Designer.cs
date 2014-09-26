namespace Lantip.WindowForm
{
	partial class FormListBarang
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormListBarang));
			this.gridView = new System.Windows.Forms.DataGridView();
			this.btnTambah = new System.Windows.Forms.Button();
			this.btnEdit = new System.Windows.Forms.Button();
			this.btnPenyesuaianStok = new System.Windows.Forms.Button();
			this.btnPembelian = new System.Windows.Forms.Button();
			this.txtSearch = new System.Windows.Forms.TextBox();
			this.btnDowngrade = new System.Windows.Forms.Button();
			this.btnCari = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.gridView)).BeginInit();
			this.SuspendLayout();
			// 
			// gridView
			// 
			this.gridView.AllowUserToAddRows = false;
			this.gridView.AllowUserToDeleteRows = false;
			this.gridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.gridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.gridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			this.gridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.gridView.DefaultCellStyle = dataGridViewCellStyle2;
			this.gridView.Location = new System.Drawing.Point(12, 81);
			this.gridView.MultiSelect = false;
			this.gridView.Name = "gridView";
			this.gridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.gridView.Size = new System.Drawing.Size(846, 424);
			this.gridView.TabIndex = 0;
			// 
			// btnTambah
			// 
			this.btnTambah.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnTambah.Location = new System.Drawing.Point(12, 12);
			this.btnTambah.Name = "btnTambah";
			this.btnTambah.Size = new System.Drawing.Size(75, 27);
			this.btnTambah.TabIndex = 1;
			this.btnTambah.Text = "Tambah";
			this.btnTambah.UseVisualStyleBackColor = true;
			this.btnTambah.Click += new System.EventHandler(this.btnTambah_Click);
			// 
			// btnEdit
			// 
			this.btnEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnEdit.Location = new System.Drawing.Point(93, 12);
			this.btnEdit.Name = "btnEdit";
			this.btnEdit.Size = new System.Drawing.Size(75, 27);
			this.btnEdit.TabIndex = 2;
			this.btnEdit.Text = "Edit";
			this.btnEdit.UseVisualStyleBackColor = true;
			this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
			// 
			// btnPenyesuaianStok
			// 
			this.btnPenyesuaianStok.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnPenyesuaianStok.Location = new System.Drawing.Point(174, 12);
			this.btnPenyesuaianStok.Name = "btnPenyesuaianStok";
			this.btnPenyesuaianStok.Size = new System.Drawing.Size(150, 27);
			this.btnPenyesuaianStok.TabIndex = 3;
			this.btnPenyesuaianStok.Text = "Penyesuaian Stok";
			this.btnPenyesuaianStok.UseVisualStyleBackColor = true;
			this.btnPenyesuaianStok.Click += new System.EventHandler(this.btnPenyesuaianStok_Click);
			// 
			// btnPembelian
			// 
			this.btnPembelian.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnPembelian.Location = new System.Drawing.Point(330, 12);
			this.btnPembelian.Name = "btnPembelian";
			this.btnPembelian.Size = new System.Drawing.Size(92, 27);
			this.btnPembelian.TabIndex = 4;
			this.btnPembelian.Text = "Pembelian";
			this.btnPembelian.UseVisualStyleBackColor = true;
			this.btnPembelian.Click += new System.EventHandler(this.btnPembelian_Click);
			// 
			// txtSearch
			// 
			this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtSearch.Location = new System.Drawing.Point(12, 45);
			this.txtSearch.Name = "txtSearch";
			this.txtSearch.Size = new System.Drawing.Size(156, 22);
			this.txtSearch.TabIndex = 5;
			this.txtSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSearch_KeyDown);
			// 
			// btnDowngrade
			// 
			this.btnDowngrade.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnDowngrade.Location = new System.Drawing.Point(428, 12);
			this.btnDowngrade.Name = "btnDowngrade";
			this.btnDowngrade.Size = new System.Drawing.Size(101, 27);
			this.btnDowngrade.TabIndex = 6;
			this.btnDowngrade.Text = "Downgrade";
			this.btnDowngrade.UseVisualStyleBackColor = true;
			this.btnDowngrade.Click += new System.EventHandler(this.btnDowngrade_Click);
			// 
			// btnCari
			// 
			this.btnCari.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnCari.Location = new System.Drawing.Point(174, 45);
			this.btnCari.Name = "btnCari";
			this.btnCari.Size = new System.Drawing.Size(75, 25);
			this.btnCari.TabIndex = 7;
			this.btnCari.Text = "Cari";
			this.btnCari.UseVisualStyleBackColor = true;
			this.btnCari.Click += new System.EventHandler(this.btnCari_Click);
			// 
			// FormListBarang
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(870, 517);
			this.Controls.Add(this.btnCari);
			this.Controls.Add(this.btnDowngrade);
			this.Controls.Add(this.txtSearch);
			this.Controls.Add(this.btnPembelian);
			this.Controls.Add(this.btnPenyesuaianStok);
			this.Controls.Add(this.btnEdit);
			this.Controls.Add(this.btnTambah);
			this.Controls.Add(this.gridView);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "FormListBarang";
			this.Text = "List Barang";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormListBarang_FormClosing);
			this.Load += new System.EventHandler(this.FormListBarang_Load);
			((System.ComponentModel.ISupportInitialize)(this.gridView)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView gridView;
		private System.Windows.Forms.Button btnTambah;
		private System.Windows.Forms.Button btnEdit;
		private System.Windows.Forms.Button btnPenyesuaianStok;
		private System.Windows.Forms.Button btnPembelian;
		private System.Windows.Forms.TextBox txtSearch;
		private System.Windows.Forms.Button btnDowngrade;
        private System.Windows.Forms.Button btnCari;
	}
}