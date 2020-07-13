using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NoteTakingApplication
{
	public partial class frmDashboard : Form
	{
		public frmDashboard()
		{
			InitializeComponent();
			Load_person_info();
		}

		private void Load_person_info()
		{
			DataTable dt_select = DataProvider.Instance.ExcuteQuery("SELECT * FROM person");
			dtgvPerson.DataSource = dt_select;
			dtgvPerson.Columns["id"].HeaderText = "ID";
			dtgvPerson.Columns["name"].HeaderText = "Họ và tên";
			dtgvPerson.Columns["sex"].HeaderText = "Giới tính";
			dtgvPerson.Columns["role"].HeaderText = "Vai trò";
			dtgvPerson.Columns["phone_number"].HeaderText = "SĐT";
		}

		private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			int id = int.Parse(lbID.Text);
			string name = txtName.Text;

			frmCreateNote frm = new frmCreateNote(id, name);
			frm.ShowDialog();
		}

		private void btnThem_Click(object sender, EventArgs e)
		{
			Person person = new Person();
			person.Name = txtName.Text;

			if (rdbtMale.Checked == true)
				person.Sex = "Nam";
			if (rdbtFemale.Checked == true)
				person.Sex = "Nữ";

			person.Phone_number = txtPhoneNumber.Text;
			person.Role = cbRole.Text;

			DataTable dt = DataProvider.Instance.ExcuteQuery("EXEC Person_Adding @name , @sex , @phone_number , @role"
				, new object[] { person.Name, person.Sex, person.Phone_number, person.Role });

			DataTable dt_select = DataProvider.Instance.ExcuteQuery("SELECT * FROM person");
			dtgvPerson.DataSource = dt_select;
			if(dt_select.Rows.Count > -1)
			{
				MessageBox.Show("Nhập thành công !");
			}
			
		}

		private void dtgvPerson_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			
			if (dtgvPerson.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
			{
				dtgvPerson.CurrentRow.Selected = true;
				lbID.Text = dtgvPerson.Rows[e.RowIndex].Cells["id"].FormattedValue.ToString();
				txtName.Text = dtgvPerson.Rows[e.RowIndex].Cells["name"].FormattedValue.ToString();
				txtPhoneNumber.Text = dtgvPerson.Rows[e.RowIndex].Cells["phone_number"].FormattedValue.ToString();

				if(dtgvPerson.Rows[e.RowIndex].Cells["sex"].FormattedValue.ToString() == "Nam")
				{
					rdbtMale.Checked = true;
				}
				else
				{
					rdbtFemale.Checked = true;
				}

				cbRole.Text = dtgvPerson.Rows[e.RowIndex].Cells["role"].FormattedValue.ToString();

			}
			
			
		}

		private void btnSearch_Click(object sender, EventArgs e)
		{
			lbID.Text = "";
			txtName.Clear();
			txtPhoneNumber.Clear();
			rdbtFemale.Checked = false;
			rdbtMale.Checked = false;
			cbRole.Text = "";
		}

		private void btnViewNote_Click(object sender, EventArgs e)
		{
			
		}

		private void btnDelete_Click(object sender, EventArgs e)
		{
			int id_person = int.Parse(lbID.Text);
			
			string query = "EXEC Person_Deleting @id ";
			if (MessageBox.Show("Bạn có chắc muốn xóa không ?", "Xóa người dùng",
				MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
			{
				DataTable dt = DataProvider.Instance.ExcuteQuery(query, new object[] { id_person });
				Load_person_info();

				lbID.Text = "";
				txtName.Clear();
				txtPhoneNumber.Clear();
				rdbtMale.Checked = false;
				rdbtFemale.Checked = false;
				cbRole.Text = "";
			}
			

			
			
		}

		private void btnUpdate_Click(object sender, EventArgs e)
		{
			int id_person = int.Parse(lbID.Text);
			string person_name = txtName.Text;
			string person_phone_number = txtPhoneNumber.Text;
			string person_role = "";
			string person_sex = "";

			if(rdbtMale.Checked == true)
			{
				person_sex = rdbtMale.Text;
			}
			else if (rdbtFemale.Checked == true)
			{
				person_sex= rdbtFemale.Text;
			}

			if (cbRole.Text == "Giảng viên")
				person_role = cbRole.Text;
			else if (cbRole.Text == "Sinh Viên")
				person_role = cbRole.Text;
			else if (cbRole.Text == "Học Sinh")
				person_role = cbRole.Text;

			string query = "EXEC update_person @name , @sex , @phone_number , @role , @id_person";
			DataTable dt = DataProvider.Instance.ExcuteQuery(query, new object[] { person_name, person_sex
			, person_phone_number, person_role, id_person});
			if(dt.Rows.Count > -1)
			{
				MessageBox.Show("Bạn đã cập nhật thành công ! ");
			}

			Load_person_info();
		}
	}
}
