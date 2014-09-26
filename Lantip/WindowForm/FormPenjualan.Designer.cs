namespace Lantip.WindowForm
{
	partial class FormPenjualan
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPenjualan));
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.dtPicker = new System.Windows.Forms.DateTimePicker();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.txtCariBarang = new System.Windows.Forms.TextBox();
			this.txtKodeBarang = new System.Windows.Forms.TextBox();
			this.txtNamaBarang = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.txtHarga = new System.Windows.Forms.TextBox();
			this.gridView = new System.Windows.Forms.DataGridView();
			this.btnBatal = new System.Windows.Forms.Button();
			this.btnOK = new System.Windows.Forms.Button();
			this.label7 = new System.Windows.Forms.Label();
			this.txtJumlah = new System.Windows.Forms.TextBox();
			this.btnTambah = new System.Windows.Forms.Button();
			this.btnCari = new System.Windows.Forms.Button();
			this.label8 = new System.Windows.Forms.Label();
			this.txtShift = new System.Windows.Forms.TextBox();
			this.label9 = new System.Windows.Forms.Label();
			this.txtNama = new System.Windows.Forms.TextBox();
			this.label10 = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
			this.txtSubtotal = new System.Windows.Forms.TextBox();
			this.txtBayar = new System.Windows.Forms.TextBox();
			this.label12 = new System.Windows.Forms.Label();
			this.txtKembali = new System.Windows.Forms.TextBox();
			((System.ComponentModel.ISupportInitialize)(this.gridView)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(12, 60);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(59, 16);
			this.label1.TabIndex = 0;
			this.label1.Text = "Tanggal";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(12, 86);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(79, 16);
			this.label2.TabIndex = 1;
			this.label2.Text = "Cari Barang";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(12, 112);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(87, 16);
			this.label3.TabIndex = 2;
			this.label3.Text = "Kode Barang";
			// 
			// dtPicker
			// 
			this.dtPicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dtPicker.Location = new System.Drawing.Point(106, 58);
			this.dtPicker.Name = "dtPicker";
			this.dtPicker.Size = new System.Drawing.Size(200, 22);
			this.dtPicker.TabIndex = 3;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(13, 238);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(73, 13);
			this.label4.TabIndex = 4;
			this.label4.Text = "Daftar Barang";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(12, 138);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(92, 16);
			this.label5.TabIndex = 5;
			this.label5.Text = "Nama Barang";
			// 
			// txtCariBarang
			// 
			this.txtCariBarang.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
			this.txtCariBarang.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
			this.txtCariBarang.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtCariBarang.Location = new System.Drawing.Point(106, 84);
			this.txtCariBarang.Name = "txtCariBarang";
			this.txtCariBarang.Size = new System.Drawing.Size(200, 22);
			this.txtCariBarang.TabIndex = 6;
			this.txtCariBarang.TextChanged += new System.EventHandler(this.txtCariBarang_TextChanged);
			this.txtCariBarang.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCariBarang_KeyDown);
			// 
			// txtKodeBarang
			// 
			this.txtKodeBarang.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtKodeBarang.Location = new System.Drawing.Point(106, 110);
			this.txtKodeBarang.Name = "txtKodeBarang";
			this.txtKodeBarang.Size = new System.Drawing.Size(200, 22);
			this.txtKodeBarang.TabIndex = 6;
			this.txtKodeBarang.TextChanged += new System.EventHandler(this.txtKodeBarang_TextChanged);
			// 
			// txtNamaBarang
			// 
			this.txtNamaBarang.Enabled = false;
			this.txtNamaBarang.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtNamaBarang.Location = new System.Drawing.Point(106, 136);
			this.txtNamaBarang.Name = "txtNamaBarang";
			this.txtNamaBarang.Size = new System.Drawing.Size(200, 22);
			this.txtNamaBarang.TabIndex = 8;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(12, 164);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(46, 16);
			this.label6.TabIndex = 9;
			this.label6.Text = "Harga";
			// 
			// txtHarga
			// 
			this.txtHarga.Enabled = false;
			this.txtHarga.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtHarga.Location = new System.Drawing.Point(106, 161);
			this.txtHarga.Name = "txtHarga";
			this.txtHarga.Size = new System.Drawing.Size(200, 22);
			this.txtHarga.TabIndex = 10;
			// 
			// gridView
			// 
			this.gridView.AllowUserToAddRows = false;
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
			this.gridView.Location = new System.Drawing.Point(15, 225);
			this.gridView.Name = "gridView";
			this.gridView.ReadOnly = true;
			this.gridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.gridView.Size = new System.Drawing.Size(703, 149);
			this.gridView.TabIndex = 100;
			// 
			// btnBatal
			// 
			this.btnBatal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnBatal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnBatal.Location = new System.Drawing.Point(562, 477);
			this.btnBatal.Name = "btnBatal";
			this.btnBatal.Size = new System.Drawing.Size(75, 23);
			this.btnBatal.TabIndex = 20;
			this.btnBatal.Text = "Batal";
			this.btnBatal.UseVisualStyleBackColor = true;
			this.btnBatal.Click += new System.EventHandler(this.btnBatal_Click);
			// 
			// btnOK
			// 
			this.btnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnOK.Location = new System.Drawing.Point(643, 477);
			this.btnOK.Name = "btnOK";
			this.btnOK.Size = new System.Drawing.Size(75, 23);
			this.btnOK.TabIndex = 21;
			this.btnOK.Text = "OK";
			this.btnOK.UseVisualStyleBackColor = true;
			this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.Location = new System.Drawing.Point(13, 190);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(51, 16);
			this.label7.TabIndex = 14;
			this.label7.Text = "Jumlah";
			// 
			// txtJumlah
			// 
			this.txtJumlah.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtJumlah.Location = new System.Drawing.Point(106, 187);
			this.txtJumlah.Name = "txtJumlah";
			this.txtJumlah.Size = new System.Drawing.Size(200, 22);
			this.txtJumlah.TabIndex = 15;
			this.txtJumlah.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtJumlah_KeyDown);
			this.txtJumlah.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtJumlah_KeyPress);
			// 
			// btnTambah
			// 
			this.btnTambah.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnTambah.Location = new System.Drawing.Point(312, 185);
			this.btnTambah.Name = "btnTambah";
			this.btnTambah.Size = new System.Drawing.Size(75, 23);
			this.btnTambah.TabIndex = 22;
			this.btnTambah.Text = "Tambah";
			this.btnTambah.UseVisualStyleBackColor = true;
			this.btnTambah.Click += new System.EventHandler(this.btnTambah_Click);
			// 
			// btnCari
			// 
			this.btnCari.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnCari.Location = new System.Drawing.Point(312, 82);
			this.btnCari.Name = "btnCari";
			this.btnCari.Size = new System.Drawing.Size(75, 23);
			this.btnCari.TabIndex = 23;
			this.btnCari.Text = "Cari";
			this.btnCari.UseVisualStyleBackColor = true;
			this.btnCari.Click += new System.EventHandler(this.btnCari_Click);
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.Location = new System.Drawing.Point(12, 9);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(33, 16);
			this.label8.TabIndex = 24;
			this.label8.Text = "Shift";
			// 
			// txtShift
			// 
			this.txtShift.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtShift.Location = new System.Drawing.Point(106, 6);
			this.txtShift.Name = "txtShift";
			this.txtShift.Size = new System.Drawing.Size(43, 22);
			this.txtShift.TabIndex = 25;
			this.txtShift.Text = "1";
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label9.Location = new System.Drawing.Point(13, 35);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(45, 16);
			this.label9.TabIndex = 26;
			this.label9.Text = "Nama";
			// 
			// txtNama
			// 
			this.txtNama.Enabled = false;
			this.txtNama.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtNama.Location = new System.Drawing.Point(106, 32);
			this.txtNama.Name = "txtNama";
			this.txtNama.Size = new System.Drawing.Size(100, 22);
			this.txtNama.TabIndex = 27;
			// 
			// label10
			// 
			this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.label10.AutoSize = true;
			this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label10.ForeColor = System.Drawing.Color.Black;
			this.label10.Location = new System.Drawing.Point(12, 380);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(77, 20);
			this.label10.TabIndex = 101;
			this.label10.Text = "Subtotal";
			// 
			// label11
			// 
			this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.label11.AutoSize = true;
			this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label11.ForeColor = System.Drawing.Color.Red;
			this.label11.Location = new System.Drawing.Point(12, 406);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(55, 20);
			this.label11.TabIndex = 102;
			this.label11.Text = "Bayar";
			// 
			// txtSubtotal
			// 
			this.txtSubtotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.txtSubtotal.Enabled = false;
			this.txtSubtotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtSubtotal.Location = new System.Drawing.Point(95, 380);
			this.txtSubtotal.Name = "txtSubtotal";
			this.txtSubtotal.Size = new System.Drawing.Size(200, 22);
			this.txtSubtotal.TabIndex = 23;
			// 
			// txtBayar
			// 
			this.txtBayar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.txtBayar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtBayar.Location = new System.Drawing.Point(95, 406);
			this.txtBayar.Name = "txtBayar";
			this.txtBayar.Size = new System.Drawing.Size(200, 22);
			this.txtBayar.TabIndex = 16;
			this.txtBayar.TextChanged += new System.EventHandler(this.txtBayar_TextChanged);
			this.txtBayar.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBayar_KeyDown);
			// 
			// label12
			// 
			this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.label12.AutoSize = true;
			this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label12.ForeColor = System.Drawing.Color.Red;
			this.label12.Location = new System.Drawing.Point(12, 430);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(72, 20);
			this.label12.TabIndex = 103;
			this.label12.Text = "Kembali";
			// 
			// txtKembali
			// 
			this.txtKembali.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.txtKembali.Enabled = false;
			this.txtKembali.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtKembali.Location = new System.Drawing.Point(95, 432);
			this.txtKembali.Name = "txtKembali";
			this.txtKembali.Size = new System.Drawing.Size(200, 22);
			this.txtKembali.TabIndex = 104;
			// 
			// FormPenjualan
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(730, 512);
			this.Controls.Add(this.txtKembali);
			this.Controls.Add(this.label12);
			this.Controls.Add(this.txtBayar);
			this.Controls.Add(this.txtSubtotal);
			this.Controls.Add(this.label11);
			this.Controls.Add(this.label10);
			this.Controls.Add(this.txtNama);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.txtShift);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.btnCari);
			this.Controls.Add(this.btnTambah);
			this.Controls.Add(this.txtJumlah);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.btnOK);
			this.Controls.Add(this.btnBatal);
			this.Controls.Add(this.gridView);
			this.Controls.Add(this.txtHarga);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.txtNamaBarang);
			this.Controls.Add(this.txtKodeBarang);
			this.Controls.Add(this.txtCariBarang);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.dtPicker);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "FormPenjualan";
			this.Text = "FormPenjualan";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormPenjualan_FormClosed);
			this.Load += new System.EventHandler(this.FormPenjualan_Load);
			((System.ComponentModel.ISupportInitialize)(this.gridView)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.DateTimePicker dtPicker;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox txtCariBarang;
		private System.Windows.Forms.TextBox txtKodeBarang;
		private System.Windows.Forms.TextBox txtNamaBarang;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox txtHarga;
		private System.Windows.Forms.DataGridView gridView;
		private System.Windows.Forms.Button btnBatal;
		private System.Windows.Forms.Button btnOK;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox txtJumlah;
		private System.Windows.Forms.Button btnTambah;
		private System.Windows.Forms.Button btnCari;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.TextBox txtShift;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.TextBox txtNama;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.TextBox txtSubtotal;
		private System.Windows.Forms.TextBox txtBayar;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtKembali;
	}
}