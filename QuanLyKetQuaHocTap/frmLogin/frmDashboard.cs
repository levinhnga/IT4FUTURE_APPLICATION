using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace frmLogin
{
	public partial class frmDashboard : Form
	{
		public frmDashboard()
		{
			InitializeComponent();
		}
		Account account = new Account();
		public frmDashboard(int id_account)
		{
			InitializeComponent();
			account.Id = id_account;
			Load_Data(account.Id);
		}

		private void Load_Data(int id_account)
		{
			string query = "SELECT * FROM account WHERE id = " + id_account;
			DataTable dt = DataProvider.Instance.ExcuteQuery(query);
			Account account2;
			foreach (DataRow item in dt.Rows)
			{
				account2 = new Account(item);
				lbDisplayName.Text = account2.Display_name;
				lbGrade.Text = account2.Grade;
			}

		}

		private void button2_Click(object sender, EventArgs e)
		{
			MessageBox.Show("Chức năng đang được bảo trì ! ");
		}

		private void button5_Click(object sender, EventArgs e)
		{
			Get_id_subject("Toan");


		}

		private void button6_Click(object sender, EventArgs e)
		{
			Get_id_subject("VatLy");
		}

		private void btnCongNghe_Click(object sender, EventArgs e)
		{
			Get_id_subject("CongNghe");
		}

		private void btnHoaHoc_Click(object sender, EventArgs e)
		{
			Get_id_subject("HoaHoc");
		}

		private void Get_id_subject(string subject_name)
		{
			Subject subject;
			// Lấy subject id để khi mở form điểm của subject ra thì có thể dựa vào id subject mà mở điểm
			// lấy tất cả thông tin của subject ra 
			string query = "SELECT id , name FROM subject WHERE id_account=" + account.Id + "AND name='"+subject_name+"'";
			DataTable dt = DataProvider.Instance.ExcuteQuery(query);

			foreach (DataRow row in dt.Rows)
			{
				subject = new Subject(row);
				frmMarksOfSubject frm = new frmMarksOfSubject(subject.Id);
				frm.ShowDialog();
			}
		}

		private void btnSinhHoc_Click(object sender, EventArgs e)
		{
			Get_id_subject("SinhHoc");
		}

		private void btnDiaLy_Click(object sender, EventArgs e)
		{
			Get_id_subject("DiaLy");
		}

		private void btnCongDan_Click(object sender, EventArgs e)
		{
			Get_id_subject("CongDan");
		}

		private void b_Click(object sender, EventArgs e)
		{
			Get_id_subject("NgoaiNgu");
		}

		private void btnTinHoc_Click(object sender, EventArgs e)
		{
			Get_id_subject("TinHoc");
		}

		private void button3_Click(object sender, EventArgs e)
		{
			frmDiemToHop frm = new frmDiemToHop();
			frm.ShowDialog();
		}

		private void button4_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			MessageBox.Show("Chức năng đang được bảo trì ! ");
		}
	}
}
