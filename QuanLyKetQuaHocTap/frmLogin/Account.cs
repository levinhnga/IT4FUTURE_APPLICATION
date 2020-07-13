using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace frmLogin
{
	class Account
	{
		private static DataProvider instance;
		public static DataProvider Instance
		{
			get { if (instance == null) instance = new DataProvider(); return instance; }
			private set { instance = value; }
		}

		public int Id { get => id; set => id = value; }
		public string Username { get => username; set => username = value; }
		public string Password { get => password; set => password = value; }
		public string Display_name { get => display_name; set => display_name = value; }
		public string Grade { get => grade; set => grade = value; }

		private int id;
		private string username;
		private string password;
		private string display_name;
		private string grade;

		public Account() { }

		public Account(int id, string username, string password, string display_name, string grade)
		{
			this.Id = id;
			this.Username = username;
			this.Password = password;
			this.Display_name = display_name;
			this.Grade = grade;
		}

		public Account(DataRow row)
		{
			this.Id = (int)row["id"];
			this.Username = row["username"].ToString();
			this.Password = row["pass"].ToString();
			this.Display_name = row["display_name"].ToString();
			this.Grade = row["grade"].ToString();
		}
	}
}
