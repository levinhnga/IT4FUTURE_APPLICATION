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
	public partial class frmChangeSubjectMarks : Form
	{
		Subject subject = new Subject();
		public frmChangeSubjectMarks()
		{
			InitializeComponent();
		}

		public frmChangeSubjectMarks(int id)
		{
			InitializeComponent();
			subject.Id = id;
			Load_Data();
		}

		private void Load_Data()
		{
			string query = "SELECT id,  name FROM subject WHERE subject.id = " + subject.Id;
			DataTable dt = DataProvider.Instance.ExcuteQuery(query);
			foreach(DataRow row in dt.Rows)
			{
				lbSubjectName.Text = row["name"].ToString();
			}

			if (lbSubjectName.Text == "Toan")
				lbSubjectName.Text = "Toán";
			else if (lbSubjectName.Text == "VatLy")
				lbSubjectName.Text = "Vật Lý";
			else if (lbSubjectName.Text == "CongNghe")
				lbSubjectName.Text = "Công Nghệ";
			else if (lbSubjectName.Text == "SinhHoc")
				lbSubjectName.Text = "Sinh Học";
			else if (lbSubjectName.Text == "TinHoc")
				lbSubjectName.Text = "Tin Học";
			else if (lbSubjectName.Text == "CongDan")
				lbSubjectName.Text = "Công Dân";
			else if (lbSubjectName.Text == "NgoaiNgu")
				lbSubjectName.Text = "Ngoại Ngữ";
			else if (lbSubjectName.Text == "DiaLy")
				lbSubjectName.Text = "Địa Lý";
			else if (lbSubjectName.Text == "HoaHoc")
				lbSubjectName.Text = "Hóa Học";

		}

		private void btn9_Click(object sender, EventArgs e)
		{
			lbMarks.Text += "9";
		}

		private void btn0_Click(object sender, EventArgs e)
		{
			lbMarks.Text += "0";
		}

		private void btn5_Click(object sender, EventArgs e)
		{
			lbMarks.Text += "5";
		}

		private void btn6_Click(object sender, EventArgs e)
		{
			lbMarks.Text += "6";
		}

		private void btn7_Click(object sender, EventArgs e)
		{
			lbMarks.Text += "7";
		}

		private void btn1_Click(object sender, EventArgs e)
		{
			lbMarks.Text += "1";
		}

		private void btn2_Click(object sender, EventArgs e)
		{
			lbMarks.Text += "2";
		}

		private void btn3_Click(object sender, EventArgs e)
		{
			lbMarks.Text += "3";
		}

		private void btnPoint_Click(object sender, EventArgs e)
		{
			lbMarks.Text += ".";
		}

		private void button1_Click(object sender, EventArgs e)
		{
			lbMarks.Text = "";
		}

		private void button14_Click(object sender, EventArgs e)
		{
			string s = lbMarks.Text;

			if (s.Length > 1)
			{
				s = s.Substring(0, s.Length - 1);
			}
			else
			{
				s = "0";
			}

			lbMarks.Text = s;
		}

		private void btn8_Click(object sender, EventArgs e)
		{
			lbMarks.Text = "8";
		}

		private void btn4_Click(object sender, EventArgs e)
		{
			lbMarks.Text = "4";
		}

		private void button3_Click(object sender, EventArgs e)
		{
			
			

			if(cbHeSoDiem.Text == "Điểm miệng")
			{
				double diem = Convert.ToDouble(lbMarks.Text);
				string query = "UPDATE marks SET diem_mieng = " + diem + "WHERE id_subject=" + subject.Id;
				DataTable dt = DataProvider.Instance.ExcuteQuery(query);
				if (dt.Rows.Count > -1)
				{
					MessageBox.Show("Bạn đã cập nhật điểm miệng thành công ! ");
					lbMarks.Text = "";
				}
			}
			else if(cbHeSoDiem.Text == "Điểm 15")
			{
				double diem = Convert.ToDouble(lbMarks.Text);
				string query = "UPDATE marks SET diem_15 = " + diem + "WHERE id_subject=" + subject.Id;
				DataTable dt = DataProvider.Instance.ExcuteQuery(query);
				if (dt.Rows.Count > -1)
				{
					MessageBox.Show("Bạn đã cập nhật điểm 15 phút thành công ! ");
					lbMarks.Text = "";
				}
			}
			else if(cbHeSoDiem.Text == "Điểm 45 ")
			{
				double diem = Convert.ToDouble(lbMarks.Text);
				string query = "UPDATE marks SET diem_45 = " + diem + "WHERE id_subject=" + subject.Id;
				DataTable dt = DataProvider.Instance.ExcuteQuery(query);
				if (dt.Rows.Count > -1)
				{
					MessageBox.Show("Bạn đã cập nhật điểm 45 phút thành công ! ");
					lbMarks.Text = "";
				}
			}
			else if(cbHeSoDiem.Text == "Điểm Học Kì")
			{
				double diem = Convert.ToDouble(lbMarks.Text);
				string query = "UPDATE marks SET diem_hoc_ki = " + diem + "WHERE id_subject=" + subject.Id;
				DataTable dt = DataProvider.Instance.ExcuteQuery(query);
				if (dt.Rows.Count > -1)
				{
					MessageBox.Show("Bạn đã cập nhật điểm học kì thành công ! ");
					lbMarks.Text = "";
				}
			}	
			else
			{
				MessageBox.Show("Vui lòng chọn hệ số điểm ! ");
			}
		}

		

		private void button2_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
