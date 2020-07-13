using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace frmLogin
{
	class Subject
	{
		private static DataProvider instance;
		public static DataProvider Instance
		{
			get { if (instance == null) instance = new DataProvider(); return instance; }
			private set { instance = value; }
		}

		public int Id { get => id; set => id = value; }
		public string Name { get => name; set => name = value; }
		public int Id_account { get => id_account; set => id_account = value; }

		private int id;
		private string name;
		private int id_account;

		public Subject() { }

		public Subject(int id, string name, int id_account)
		{
			this.Id = id;
			this.Name = name;
			this.Id_account = id_account;
		}

		public Subject(DataRow row)
		{
			this.Id = (int)row["id"];
			this.Name = row["name"].ToString();
			
		}
	}
}
