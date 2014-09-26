namespace Lantip.WindowForm
{
    partial class FormDaftarBarang
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDaftarBarang));
			this.gridView = new System.Windows.Forms.DataGridView();
			this.txtSearch = new System.Windows.Forms.TextBox();
			this.btnCari = new System.Windows.Forms.Button();
			this.btnUbahHargaBarang = new System.Windows.Forms.Button();
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
			this.gridView.Location = new System.Drawing.Point(12, 40);
			this.gridView.Name = "gridView";
			this.gridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.gridView.Size = new System.Drawing.Size(823, 439);
			this.gridView.TabIndex = 0;
			// 
			// txtSearch
			// 
			this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtSearch.Location = new System.Drawing.Point(14, 7);
			this.txtSearch.Name = "txtSearch";
			this.txtSearch.Size = new System.Drawing.Size(228, 22);
			this.txtSearch.TabIndex = 1;
			this.txtSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCari_KeyDown);
			// 
			// btnCari
			// 
			this.btnCari.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnCari.Location = new System.Drawing.Point(248, 3);
			this.btnCari.Name = "btnCari";
			this.btnCari.Size = new System.Drawing.Size(75, 31);
			this.btnCari.TabIndex = 2;
			this.btnCari.Text = "Cari";
			this.btnCari.UseVisualStyleBackColor = true;
			this.btnCari.Click += new System.EventHandler(this.btnCari_Click);
			// 
			// btnUbahHargaBarang
			// 
			this.btnUbahHargaBarang.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnUbahHargaBarang.Location = new System.Drawing.Point(686, 3);
			this.btnUbahHargaBarang.Name = "btnUbahHargaBarang";
			this.btnUbahHargaBarang.Size = new System.Drawing.Size(149, 31);
			this.btnUbahHargaBarang.TabIndex = 3;
			this.btnUbahHargaBarang.Text = "Ubah Harga Barang";
			this.btnUbahHargaBarang.UseVisualStyleBackColor = true;
			this.btnUbahHargaBarang.Click += new System.EventHandler(this.btnUbahHargaBarang_Click);
			// 
			// FormDaftarBarang
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(847, 491);
			this.Controls.Add(this.btnUbahHargaBarang);
			this.Controls.Add(this.btnCari);
			this.Controls.Add(this.txtSearch);
			this.Controls.Add(this.gridView);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "FormDaftarBarang";
			this.Text = "Daftar Barang";
			this.Load += new System.EventHandler(this.FormDaftarBarang_Load);
			((System.ComponentModel.ISupportInitialize)(this.gridView)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gridView;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnCari;
		private System.Windows.Forms.Button btnUbahHargaBarang;
    }
}