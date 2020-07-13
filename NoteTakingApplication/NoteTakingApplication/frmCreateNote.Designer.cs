namespace NoteTakingApplication
{
	partial class frmCreateNote
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCreateNote));
			this.lbTieuDe = new System.Windows.Forms.Label();
			this.lbNoiDung = new System.Windows.Forms.Label();
			this.txtTieuDe = new System.Windows.Forms.TextBox();
			this.lb1 = new System.Windows.Forms.TextBox();
			this.btnCreateNew = new System.Windows.Forms.Button();
			this.btnSave = new System.Windows.Forms.Button();
			this.btnRead = new System.Windows.Forms.Button();
			this.btnDelete = new System.Windows.Forms.Button();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.lbGhiChuCua = new System.Windows.Forms.Label();
			this.lbName = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// lbTieuDe
			// 
			this.lbTieuDe.AutoSize = true;
			this.lbTieuDe.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbTieuDe.Location = new System.Drawing.Point(39, 73);
			this.lbTieuDe.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
			this.lbTieuDe.Name = "lbTieuDe";
			this.lbTieuDe.Size = new System.Drawing.Size(102, 25);
			this.lbTieuDe.TabIndex = 0;
			this.lbTieuDe.Text = "Tiêu đề : ";
			// 
			// lbNoiDung
			// 
			this.lbNoiDung.AutoSize = true;
			this.lbNoiDung.Location = new System.Drawing.Point(39, 139);
			this.lbNoiDung.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
			this.lbNoiDung.Name = "lbNoiDung";
			this.lbNoiDung.Size = new System.Drawing.Size(103, 24);
			this.lbNoiDung.TabIndex = 1;
			this.lbNoiDung.Text = "Nội dung : ";
			// 
			// txtTieuDe
			// 
			this.txtTieuDe.Location = new System.Drawing.Point(160, 67);
			this.txtTieuDe.Name = "txtTieuDe";
			this.txtTieuDe.Size = new System.Drawing.Size(250, 29);
			this.txtTieuDe.TabIndex = 3;
			// 
			// lb1
			// 
			this.lb1.Location = new System.Drawing.Point(160, 139);
			this.lb1.Multiline = true;
			this.lb1.Name = "lb1";
			this.lb1.Size = new System.Drawing.Size(310, 175);
			this.lb1.TabIndex = 4;
			// 
			// btnCreateNew
			// 
			this.btnCreateNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnCreateNew.Location = new System.Drawing.Point(160, 348);
			this.btnCreateNew.Name = "btnCreateNew";
			this.btnCreateNew.Size = new System.Drawing.Size(103, 42);
			this.btnCreateNew.TabIndex = 5;
			this.btnCreateNew.Text = "Tạo mới";
			this.btnCreateNew.UseVisualStyleBackColor = true;
			this.btnCreateNew.Click += new System.EventHandler(this.button1_Click);
			// 
			// btnSave
			// 
			this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSave.Location = new System.Drawing.Point(367, 348);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(103, 42);
			this.btnSave.TabIndex = 7;
			this.btnSave.Text = "Lưu";
			this.btnSave.UseVisualStyleBackColor = true;
			this.btnSave.Click += new System.EventHandler(this.button2_Click);
			// 
			// btnRead
			// 
			this.btnRead.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnRead.Location = new System.Drawing.Point(560, 348);
			this.btnRead.Name = "btnRead";
			this.btnRead.Size = new System.Drawing.Size(103, 42);
			this.btnRead.TabIndex = 8;
			this.btnRead.Text = "Đọc";
			this.btnRead.UseVisualStyleBackColor = true;
			this.btnRead.Click += new System.EventHandler(this.button3_Click);
			// 
			// btnDelete
			// 
			this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnDelete.Location = new System.Drawing.Point(729, 348);
			this.btnDelete.Name = "btnDelete";
			this.btnDelete.Size = new System.Drawing.Size(103, 42);
			this.btnDelete.TabIndex = 9;
			this.btnDelete.Text = "Xóa";
			this.btnDelete.UseVisualStyleBackColor = true;
			this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
			// 
			// dataGridView1
			// 
			this.dataGridView1.AllowUserToAddRows = false;
			this.dataGridView1.AllowUserToDeleteRows = false;
			this.dataGridView1.AllowUserToResizeColumns = false;
			this.dataGridView1.AllowUserToResizeRows = false;
			this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Window;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(560, 67);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.ReadOnly = true;
			this.dataGridView1.RowHeadersVisible = false;
			this.dataGridView1.Size = new System.Drawing.Size(272, 247);
			this.dataGridView1.TabIndex = 10;
			// 
			// lbGhiChuCua
			// 
			this.lbGhiChuCua.AutoSize = true;
			this.lbGhiChuCua.Location = new System.Drawing.Point(44, 13);
			this.lbGhiChuCua.Name = "lbGhiChuCua";
			this.lbGhiChuCua.Size = new System.Drawing.Size(127, 24);
			this.lbGhiChuCua.TabIndex = 11;
			this.lbGhiChuCua.Text = "Ghi chú của  :";
			// 
			// lbName
			// 
			this.lbName.AutoSize = true;
			this.lbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbName.ForeColor = System.Drawing.SystemColors.ControlText;
			this.lbName.Location = new System.Drawing.Point(215, 13);
			this.lbName.Name = "lbName";
			this.lbName.Size = new System.Drawing.Size(66, 24);
			this.lbName.TabIndex = 12;
			this.lbName.Text = "label1";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(39, 73);
			this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(112, 25);
			this.label1.TabIndex = 0;
			this.label1.Text = "Tiêu đề : ";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(39, 139);
			this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(114, 24);
			this.label2.TabIndex = 1;
			this.label2.Text = "Nội dung : ";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(44, 13);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(141, 24);
			this.label3.TabIndex = 11;
			this.label3.Text = "Ghi chú của  :";
			// 
			// frmCreateNote
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.ClientSize = new System.Drawing.Size(867, 434);
			this.Controls.Add(this.lbName);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.lbGhiChuCua);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.btnDelete);
			this.Controls.Add(this.btnRead);
			this.Controls.Add(this.btnSave);
			this.Controls.Add(this.btnCreateNew);
			this.Controls.Add(this.lb1);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.txtTieuDe);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.lbNoiDung);
			this.Controls.Add(this.lbTieuDe);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(6);
			this.Name = "frmCreateNote";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Ghi chú";
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lbTieuDe;
		private System.Windows.Forms.Label lbNoiDung;
		private System.Windows.Forms.TextBox txtTieuDe;
		private System.Windows.Forms.TextBox lb1;
		private System.Windows.Forms.Button btnCreateNew;
		private System.Windows.Forms.Button btnSave;
		private System.Windows.Forms.Button btnRead;
		private System.Windows.Forms.Button btnDelete;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.Label lbGhiChuCua;
		private System.Windows.Forms.Label lbName;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
	}
}

