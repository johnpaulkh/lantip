namespace Lantip.WindowForm
{
    partial class FormHome
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormHome));
			this.homeMenuStrip = new System.Windows.Forms.MenuStrip();
			this.stokToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.barangToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.jenisBarangToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.penjualanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.dataPenjualanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.daftarBarangToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.homeMenuStrip.SuspendLayout();
			this.SuspendLayout();
			// 
			// homeMenuStrip
			// 
			this.homeMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stokToolStripMenuItem,
            this.penjualanToolStripMenuItem,
            this.dataPenjualanToolStripMenuItem,
            this.daftarBarangToolStripMenuItem});
			this.homeMenuStrip.Location = new System.Drawing.Point(0, 0);
			this.homeMenuStrip.Name = "homeMenuStrip";
			this.homeMenuStrip.Size = new System.Drawing.Size(910, 24);
			this.homeMenuStrip.TabIndex = 0;
			this.homeMenuStrip.Text = "menuStrip1";
			// 
			// stokToolStripMenuItem
			// 
			this.stokToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.barangToolStripMenuItem,
            this.jenisBarangToolStripMenuItem});
			this.stokToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.stokToolStripMenuItem.Name = "stokToolStripMenuItem";
			this.stokToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
			this.stokToolStripMenuItem.Text = "Stok";
			// 
			// barangToolStripMenuItem
			// 
			this.barangToolStripMenuItem.Name = "barangToolStripMenuItem";
			this.barangToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
			this.barangToolStripMenuItem.Text = "Barang";
			this.barangToolStripMenuItem.Click += new System.EventHandler(this.barangToolStripMenuItem_Click);
			// 
			// jenisBarangToolStripMenuItem
			// 
			this.jenisBarangToolStripMenuItem.Name = "jenisBarangToolStripMenuItem";
			this.jenisBarangToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
			this.jenisBarangToolStripMenuItem.Text = "Jenis Barang";
			this.jenisBarangToolStripMenuItem.Click += new System.EventHandler(this.jenisBarangToolStripMenuItem_Click);
			// 
			// penjualanToolStripMenuItem
			// 
			this.penjualanToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.penjualanToolStripMenuItem.Name = "penjualanToolStripMenuItem";
			this.penjualanToolStripMenuItem.Size = new System.Drawing.Size(80, 20);
			this.penjualanToolStripMenuItem.Text = "Penjualan";
			this.penjualanToolStripMenuItem.Click += new System.EventHandler(this.penjualanToolStripMenuItem_Click);
			// 
			// dataPenjualanToolStripMenuItem
			// 
			this.dataPenjualanToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dataPenjualanToolStripMenuItem.Name = "dataPenjualanToolStripMenuItem";
			this.dataPenjualanToolStripMenuItem.Size = new System.Drawing.Size(112, 20);
			this.dataPenjualanToolStripMenuItem.Text = "Data Penjualan";
			this.dataPenjualanToolStripMenuItem.Click += new System.EventHandler(this.dataPenjualanToolStripMenuItem_Click_1);
			// 
			// daftarBarangToolStripMenuItem
			// 
			this.daftarBarangToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.daftarBarangToolStripMenuItem.Name = "daftarBarangToolStripMenuItem";
			this.daftarBarangToolStripMenuItem.Size = new System.Drawing.Size(103, 20);
			this.daftarBarangToolStripMenuItem.Text = "Daftar Barang";
			this.daftarBarangToolStripMenuItem.Click += new System.EventHandler(this.daftarBarangToolStripMenuItem_Click);
			// 
			// FormHome
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(910, 521);
			this.Controls.Add(this.homeMenuStrip);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.IsMdiContainer = true;
			this.MainMenuStrip = this.homeMenuStrip;
			this.Name = "FormHome";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Aplikasi Fresh Mart";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.Load += new System.EventHandler(this.FormHome_Load);
			this.homeMenuStrip.ResumeLayout(false);
			this.homeMenuStrip.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip homeMenuStrip;
		private System.Windows.Forms.ToolStripMenuItem stokToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem barangToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem jenisBarangToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem penjualanToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem dataPenjualanToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem daftarBarangToolStripMenuItem;
    }
}

