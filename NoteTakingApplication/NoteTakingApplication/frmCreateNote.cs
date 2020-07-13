using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NoteTakingApplication
{
	public partial class frmCreateNote : Form
	{
		int person_ID;
		string person_Name;
		public frmCreateNote()
		{
			InitializeComponent();
			Load_Data();
		}

		public frmCreateNote(int id, string name)
		{
			InitializeComponent();
			this.person_ID = id;
			this.person_Name = name;
			Load_Data();
		}

		private void Load_Data()
		{
			DataTable dt = DataProvider.Instance.ExcuteQuery("EXEC SelectNote_From_PersonID @id_person", new object[] { person_ID });
			dataGridView1.DataSource = dt;
			dataGridView1.Columns["id"].Visible = false;
			dataGridView1.Columns["content"].Visible = false;
			dataGridView1.Columns["tittle"].Width = 272;
			dataGridView1.Columns["tittle"].HeaderText = "Tiêu đề";

			// load user's name
			lbName.Text = person_Name;

		}

		private void button1_Click(object sender, EventArgs e)
		{
			if(MessageBox.Show("Bạn muốn tạo mới tiêu đề và nội dung không ? ", "Tạo mới",
				MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
			{
				lb1.Clear();
				txtTieuDe.Clear();
			}	
		}

		private void button2_Click(object sender, EventArgs e)
		{
			string tittle = txtTieuDe.Text;
			string content = lb1.Text;
			int ID;

			DataTable dt = DataProvider.Instance.ExcuteQuery("EXEC NoteAdding @tittle , @content , @id_person",
				new object[] { tittle, content, person_ID});
			if (dt.Rows.Count > -1)
				MessageBox.Show("Bạn đã lưu thành công ");

			// Load data to datagridview once user insert note
			DataTable dtSelect = DataProvider.Instance.ExcuteQuery("EXEC SelectNote_From_PersonID @id_person", new object[] { person_ID });
			dataGridView1.DataSource = dtSelect;

			

			txtTieuDe.Clear();
			lb1.Clear();
		}

		private void button3_Click(object sender, EventArgs e)
		{
			int index = dataGridView1.CurrentCell.RowIndex;

			string tittle;
			string content;

			DataTable table = DataProvider.Instance.ExcuteQuery("SELECT tittle , content FROM note WHERE id_person="+person_ID);

			if(index > -1)
			{
				txtTieuDe.Text = table.Rows[index].ItemArray[0].ToString();
				lb1.Text = table.Rows[index].ItemArray[1].ToString();
			}
		}

		private void btnDelete_Click(object sender, EventArgs e)
		{
			int index = dataGridView1.CurrentCell.RowIndex;
			DataTable table = DataProvider.Instance.ExcuteQuery("SELECT tittle FROM note");
			string tittle = table.Rows[index].ItemArray[0].ToString();

			if (MessageBox.Show("Bạn có muốn xóa gi chú có tiêu đề là : "+tittle+" ? ", "Xóa gi chú",
				MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
			{
				if (index > -1)
				{

					DataTable table2 = DataProvider.Instance.ExcuteQuery("EXEC NoteDeleting @tittle", new object[] { tittle });
				}

				table.Rows[index].Delete();

				dataGridView1.DataSource = table;

				lb1.Clear();
				txtTieuDe.Clear();
			}	

			
		}
	}
}
