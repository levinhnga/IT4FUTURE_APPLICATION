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
	public partial class frmMarksOfSubject : Form
	{
		Subject subject = new Subject();
		public frmMarksOfSubject()
		{
			InitializeComponent();
		}

		public frmMarksOfSubject(int id_subject)
		{
			InitializeComponent();
			this.subject.Id = id_subject;
			Load_Data();
		}

		private void Load_Data()
		{
			// update diem trung binh 

			MarksOfSubject marks;
			string query = "SELECT name, diem_mieng, diem_15, diem_45, diem_hoc_ki, diem_trung_binh FROM subject , marks WHERE subject.id = marks.id_subject AND" +
				" marks.id_subject =" + subject.Id;
			DataTable dt = DataProvider.Instance.ExcuteQuery(query);
			foreach(DataRow row in dt.Rows)
			{
				marks = new MarksOfSubject(row);
				lbSubjectName.Text = marks.Name;
				lbDiemMieng.Text = marks.Diem_mieng.ToString();
				lbDiem15.Text = marks.Diem_15.ToString();
				lbDiem45.Text = marks.Diem_45.ToString();
				lbDiemHocKi.Text = marks.Diem_hoc_ki.ToString();

				update_diem_trung_binh(float.Parse(lbDiemMieng.Text), float.Parse(lbDiem15.Text)
					, float.Parse(lbDiem45.Text), float.Parse(lbDiemHocKi.Text));

				
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

		private void update_diem_trung_binh(float diem_mieng, float diem_15, float diem_45, float diem_hoc_ki)
		{
			MarksOfSubject marks;
			// tinh diem trung binh
			float diem_trung_binh = (diem_mieng + diem_15 + diem_45 * 2 + diem_hoc_ki * 3)/7;
			string query_update = "UPDATE marks SET diem_trung_binh=" + diem_trung_binh+ "WHERE id_subject=" + subject.Id;
			DataTable dt = DataProvider.Instance.ExcuteQuery(query_update);

			// select diem trung binh
			string query_select = "SELECT name, diem_mieng, diem_15, diem_45, diem_hoc_ki, diem_trung_binh FROM subject , marks WHERE subject.id = marks.id_subject AND" +
				" marks.id_subject =" + subject.Id;
			DataTable dt2 = DataProvider.Instance.ExcuteQuery(query_select);
			foreach(DataRow row in dt2.Rows)
			{
				marks = new MarksOfSubject(row);
				lbDiemTrungBinh.Text = marks.Diem_trung_binh.ToString();
			}
		}

		private void btnSuaDiem_Click(object sender, EventArgs e)
		{
			this.Hide();
			frmChangeSubjectMarks frm = new frmChangeSubjectMarks(subject.Id);
			frm.ShowDialog();
		}
	}
}
