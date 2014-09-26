namespace Lantip.WindowForm
{
	partial class FormTambahJenisBarang
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTambahJenisBarang));
			this.label1 = new System.Windows.Forms.Label();
			this.txtNamaJenisBarang = new System.Windows.Forms.TextBox();
			this.btnBatal = new System.Windows.Forms.Button();
			this.btnOK = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(12, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(127, 16);
			this.label1.TabIndex = 0;
			this.label1.Text = "Nama Jenis Barang";
			// 
			// txtNamaJenisBarang
			// 
			this.txtNamaJenisBarang.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtNamaJenisBarang.Location = new System.Drawing.Point(145, 6);
			this.txtNamaJenisBarang.Name = "txtNamaJenisBarang";
			this.txtNamaJenisBarang.Size = new System.Drawing.Size(217, 22);
			this.txtNamaJenisBarang.TabIndex = 2;
			// 
			// btnBatal
			// 
			this.btnBatal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnBatal.Location = new System.Drawing.Point(206, 34);
			this.btnBatal.Name = "btnBatal";
			this.btnBatal.Size = new System.Drawing.Size(75, 23);
			this.btnBatal.TabIndex = 4;
			this.btnBatal.Text = "Batal";
			this.btnBatal.UseVisualStyleBackColor = true;
			this.btnBatal.Click += new System.EventHandler(this.btnBatal_Click);
			// 
			// btnOK
			// 
			this.btnOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnOK.Location = new System.Drawing.Point(287, 34);
			this.btnOK.Name = "btnOK";
			this.btnOK.Size = new System.Drawing.Size(75, 23);
			this.btnOK.TabIndex = 5;
			this.btnOK.Text = "OK";
			this.btnOK.UseVisualStyleBackColor = true;
			this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
			// 
			// FormTambahJenisBarang
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(370, 64);
			this.Controls.Add(this.btnOK);
			this.Controls.Add(this.btnBatal);
			this.Controls.Add(this.txtNamaJenisBarang);
			this.Controls.Add(this.label1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "FormTambahJenisBarang";
			this.Text = "Tambah Jenis Barang";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormTambahJenisBarang_FormClosed);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtNamaJenisBarang;
		private System.Windows.Forms.Button btnBatal;
		private System.Windows.Forms.Button btnOK;
	}
}