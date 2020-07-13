using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace frmLogin
{
	public partial class frmLogin : Form
	{
		public frmLogin()
		{
			InitializeComponent();
			txtUsername.Select();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			string get_username = txtUsername.Text;
			string get_password = txtPassword.Text;

			string connectionString = @"Data Source=DESKTOP-QFF5AJJ\SQLEXPRESS;Initial Catalog=QuanLyKetQuaHocTap;Integrated Security=True";
			SqlConnection sqlConnection = new SqlConnection(connectionString);
			sqlConnection.Open();

			SqlCommand sqlCommand = new SqlCommand();
			sqlCommand.CommandType = CommandType.Text;
			sqlCommand.CommandText = "SELECT * FROM account";
			sqlCommand.Connection = sqlConnection;

			SqlDataReader reader = sqlCommand.ExecuteReader();
			bool check = false;

			while (reader.Read())
			{
				int id_account = reader.GetInt32(0);
				string username_getSQL = reader.GetString(1);
				string password_getSQL = reader.GetString(2);

				if (username_getSQL == get_username && password_getSQL == get_password)
				{
					this.Hide();
					frmDashboard frm = new frmDashboard(id_account);
					frm.ShowDialog();
					this.Show();
					return;
				}
				else
				{
					check = false;
				}
			}

			if (check == false)
			{
				MessageBox.Show("Dang nhap khong thanh cong ");
			}
		}

		private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			frmCreateAccount frm = new frmCreateAccount();
			frm.ShowDialog();
		}
	}
}
