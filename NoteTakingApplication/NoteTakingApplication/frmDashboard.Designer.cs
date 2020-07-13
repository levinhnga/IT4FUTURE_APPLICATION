namespace NoteTakingApplication
{
	partial class frmDashboard
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDashboard));
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
			this.panel1 = new System.Windows.Forms.Panel();
			this.btnSearch = new System.Windows.Forms.Button();
			this.btnDelete = new System.Windows.Forms.Button();
			this.btnAdd = new System.Windows.Forms.Button();
			this.btnUpdate = new System.Windows.Forms.Button();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.panel4 = new System.Windows.Forms.Panel();
			this.linklbCreateNewNote = new System.Windows.Forms.LinkLabel();
			this.cbRole = new System.Windows.Forms.ComboBox();
			this.txtPhoneNumber = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.panel3 = new System.Windows.Forms.Panel();
			this.lbID = new System.Windows.Forms.Label();
			this.rdbtFemale = new System.Windows.Forms.RadioButton();
			this.rdbtMale = new System.Windows.Forms.RadioButton();
			this.txtName = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.panel2 = new System.Windows.Forms.Panel();
			this.panel5 = new System.Windows.Forms.Panel();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.label7 = new System.Windows.Forms.Label();
			this.dtgvPerson = new System.Windows.Forms.DataGridView();
			this.panel1.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.panel4.SuspendLayout();
			this.panel3.SuspendLayout();
			this.panel2.SuspendLayout();
			this.panel5.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dtgvPerson)).BeginInit();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.panel1.Controls.Add(this.btnSearch);
			this.panel1.Controls.Add(this.btnDelete);
			this.panel1.Controls.Add(this.btnAdd);
			this.panel1.Controls.Add(this.btnUpdate);
			this.panel1.Controls.Add(this.groupBox1);
			this.panel1.Location = new System.Drawing.Point(0, 102);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(853, 251);
			this.panel1.TabIndex = 0;
			// 
			// btnSearch
			// 
			this.btnSearch.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSearch.Location = new System.Drawing.Point(278, 205);
			this.btnSearch.Name = "btnSearch";
			this.btnSearch.Size = new System.Drawing.Size(108, 40);
			this.btnSearch.TabIndex = 4;
			this.btnSearch.Text = "Tạo mới";
			this.btnSearch.UseVisualStyleBackColor = false;
			this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
			// 
			// btnDelete
			// 
			this.btnDelete.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnDelete.Location = new System.Drawing.Point(726, 205);
			this.btnDelete.Name = "btnDelete";
			this.btnDelete.Size = new System.Drawing.Size(108, 40);
			this.btnDelete.TabIndex = 3;
			this.btnDelete.Text = "Xóa";
			this.btnDelete.UseVisualStyleBackColor = false;
			this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
			// 
			// btnAdd
			// 
			this.btnAdd.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnAdd.Location = new System.Drawing.Point(468, 205);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Size = new System.Drawing.Size(108, 40);
			this.btnAdd.TabIndex = 2;
			this.btnAdd.Text = "Thêm";
			this.btnAdd.UseVisualStyleBackColor = false;
			this.btnAdd.Click += new System.EventHandler(this.btnThem_Click);
			// 
			// btnUpdate
			// 
			this.btnUpdate.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnUpdate.Location = new System.Drawing.Point(20, 205);
			this.btnUpdate.Name = "btnUpdate";
			this.btnUpdate.Size = new System.Drawing.Size(108, 40);
			this.btnUpdate.TabIndex = 1;
			this.btnUpdate.Text = "Cập Nhật";
			this.btnUpdate.UseVisualStyleBackColor = false;
			this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
			// 
			// groupBox1
			// 
			this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.groupBox1.Controls.Add(this.panel4);
			this.groupBox1.Controls.Add(this.panel3);
			this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox1.Location = new System.Drawing.Point(13, 13);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(821, 186);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Thông tin SV/GV";
			// 
			// panel4
			// 
			this.panel4.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.panel4.Controls.Add(this.linklbCreateNewNote);
			this.panel4.Controls.Add(this.cbRole);
			this.panel4.Controls.Add(this.txtPhoneNumber);
			this.panel4.Controls.Add(this.label6);
			this.panel4.Controls.Add(this.label5);
			this.panel4.Controls.Add(this.label4);
			this.panel4.Location = new System.Drawing.Point(449, 28);
			this.panel4.Name = "panel4";
			this.panel4.Size = new System.Drawing.Size(366, 147);
			this.panel4.TabIndex = 1;
			// 
			// linklbCreateNewNote
			// 
			this.linklbCreateNewNote.AutoSize = true;
			this.linklbCreateNewNote.Location = new System.Drawing.Point(106, 110);
			this.linklbCreateNewNote.Name = "linklbCreateNewNote";
			this.linklbCreateNewNote.Size = new System.Drawing.Size(130, 24);
			this.linklbCreateNewNote.TabIndex = 8;
			this.linklbCreateNewNote.TabStop = true;
			this.linklbCreateNewNote.Text = "Xem ghi chú";
			this.linklbCreateNewNote.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
			// 
			// cbRole
			// 
			this.cbRole.FormattingEnabled = true;
			this.cbRole.Items.AddRange(new object[] {
            "Giảng viên",
            "Sinh Viên",
            "Học Sinh"});
			this.cbRole.Location = new System.Drawing.Point(110, 58);
			this.cbRole.Name = "cbRole";
			this.cbRole.Size = new System.Drawing.Size(228, 32);
			this.cbRole.TabIndex = 7;
			// 
			// txtPhoneNumber
			// 
			this.txtPhoneNumber.Location = new System.Drawing.Point(110, 12);
			this.txtPhoneNumber.Name = "txtPhoneNumber";
			this.txtPhoneNumber.Size = new System.Drawing.Size(228, 29);
			this.txtPhoneNumber.TabIndex = 6;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(3, 110);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(101, 24);
			this.label6.TabIndex = 5;
			this.label6.Text = "Ghi chú : ";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(3, 66);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(88, 24);
			this.label5.TabIndex = 4;
			this.label5.Text = "Vai trò : ";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(3, 17);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(68, 24);
			this.label4.TabIndex = 3;
			this.label4.Text = "SĐT : ";
			// 
			// panel3
			// 
			this.panel3.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.panel3.Controls.Add(this.lbID);
			this.panel3.Controls.Add(this.rdbtFemale);
			this.panel3.Controls.Add(this.rdbtMale);
			this.panel3.Controls.Add(this.txtName);
			this.panel3.Controls.Add(this.label3);
			this.panel3.Controls.Add(this.label2);
			this.panel3.Controls.Add(this.label1);
			this.panel3.Location = new System.Drawing.Point(7, 28);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(366, 147);
			this.panel3.TabIndex = 0;
			// 
			// lbID
			// 
			this.lbID.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.lbID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.lbID.Location = new System.Drawing.Point(120, 12);
			this.lbID.Name = "lbID";
			this.lbID.Size = new System.Drawing.Size(229, 29);
			this.lbID.TabIndex = 7;
			// 
			// rdbtFemale
			// 
			this.rdbtFemale.AutoSize = true;
			this.rdbtFemale.Location = new System.Drawing.Point(243, 106);
			this.rdbtFemale.Name = "rdbtFemale";
			this.rdbtFemale.Size = new System.Drawing.Size(55, 28);
			this.rdbtFemale.TabIndex = 6;
			this.rdbtFemale.Text = "Nữ";
			this.rdbtFemale.UseVisualStyleBackColor = true;
			// 
			// rdbtMale
			// 
			this.rdbtMale.AutoSize = true;
			this.rdbtMale.Location = new System.Drawing.Point(120, 108);
			this.rdbtMale.Name = "rdbtMale";
			this.rdbtMale.Size = new System.Drawing.Size(71, 28);
			this.rdbtMale.TabIndex = 5;
			this.rdbtMale.Text = "Nam";
			this.rdbtMale.UseVisualStyleBackColor = true;
			// 
			// txtName
			// 
			this.txtName.Location = new System.Drawing.Point(120, 58);
			this.txtName.Name = "txtName";
			this.txtName.Size = new System.Drawing.Size(229, 29);
			this.txtName.TabIndex = 4;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(3, 110);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(99, 24);
			this.label3.TabIndex = 2;
			this.label3.Text = "Giới tính :";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(3, 66);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(117, 24);
			this.label2.TabIndex = 1;
			this.label2.Text = "Họ và tên  :";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(3, 17);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(41, 24);
			this.label1.TabIndex = 0;
			this.label1.Text = "ID :";
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.panel2.Controls.Add(this.panel5);
			this.panel2.Controls.Add(this.dtgvPerson);
			this.panel2.Controls.Add(this.panel1);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel2.Location = new System.Drawing.Point(0, 0);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(856, 597);
			this.panel2.TabIndex = 1;
			// 
			// panel5
			// 
			this.panel5.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.panel5.Controls.Add(this.pictureBox1);
			this.panel5.Controls.Add(this.label7);
			this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel5.Location = new System.Drawing.Point(0, 0);
			this.panel5.Name = "panel5";
			this.panel5.Size = new System.Drawing.Size(856, 100);
			this.panel5.TabIndex = 1;
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(20, 13);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(108, 87);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 1;
			this.pictureBox1.TabStop = false;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.Location = new System.Drawing.Point(152, 29);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(424, 46);
			this.label7.TabIndex = 0;
			this.label7.Text = "Note taking of success";
			// 
			// dtgvPerson
			// 
			this.dtgvPerson.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dtgvPerson.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
			this.dtgvPerson.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dtgvPerson.DefaultCellStyle = dataGridViewCellStyle12;
			this.dtgvPerson.Location = new System.Drawing.Point(20, 379);
			this.dtgvPerson.MultiSelect = false;
			this.dtgvPerson.Name = "dtgvPerson";
			this.dtgvPerson.Size = new System.Drawing.Size(814, 206);
			this.dtgvPerson.TabIndex = 0;
			this.dtgvPerson.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvPerson_CellClick);
			// 
			// frmDashboard
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(856, 597);
			this.Controls.Add(this.panel2);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(6);
			this.Name = "frmDashboard";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Note taking of success";
			this.panel1.ResumeLayout(false);
			this.groupBox1.ResumeLayout(false);
			this.panel4.ResumeLayout(false);
			this.panel4.PerformLayout();
			this.panel3.ResumeLayout(false);
			this.panel3.PerformLayout();
			this.panel2.ResumeLayout(false);
			this.panel5.ResumeLayout(false);
			this.panel5.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dtgvPerson)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Panel panel4;
		private System.Windows.Forms.ComboBox cbRole;
		private System.Windows.Forms.TextBox txtPhoneNumber;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.RadioButton rdbtFemale;
		private System.Windows.Forms.RadioButton rdbtMale;
		private System.Windows.Forms.TextBox txtName;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.DataGridView dtgvPerson;
		private System.Windows.Forms.Button btnSearch;
		private System.Windows.Forms.Button btnDelete;
		private System.Windows.Forms.Button btnAdd;
		private System.Windows.Forms.Button btnUpdate;
		private System.Windows.Forms.LinkLabel linklbCreateNewNote;
		private System.Windows.Forms.Label lbID;
		private System.Windows.Forms.Panel panel5;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Label label7;
	}
}