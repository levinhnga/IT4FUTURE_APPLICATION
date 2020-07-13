using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace frmLogin
{
	class MarksOfSubject
	{
		private static DataProvider instance;
		public static DataProvider Instance
		{
			get { if (instance == null) instance = new DataProvider(); return instance; }
			private set { instance = value; }
		}

		public string Name { get => name; set => name = value; }
		public double Diem_mieng { get => diem_mieng; set => diem_mieng = value; }
		public double Diem_15 { get => diem_15; set => diem_15 = value; }
		public double Diem_hoc_ki { get => diem_hoc_ki; set => diem_hoc_ki = value; }
		public double Diem_45 { get => diem_45; set => diem_45 = value; }
		public double Diem_trung_binh { get => diem_trung_binh; set => diem_trung_binh = value; }

		private string name;
		private double diem_mieng;
		private double diem_15;
		private double diem_hoc_ki;
		private double diem_45;
		private double diem_trung_binh;

		public MarksOfSubject(DataRow row)
		{
			this.Name = row["name"].ToString();
			this.Diem_mieng = Convert.ToDouble(row["diem_mieng"]);
			this.Diem_15 = Convert.ToDouble(row["diem_15"]);
			this.Diem_hoc_ki = Convert.ToDouble(row["diem_hoc_ki"]);
			this.diem_45 = Convert.ToDouble(row["diem_45"]);
			this.Diem_trung_binh = Convert.ToDouble(row["diem_trung_binh"]);
		}
	}
}
