using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace frmLogin
{
	class Marks
	{
		private static DataProvider instance;
		public static DataProvider Instance
		{
			get { if (instance == null) instance = new DataProvider(); return instance; }
			private set { instance = value; }
		}

		public int Id { get => id; set => id = value; }
		public float Diem_mieng { get => diem_mieng; set => diem_mieng = value; }
		public float Diem_15 { get => diem_15; set => diem_15 = value; }
		public float Diem_hoc_ki { get => diem_hoc_ki; set => diem_hoc_ki = value; }
		public float Diem_45 { get => diem_45; set => diem_45 = value; }
		public float Diem_trung_binh { get => diem_trung_binh; set => diem_trung_binh = value; }
		public int Id_subject { get => id_subject; set => id_subject = value; }

		private int id;
		private float diem_mieng;
		private float diem_15;
		private float diem_hoc_ki;
		private float diem_45;
		private float diem_trung_binh;
		private int id_subject;

		public Marks() { }

		public Marks(int id, float diem_mieng, float diem_15, float diem_30, float diem_45, float diem_trung_binh, int id_subject)
		{
			this.Id = id;
			this.Diem_mieng = diem_mieng;
			this.Diem_15 = diem_15;
			this.Diem_hoc_ki = diem_30;
			this.Diem_45 = diem_45;
			this.Diem_trung_binh = diem_trung_binh;
		}

		public Marks(DataRow row)
		{
			this.Id = (int)row["id"];
			this.Diem_mieng = (float)row["diem_mieng"];
			this.Diem_15 = (float)row["diem_15"];
			this.Diem_hoc_ki = (float)row["diem_30"];
			this.diem_45 = (float)row["diem_45"];
			this.Diem_trung_binh = (float)row["diem_trung_binh"];
			this.Id_subject = (int)row["id_subject"];
		}
	}
}
