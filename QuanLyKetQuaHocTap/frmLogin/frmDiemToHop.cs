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
	public partial class frmDiemToHop : Form
	{
		public frmDiemToHop()
		{
			InitializeComponent();
			Load_data();
		}

		Subject subject = new Subject();
		public frmDiemToHop(int id)
		{
			InitializeComponent();
			subject.Id = id;
			Load_data();
		}

		private void Load_data()
		{
			data_khoiA();
			data_khoiB();
			data_khoiC();
		}

		private void data_khoiC()
		{
			
		}

		private void data_khoiB()
		{
			MarksOfSubject marks;
			string query = "SELECT name, diem_mieng, diem_15, diem_45, diem_hoc_ki, diem_trung_binh FROM subject," +
				" marks WHERE subject.id = marks.id_subject ";
			DataTable dt = DataProvider.Instance.ExcuteQuery(query);
			List<MarksOfSubject> list_marks = new List<MarksOfSubject>();
			foreach (DataRow row in dt.Rows)
			{
				marks = new MarksOfSubject(row);
				string subject_name = marks.Name;
				double diem_mieng = marks.Diem_mieng;
				double diem_15 = marks.Diem_15;
				double diem_45 = marks.Diem_45;
				double diem_hoc_ki = marks.Diem_hoc_ki;
				double diem_trung_binh = marks.Diem_trung_binh;

				list_marks.Add(marks);


			}

			double diem_trung_binh_Toan = 0;
			double diem_trung_binh_VatLy = 0;
			double diem_trung_binh_HoaHoc = 0;
			double diem_trung_binh_CongNghe = 0;
			double diem_trung_binh_SinhHoc = 0;
			double diem_trung_binh_DiaLy = 0;
			double diem_trung_binh_CongDan = 0;
			double diem_trung_binh_NgoaiNgu = 0;
			double diem_trung_binh_TinHoc = 0;

			foreach (MarksOfSubject item in list_marks)
			{


				if (item.Name == "Toan")
				{
					diem_trung_binh_Toan = item.Diem_trung_binh;
				}
				else if (item.Name == "VatLy")
				{
					diem_trung_binh_VatLy = item.Diem_trung_binh;
				}
				else if (item.Name == "HoaHoc")
				{
					diem_trung_binh_HoaHoc = item.Diem_trung_binh;
				}
				else if (item.Name == "CongNghe")
				{
					diem_trung_binh_CongNghe = item.Diem_trung_binh;
				}
				else if (item.Name == "TinHoc")
				{
					diem_trung_binh_TinHoc = item.Diem_trung_binh;
				}
				else if (item.Name == "SinhHoc")
				{
					diem_trung_binh_SinhHoc = item.Diem_trung_binh;
				}
				else if (item.Name == "DiaLy")
				{
					diem_trung_binh_DiaLy = item.Diem_trung_binh;
				}
				else if (item.Name == "CongDan")
				{
					diem_trung_binh_CongDan = item.Diem_trung_binh;
				}
				else if (item.Name == "NgoaiNgu")
				{
					diem_trung_binh_NgoaiNgu = item.Diem_trung_binh;
				}
			}

			double diem_khoi_B01 = diem_trung_binh_Toan + diem_trung_binh_VatLy + diem_trung_binh_SinhHoc;
			double diem_khoi_B02 = diem_trung_binh_Toan + diem_trung_binh_DiaLy + diem_trung_binh_SinhHoc;
			double diem_khoi_B03 = diem_trung_binh_Toan + diem_trung_binh_SinhHoc + diem_trung_binh_TinHoc;
			double diem_khoi_B04 = diem_trung_binh_Toan + diem_trung_binh_SinhHoc + diem_trung_binh_CongDan;
			double diem_khoi_B05 = diem_trung_binh_Toan + diem_trung_binh_SinhHoc + diem_trung_binh_HoaHoc;
			double diem_khoi_B08 = diem_trung_binh_Toan + diem_trung_binh_SinhHoc + diem_trung_binh_NgoaiNgu;

			lbB01.Text = diem_khoi_B01.ToString();
			lbB02.Text = diem_khoi_B02.ToString();
			lbB03.Text = diem_khoi_B03.ToString();
			lbB04.Text = diem_khoi_B04.ToString();
			lbB05.Text = diem_khoi_B05.ToString();
			lbB08.Text = diem_khoi_B08.ToString();
		}

		private void data_khoiA()
		{
			MarksOfSubject marks;
			string query = "SELECT name, diem_mieng, diem_15, diem_45, diem_hoc_ki, diem_trung_binh FROM subject," +
				" marks WHERE subject.id = marks.id_subject ";
			DataTable dt = DataProvider.Instance.ExcuteQuery(query);
			List<MarksOfSubject> list_marks = new List<MarksOfSubject>();
			foreach (DataRow row in dt.Rows)
			{
				marks = new MarksOfSubject(row);
				string subject_name = marks.Name;
				double diem_mieng = marks.Diem_mieng;
				double diem_15 = marks.Diem_15;
				double diem_45 = marks.Diem_45;
				double diem_hoc_ki = marks.Diem_hoc_ki;
				double diem_trung_binh = marks.Diem_trung_binh;

				list_marks.Add(marks);


			}

			double diem_trung_binh_Toan = 0;
			double diem_trung_binh_VatLy = 0;
			double diem_trung_binh_HoaHoc = 0;
			double diem_trung_binh_CongNghe = 0;
			double diem_trung_binh_SinhHoc = 0;
			double diem_trung_binh_DiaLy = 0;
			double diem_trung_binh_CongDan = 0;
			double diem_trung_binh_NgoaiNgu = 0;
			double diem_trung_binh_TinHoc = 0;

			foreach (MarksOfSubject item in list_marks)
			{
				

				if (item.Name == "Toan")
				{
					diem_trung_binh_Toan = item.Diem_trung_binh;
				}
				else if(item.Name == "VatLy")
				{
					diem_trung_binh_VatLy = item.Diem_trung_binh;
				}
				else if (item.Name == "HoaHoc")
				{	
					diem_trung_binh_HoaHoc = item.Diem_trung_binh;
				}
				else if (item.Name == "CongNghe")
				{
					diem_trung_binh_CongNghe = item.Diem_trung_binh;
				}
				else if (item.Name == "TinHoc")
				{
					diem_trung_binh_TinHoc = item.Diem_trung_binh;
				}
				else if (item.Name == "SinhHoc")
				{
					diem_trung_binh_SinhHoc = item.Diem_trung_binh;
				}
				else if (item.Name == "DiaLy")
				{
					diem_trung_binh_DiaLy = item.Diem_trung_binh;
				}
				else if (item.Name == "CongDan")
				{
					diem_trung_binh_CongDan = item.Diem_trung_binh;
				}
				else if (item.Name == "NgoaiNgu")
				{
					diem_trung_binh_NgoaiNgu = item.Diem_trung_binh;
				}
			}

			double diem_khoi_A01 = diem_trung_binh_Toan + diem_trung_binh_VatLy + diem_trung_binh_NgoaiNgu;
			double diem_khoi_A02 = diem_trung_binh_Toan + diem_trung_binh_VatLy + diem_trung_binh_SinhHoc;
			double diem_khoi_A04 = diem_trung_binh_Toan + diem_trung_binh_VatLy + diem_trung_binh_DiaLy;
			double diem_khoi_A06 = diem_trung_binh_Toan + diem_trung_binh_HoaHoc + diem_trung_binh_DiaLy;
			double diem_khoi_A07 = diem_trung_binh_Toan + diem_trung_binh_NgoaiNgu + diem_trung_binh_DiaLy;
			double diem_khoi_A10 = diem_trung_binh_Toan + diem_trung_binh_VatLy + diem_trung_binh_CongDan;
			double diem_khoi_A11 = diem_trung_binh_Toan + diem_trung_binh_HoaHoc + diem_trung_binh_CongDan;

			lbA01.Text = diem_khoi_A01.ToString();
			lbA02.Text = diem_khoi_A02.ToString();
			lbA04.Text = diem_khoi_A04.ToString();
			lbA06.Text = diem_khoi_A06.ToString();
			lbA07.Text = diem_khoi_A07.ToString();
			lbA10.Text = diem_khoi_A10.ToString();
			lbA11.Text = diem_khoi_A11.ToString();

		}

		private void label21_Click(object sender, EventArgs e)
		{

		}
	}
}
