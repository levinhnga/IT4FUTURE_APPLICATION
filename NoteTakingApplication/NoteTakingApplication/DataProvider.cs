using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoteTakingApplication
{
	class DataProvider
	{
		private static DataProvider instance;
		public static DataProvider Instance
		{
			get { if (instance == null) instance = new DataProvider(); return instance; }
			private set { instance = value; }
		}

		string connectionString = @"Data Source=DESKTOP-QFF5AJJ\SQLEXPRESS;Initial Catalog=NoteTakingApplication;Integrated Security=True";
		SqlConnection sqlconnection;

		public DataTable ExcuteQuery(string query, object[] parameter = null)
		{
			DataTable dt = new DataTable();

			using (sqlconnection = new SqlConnection(connectionString))
			{
				sqlconnection.Open();

				SqlCommand sqlCommand = new SqlCommand();
				sqlCommand.CommandType = CommandType.Text;
				sqlCommand.CommandText = query;
				sqlCommand.Connection = sqlconnection;

				if (parameter != null)
				{
					string[] listPara = query.Split(' ');
					int i = 0;
					foreach (string item in listPara)
					{
						if (item.Contains('@'))
						{
							sqlCommand.Parameters.AddWithValue(item, parameter[i]);
							i++;
						}
					}

				}
				SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand);
				adapter.Fill(dt);

				sqlconnection.Close();
			}

			return dt;
		}

		public int ExcuteNonQuery(string query, object[] parameter = null)
		{
			int dt = 0;

			using (sqlconnection = new SqlConnection(connectionString))
			{
				sqlconnection.Open();

				SqlCommand sqlCommand = new SqlCommand();
				sqlCommand.CommandType = CommandType.Text;
				sqlCommand.CommandText = query;
				sqlCommand.Connection = sqlconnection;

				if (parameter != null)
				{
					string[] listPara = query.Split(' ');
					int i = 0;
					foreach (string item in listPara)
					{
						if (item.Contains('@'))
						{
							sqlCommand.Parameters.AddWithValue(item, parameter[i]);
							i++;
						}
					}

				}
				dt = sqlCommand.ExecuteNonQuery();

			}

			return dt;
		}

		public object ExcuteScalar(string query, object[] parameter = null)
		{
			object dt = 0;

			using (sqlconnection = new SqlConnection(connectionString))
			{
				sqlconnection.Open();

				SqlCommand sqlCommand = new SqlCommand();
				sqlCommand.CommandType = CommandType.Text;
				sqlCommand.CommandText = query;
				sqlCommand.Connection = sqlconnection;

				if (parameter != null)
				{
					string[] listPara = query.Split(' ');
					int i = 0;
					foreach (string item in listPara)
					{
						if (item.Contains('@'))
						{
							sqlCommand.Parameters.AddWithValue(item, parameter[i]);
							i++;
						}
					}

				}
				dt = sqlCommand.ExecuteScalar();

			}

			return dt;
		}

		public void Insert_Update_Delete_Data(string query, object[] parameter = null)
		{

			using (sqlconnection = new SqlConnection(connectionString))
			{
				sqlconnection.Open();

				SqlCommand sqlCommand = new SqlCommand();
				sqlCommand.CommandType = CommandType.Text;
				sqlCommand.CommandText = query;
				sqlCommand.Connection = sqlconnection;

				if (parameter != null)
				{
					string[] listPara = query.Split(' ');
					int i = 0;
					foreach (string item in listPara)
					{
						if (item.Contains('@'))
						{
							sqlCommand.Parameters.AddWithValue(item, parameter[i]);
							i++;
						}
					}

				}

			}
		}
	}
}
