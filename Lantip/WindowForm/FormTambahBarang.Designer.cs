namespace Lantip.WindowForm
{
    partial class FormTambahBarang
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTambahBarang));
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.txtNamaBarang = new System.Windows.Forms.TextBox();
			this.txtHargaModal = new System.Windows.Forms.TextBox();
			this.txtHargaJual = new System.Windows.Forms.TextBox();
			this.btnBatal = new System.Windows.Forms.Button();
			this.btnOk = new System.Windows.Forms.Button();
			this.label4 = new System.Windows.Forms.Label();
			this.cmbJenisBarang = new System.Windows.Forms.ComboBox();
			this.label5 = new System.Windows.Forms.Label();
			this.txtStok = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.txtKodeBarang = new System.Windows.Forms.TextBox();
			this.chkBarangDG = new System.Windows.Forms.CheckBox();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(12, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(92, 16);
			this.label1.TabIndex = 0;
			this.label1.Text = "Nama Barang";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(12, 121);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(119, 16);
			this.label2.TabIndex = 1;
			this.label2.Text = "Harga Modal (Rp.)";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(12, 147);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(106, 16);
			this.label3.TabIndex = 2;
			this.label3.Text = "Harga Jual (Rp.)";
			// 
			// txtNamaBarang
			// 
			this.txtNamaBarang.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txtNamaBarang.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtNamaBarang.Location = new System.Drawing.Point(132, 9);
			this.txtNamaBarang.Name = "txtNamaBarang";
			this.txtNamaBarang.Size = new System.Drawing.Size(350, 22);
			this.txtNamaBarang.TabIndex = 1;
			// 
			// txtHargaModal
			// 
			this.txtHargaModal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtHargaModal.Location = new System.Drawing.Point(132, 118);
			this.txtHargaModal.Name = "txtHargaModal";
			this.txtHargaModal.Size = new System.Drawing.Size(150, 22);
			this.txtHargaModal.TabIndex = 4;
			this.txtHargaModal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtHargaModal_KeyPress);
			// 
			// txtHargaJual
			// 
			this.txtHargaJual.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtHargaJual.Location = new System.Drawing.Point(132, 144);
			this.txtHargaJual.Name = "txtHargaJual";
			this.txtHargaJual.Size = new System.Drawing.Size(150, 22);
			this.txtHargaJual.TabIndex = 5;
			this.txtHargaJual.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtHargaJual_KeyPress);
			// 
			// btnBatal
			// 
			this.btnBatal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnBatal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnBatal.Location = new System.Drawing.Point(326, 235);
			this.btnBatal.Name = "btnBatal";
			this.btnBatal.Size = new System.Drawing.Size(75, 23);
			this.btnBatal.TabIndex = 11;
			this.btnBatal.Text = "Batal";
			this.btnBatal.UseVisualStyleBackColor = true;
			this.btnBatal.Click += new System.EventHandler(this.btnBatal_Click);
			// 
			// btnOk
			// 
			this.btnOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnOk.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnOk.Location = new System.Drawing.Point(407, 235);
			this.btnOk.Name = "btnOk";
			this.btnOk.Size = new System.Drawing.Size(75, 23);
			this.btnOk.TabIndex = 10;
			this.btnOk.Text = "OK";
			this.btnOk.UseVisualStyleBackColor = true;
			this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(12, 38);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(87, 16);
			this.label4.TabIndex = 8;
			this.label4.Text = "Jenis Barang";
			// 
			// cmbJenisBarang
			// 
			this.cmbJenisBarang.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
			this.cmbJenisBarang.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
			this.cmbJenisBarang.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cmbJenisBarang.FormattingEnabled = true;
			this.cmbJenisBarang.Location = new System.Drawing.Point(132, 35);
			this.cmbJenisBarang.Name = "cmbJenisBarang";
			this.cmbJenisBarang.Size = new System.Drawing.Size(255, 24);
			this.cmbJenisBarang.TabIndex = 2;
			this.cmbJenisBarang.SelectedIndexChanged += new System.EventHandler(this.cmbJenisBarang_SelectedIndexChanged);
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(12, 95);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(35, 16);
			this.label5.TabIndex = 9;
			this.label5.Text = "Stok";
			// 
			// txtStok
			// 
			this.txtStok.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtStok.Location = new System.Drawing.Point(132, 92);
			this.txtStok.Name = "txtStok";
			this.txtStok.Size = new System.Drawing.Size(150, 22);
			this.txtStok.TabIndex = 3;
			this.txtStok.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtStok_KeyPress);
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(12, 69);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(87, 16);
			this.label6.TabIndex = 12;
			this.label6.Text = "Kode Barang";
			// 
			// txtKodeBarang
			// 
			this.txtKodeBarang.Enabled = false;
			this.txtKodeBarang.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtKodeBarang.Location = new System.Drawing.Point(132, 66);
			this.txtKodeBarang.Name = "txtKodeBarang";
			this.txtKodeBarang.Size = new System.Drawing.Size(150, 22);
			this.txtKodeBarang.TabIndex = 13;
			// 
			// chkBarangDG
			// 
			this.chkBarangDG.AutoSize = true;
			this.chkBarangDG.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.chkBarangDG.Location = new System.Drawing.Point(132, 170);
			this.chkBarangDG.Name = "chkBarangDG";
			this.chkBarangDG.Size = new System.Drawing.Size(252, 52);
			this.chkBarangDG.TabIndex = 14;
			this.chkBarangDG.Text = "Buat Barang Downgrade?\r\n(Jangan pilih ini bila sedang membuat\r\nbarang downgrade s" +
    "ecara manual)";
			this.chkBarangDG.UseVisualStyleBackColor = true;
			// 
			// FormTambahBarang
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(493, 270);
			this.Controls.Add(this.chkBarangDG);
			this.Controls.Add(this.txtKodeBarang);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.txtStok);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.cmbJenisBarang);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.btnOk);
			this.Controls.Add(this.btnBatal);
			this.Controls.Add(this.txtHargaJual);
			this.Controls.Add(this.txtHargaModal);
			this.Controls.Add(this.txtNamaBarang);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "FormTambahBarang";
			this.Text = "Tambah Barang";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormDaftarBarangBaru_FormClosed);
			this.Load += new System.EventHandler(this.FormTambahBarang_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNamaBarang;
        private System.Windows.Forms.TextBox txtHargaModal;
        private System.Windows.Forms.TextBox txtHargaJual;
        private System.Windows.Forms.Button btnBatal;
        private System.Windows.Forms.Button btnOk;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.ComboBox cmbJenisBarang;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox txtStok;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox txtKodeBarang;
		private System.Windows.Forms.CheckBox chkBarangDG;
    }
}