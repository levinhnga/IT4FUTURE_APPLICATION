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
	public partial class frmCreateAccount : Form
	{
		public frmCreateAccount()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			string username = txtUsername.Text;
			string password = txtPassword.Text;
			string display_name = txtDisplayName.Text;
			string grade = txtGrade.Text;

			string query = "EXEC insert_account @username , @pass , @display_name , @grade";
			DataTable dt = DataProvider.Instance.ExcuteQuery(query, new object[] { username, password, display_name, grade });
			if(dt.Rows.Count > -1)
			{
				MessageBox.Show("Bạn đã đăng kí thành công ! ");

				if(MessageBox.Show("Bạn có muốn quay về trang đăng nhập ? ","Quay về trang đăng nhập"
					,MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
				{
					this.Close();
				}
			}	
		}

		private void btnThoat_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
