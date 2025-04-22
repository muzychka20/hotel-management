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

		public DataTable GetTable(string query, Dictionary<string, object> parameters = null)
		{
			using (SqlConnection connection = new SqlConnection(_connectionString))
			using (SqlCommand command = new SqlCommand(query, connection))
			{
				if (parameters != null)
				{
					foreach (var param in parameters)
					{
						command.Parameters.AddWithValue(param.Key, param.Value);
					}
				}
				SqlDataAdapter adapter = new SqlDataAdapter(command);
				DataTable table = new DataTable();
				adapter.Fill(table);
				return table;
			}
		}

		public void ExecuteStoredProcedure(string procedureName, Dictionary<string, object> parameters)
		{
			using (SqlConnection connection = GetConnection())
			using (SqlCommand command = new SqlCommand(procedureName, connection))
			{
				command.CommandType = CommandType.StoredProcedure;

				if (parameters != null)
				{
					foreach (var param in parameters)
					{
						command.Parameters.AddWithValue(param.Key, param.Value ?? DBNull.Value);
					}
				}

				connection.Open();
				command.ExecuteNonQuery();
			}
		}
	}
}