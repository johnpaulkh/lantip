namespace Lantip.WindowForm
{
	partial class FormPembelian
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPembelian));
			this.txtJumlahPembelian = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.btnOk = new System.Windows.Forms.Button();
			this.btnBatal = new System.Windows.Forms.Button();
			this.txtStok = new System.Windows.Forms.TextBox();
			this.txtHargaPembelian = new System.Windows.Forms.TextBox();
			this.txtNamaBarang = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.txtHargaModal = new System.Windows.Forms.TextBox();
			this.txtHargaModalBaru = new System.Windows.Forms.TextBox();
			this.txtHargaJual = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.txtJenisBarang = new System.Windows.Forms.TextBox();
			this.txtStokBaru = new System.Windows.Forms.TextBox();
			this.label9 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.txtKodeBarang = new System.Windows.Forms.TextBox();
			this.label11 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// txtJumlahPembelian
			// 
			this.txtJumlahPembelian.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtJumlahPembelian.Location = new System.Drawing.Point(165, 88);
			this.txtJumlahPembelian.Name = "txtJumlahPembelian";
			this.txtJumlahPembelian.Size = new System.Drawing.Size(150, 22);
			this.txtJumlahPembelian.TabIndex = 3;
			this.txtJumlahPembelian.TextChanged += new System.EventHandler(this.txtJumlahPembelian_TextChanged);
			this.txtJumlahPembelian.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtJumlahHargaPembelian_KeyPressed);
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(12, 90);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(51, 16);
			this.label5.TabIndex = 21;
			this.label5.Text = "Jumlah";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(12, 40);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(87, 16);
			this.label4.TabIndex = 20;
			this.label4.Text = "Jenis Barang";
			// 
			// btnOk
			// 
			this.btnOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnOk.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnOk.Location = new System.Drawing.Point(488, 308);
			this.btnOk.Name = "btnOk";
			this.btnOk.Size = new System.Drawing.Size(75, 23);
			this.btnOk.TabIndex = 10;
			this.btnOk.Text = "OK";
			this.btnOk.UseVisualStyleBackColor = true;
			this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
			// 
			// btnBatal
			// 
			this.btnBatal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnBatal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnBatal.Location = new System.Drawing.Point(407, 308);
			this.btnBatal.Name = "btnBatal";
			this.btnBatal.Size = new System.Drawing.Size(75, 23);
			this.btnBatal.TabIndex = 9;
			this.btnBatal.Text = "Batal";
			this.btnBatal.UseVisualStyleBackColor = true;
			this.btnBatal.Click += new System.EventHandler(this.btnBatal_Click);
			// 
			// txtStok
			// 
			this.txtStok.Enabled = false;
			this.txtStok.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtStok.Location = new System.Drawing.Point(165, 171);
			this.txtStok.Name = "txtStok";
			this.txtStok.Size = new System.Drawing.Size(150, 22);
			this.txtStok.TabIndex = 5;
			// 
			// txtHargaPembelian
			// 
			this.txtHargaPembelian.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtHargaPembelian.Location = new System.Drawing.Point(165, 114);
			this.txtHargaPembelian.Name = "txtHargaPembelian";
			this.txtHargaPembelian.Size = new System.Drawing.Size(150, 22);
			this.txtHargaPembelian.TabIndex = 4;
			this.txtHargaPembelian.TextChanged += new System.EventHandler(this.txtHargaPembelian_TextChanged);
			this.txtHargaPembelian.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtJumlahHargaPembelian_KeyPressed);
			// 
			// txtNamaBarang
			// 
			this.txtNamaBarang.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txtNamaBarang.Enabled = false;
			this.txtNamaBarang.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtNamaBarang.Location = new System.Drawing.Point(165, 12);
			this.txtNamaBarang.Name = "txtNamaBarang";
			this.txtNamaBarang.Size = new System.Drawing.Size(398, 22);
			this.txtNamaBarang.TabIndex = 1;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(12, 174);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(35, 16);
			this.label3.TabIndex = 16;
			this.label3.Text = "Stok";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(12, 116);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(146, 16);
			this.label2.TabIndex = 14;
			this.label2.Text = "Harga Pembelian (Rp.)";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(12, 11);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(92, 16);
			this.label1.TabIndex = 12;
			this.label1.Text = "Nama Barang";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(12, 200);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(119, 16);
			this.label6.TabIndex = 24;
			this.label6.Text = "Harga Modal (Rp.)";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.Location = new System.Drawing.Point(12, 247);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(150, 16);
			this.label7.TabIndex = 25;
			this.label7.Text = "Harga Modal Baru (Rp.)";
			// 
			// txtHargaModal
			// 
			this.txtHargaModal.Enabled = false;
			this.txtHargaModal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtHargaModal.Location = new System.Drawing.Point(165, 197);
			this.txtHargaModal.Name = "txtHargaModal";
			this.txtHargaModal.Size = new System.Drawing.Size(150, 22);
			this.txtHargaModal.TabIndex = 6;
			// 
			// txtHargaModalBaru
			// 
			this.txtHargaModalBaru.Enabled = false;
			this.txtHargaModalBaru.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtHargaModalBaru.Location = new System.Drawing.Point(165, 246);
			this.txtHargaModalBaru.Name = "txtHargaModalBaru";
			this.txtHargaModalBaru.Size = new System.Drawing.Size(150, 22);
			this.txtHargaModalBaru.TabIndex = 7;
			// 
			// txtHargaJual
			// 
			this.txtHargaJual.Enabled = false;
			this.txtHargaJual.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtHargaJual.Location = new System.Drawing.Point(165, 272);
			this.txtHargaJual.Name = "txtHargaJual";
			this.txtHargaJual.Size = new System.Drawing.Size(150, 22);
			this.txtHargaJual.TabIndex = 8;
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.Location = new System.Drawing.Point(12, 275);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(74, 16);
			this.label8.TabIndex = 29;
			this.label8.Text = "Harga Jual";
			// 
			// txtJenisBarang
			// 
			this.txtJenisBarang.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txtJenisBarang.Enabled = false;
			this.txtJenisBarang.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtJenisBarang.Location = new System.Drawing.Point(165, 39);
			this.txtJenisBarang.Name = "txtJenisBarang";
			this.txtJenisBarang.Size = new System.Drawing.Size(398, 22);
			this.txtJenisBarang.TabIndex = 2;
			// 
			// txtStokBaru
			// 
			this.txtStokBaru.Enabled = false;
			this.txtStokBaru.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtStokBaru.Location = new System.Drawing.Point(165, 223);
			this.txtStokBaru.Name = "txtStokBaru";
			this.txtStokBaru.Size = new System.Drawing.Size(150, 22);
			this.txtStokBaru.TabIndex = 7;
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label9.Location = new System.Drawing.Point(12, 226);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(66, 16);
			this.label9.TabIndex = 31;
			this.label9.Text = "Stok Baru";
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label10.Location = new System.Drawing.Point(12, 152);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(159, 16);
			this.label10.TabIndex = 32;
			this.label10.Text = "Informasi Stok dan Harga";
			// 
			// txtKodeBarang
			// 
			this.txtKodeBarang.Enabled = false;
			this.txtKodeBarang.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtKodeBarang.Location = new System.Drawing.Point(165, 65);
			this.txtKodeBarang.Name = "txtKodeBarang";
			this.txtKodeBarang.Size = new System.Drawing.Size(150, 22);
			this.txtKodeBarang.TabIndex = 34;
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label11.Location = new System.Drawing.Point(11, 68);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(87, 16);
			this.label11.TabIndex = 33;
			this.label11.Text = "Kode Barang";
			// 
			// FormPembelian
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(575, 343);
			this.Controls.Add(this.txtKodeBarang);
			this.Controls.Add(this.label11);
			this.Controls.Add(this.label10);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.txtStokBaru);
			this.Controls.Add(this.txtJenisBarang);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.txtHargaJual);
			this.Controls.Add(this.txtHargaModalBaru);
			this.Controls.Add(this.txtHargaModal);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.txtJumlahPembelian);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.btnOk);
			this.Controls.Add(this.btnBatal);
			this.Controls.Add(this.txtStok);
			this.Controls.Add(this.txtHargaPembelian);
			this.Controls.Add(this.txtNamaBarang);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "FormPembelian";
			this.Text = "Pembelian";
			this.Load += new System.EventHandler(this.FormPembelian_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox txtJumlahPembelian;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Button btnOk;
		private System.Windows.Forms.Button btnBatal;
		private System.Windows.Forms.TextBox txtStok;
		private System.Windows.Forms.TextBox txtHargaPembelian;
		private System.Windows.Forms.TextBox txtNamaBarang;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox txtHargaModal;
		private System.Windows.Forms.TextBox txtHargaModalBaru;
		private System.Windows.Forms.TextBox txtHargaJual;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.TextBox txtJenisBarang;
		private System.Windows.Forms.TextBox txtStokBaru;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.TextBox txtKodeBarang;
		private System.Windows.Forms.Label label11;
	}
}