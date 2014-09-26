namespace Lantip.WindowForm
{
	partial class FormEditBarang
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEditBarang));
			this.txtStok = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.cmbJenisBarang = new System.Windows.Forms.ComboBox();
			this.label4 = new System.Windows.Forms.Label();
			this.btnOk = new System.Windows.Forms.Button();
			this.btnBatal = new System.Windows.Forms.Button();
			this.txtHargaJual = new System.Windows.Forms.TextBox();
			this.txtHargaModal = new System.Windows.Forms.TextBox();
			this.txtNamaBarang = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.lblHargaModal = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.txtKodeBarang = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// txtStok
			// 
			this.txtStok.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtStok.Location = new System.Drawing.Point(132, 88);
			this.txtStok.Name = "txtStok";
			this.txtStok.Size = new System.Drawing.Size(149, 22);
			this.txtStok.TabIndex = 17;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(13, 91);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(35, 16);
			this.label5.TabIndex = 21;
			this.label5.Text = "Stok";
			// 
			// cmbJenisBarang
			// 
			this.cmbJenisBarang.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
			this.cmbJenisBarang.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
			this.cmbJenisBarang.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cmbJenisBarang.FormattingEnabled = true;
			this.cmbJenisBarang.Location = new System.Drawing.Point(131, 35);
			this.cmbJenisBarang.Name = "cmbJenisBarang";
			this.cmbJenisBarang.Size = new System.Drawing.Size(239, 24);
			this.cmbJenisBarang.TabIndex = 15;
			this.cmbJenisBarang.SelectedIndexChanged += new System.EventHandler(this.cmbJenisBarang_SelectedIndexChanged);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(12, 38);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(87, 16);
			this.label4.TabIndex = 20;
			this.label4.Text = "Jenis Barang";
			// 
			// btnOk
			// 
			this.btnOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnOk.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnOk.Location = new System.Drawing.Point(423, 175);
			this.btnOk.Name = "btnOk";
			this.btnOk.Size = new System.Drawing.Size(75, 23);
			this.btnOk.TabIndex = 22;
			this.btnOk.Text = "OK";
			this.btnOk.UseVisualStyleBackColor = true;
			this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
			// 
			// btnBatal
			// 
			this.btnBatal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnBatal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnBatal.Location = new System.Drawing.Point(342, 175);
			this.btnBatal.Name = "btnBatal";
			this.btnBatal.Size = new System.Drawing.Size(75, 23);
			this.btnBatal.TabIndex = 23;
			this.btnBatal.Text = "Batal";
			this.btnBatal.UseVisualStyleBackColor = true;
			this.btnBatal.Click += new System.EventHandler(this.btnBatal_Click);
			// 
			// txtHargaJual
			// 
			this.txtHargaJual.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtHargaJual.Location = new System.Drawing.Point(132, 140);
			this.txtHargaJual.Name = "txtHargaJual";
			this.txtHargaJual.Size = new System.Drawing.Size(149, 22);
			this.txtHargaJual.TabIndex = 19;
			this.txtHargaJual.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtHargaJual_KeyPress);
			// 
			// txtHargaModal
			// 
			this.txtHargaModal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtHargaModal.Location = new System.Drawing.Point(132, 114);
			this.txtHargaModal.Name = "txtHargaModal";
			this.txtHargaModal.Size = new System.Drawing.Size(149, 22);
			this.txtHargaModal.TabIndex = 18;
			this.txtHargaModal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtHargaModal_KeyPress);
			// 
			// txtNamaBarang
			// 
			this.txtNamaBarang.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txtNamaBarang.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtNamaBarang.Location = new System.Drawing.Point(131, 9);
			this.txtNamaBarang.Name = "txtNamaBarang";
			this.txtNamaBarang.Size = new System.Drawing.Size(367, 22);
			this.txtNamaBarang.TabIndex = 13;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(13, 143);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(106, 16);
			this.label3.TabIndex = 16;
			this.label3.Text = "Harga Jual (Rp.)";
			// 
			// lblHargaModal
			// 
			this.lblHargaModal.AutoSize = true;
			this.lblHargaModal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblHargaModal.Location = new System.Drawing.Point(13, 117);
			this.lblHargaModal.Name = "lblHargaModal";
			this.lblHargaModal.Size = new System.Drawing.Size(119, 16);
			this.lblHargaModal.TabIndex = 14;
			this.lblHargaModal.Text = "Harga Modal (Rp.)";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(12, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(92, 16);
			this.label1.TabIndex = 12;
			this.label1.Text = "Nama Barang";
			// 
			// txtKodeBarang
			// 
			this.txtKodeBarang.Enabled = false;
			this.txtKodeBarang.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtKodeBarang.Location = new System.Drawing.Point(131, 62);
			this.txtKodeBarang.Name = "txtKodeBarang";
			this.txtKodeBarang.Size = new System.Drawing.Size(150, 22);
			this.txtKodeBarang.TabIndex = 26;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.Location = new System.Drawing.Point(11, 65);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(87, 16);
			this.label7.TabIndex = 25;
			this.label7.Text = "Kode Barang";
			// 
			// FormEditBarang
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(505, 210);
			this.Controls.Add(this.txtKodeBarang);
			this.Controls.Add(this.label7);
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
			this.Controls.Add(this.lblHargaModal);
			this.Controls.Add(this.label1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "FormEditBarang";
			this.Text = "Edit Barang";
			this.Load += new System.EventHandler(this.FormEditBarang_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox txtStok;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.ComboBox cmbJenisBarang;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Button btnOk;
		private System.Windows.Forms.Button btnBatal;
		private System.Windows.Forms.TextBox txtHargaJual;
		private System.Windows.Forms.TextBox txtHargaModal;
		private System.Windows.Forms.TextBox txtNamaBarang;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label lblHargaModal;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtKodeBarang;
		private System.Windows.Forms.Label label7;
	}
}