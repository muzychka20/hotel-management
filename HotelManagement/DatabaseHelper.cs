using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelManagement
{
	internal class DatabaseHelper
	{
		private readonly string _connectionString;
		
		public DatabaseHelper()
		{
			_connectionString = "data source=ZENBOOK\\SQLEXPRESS03;database=HotelManagement;integrated security=True";
		}

		public SqlConnection GetConnection()
		{
			return new SqlConnection(_connectionString);
		}

		public DataSet GetData(string query)
		{
			using (SqlConnection connection = GetConnection())
			using (SqlCommand cmd = new SqlCommand(query, connection))
			using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
			{
				DataSet dataSet = new DataSet();
				adapter.Fill(dataSet);
				return dataSet;
			}
		}
		
		public void SetData(string query)
		{
			using (SqlConnection connection = GetConnection())
			using (SqlCommand cmd = new SqlCommand(query, connection))
			{
				connection.Open();
				cmd.ExecuteNonQuery();
			}
		}

		public DataTable GetTable(string query)
		{
			using (SqlConnection connection = GetConnection())
			using (SqlCommand cmd = new SqlCommand(query, connection))
			using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
			{
				DataTable table = new DataTable();
				adapter.Fill(table);
				return table;
			}
		}

	}
}
