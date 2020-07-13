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

namespace NoteTakingApplication
{
	public partial class frmLogin : Form
	{
		public frmLogin()
		{
			InitializeComponent();
		}

		private void btnLogin_Click(object sender, EventArgs e)
		{
			// buoc 1 : lưu dữ liệu username và password từ người dùng nhập vào
			// bước 2 : Kiểm tra u và p mình vừa lưu có khớp với cơ sở dữ liệu
			// bước 3 --> Khớp : Mở ra form ghi chú
			//        --> không khớp : Thông báo lỗi

			string get_username = txtUsername.Text;
			string get_password = txtPassword.Text;

			string connectionString = @"Data Source=DESKTOP-QFF5AJJ\SQLEXPRESS;Initial Catalog=NoteTakingSc;Integrated Security=True";
			SqlConnection sqlConnection = new SqlConnection(connectionString);
			sqlConnection.Open();

			SqlCommand sqlCommand = new SqlCommand();
			sqlCommand.CommandType = CommandType.Text;
			sqlCommand.CommandText = "SELECT * FROM account";
			sqlCommand.Connection = sqlConnection;

			SqlDataReader reader = sqlCommand.ExecuteReader();
			bool check = false;

			while(reader.Read())
			{
				string username_getSQL = reader.GetString(0);
				string password_getSQL = reader.GetString(1);

				if(username_getSQL == get_username && password_getSQL == get_password)
				{
					frmDashboard frm = new frmDashboard();
					frm.Show();
					return;
				}
				else
				{
					check = false;
				}
			}

			if(check == false)
			{
				MessageBox.Show("Dang nhap khong thanh cong ");
			}
			
		}

		
	}
}
