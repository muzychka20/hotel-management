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

namespace HotelManagement.All_User_Control
{
	public partial class UC_AddRoom : UserControl
	{
		DatabaseHelper databaseHelper = new DatabaseHelper();
		Utils utils = new Utils();
		String query;

		public UC_AddRoom()
		{
			InitializeComponent();
		}

		private void LoadComboBoxes()
		{
			utils.LoadComboBox(txtType, "exec ui_GetRoomTypes", "name", "id");
			utils.LoadComboBox(txtBed, "exec ui_GetBedTypes", "name", "id");
		}

		private void UC_AddRoom_Load(object sender, EventArgs e)
		{
			query = "exec ui_GetRooms";
			DataSet ds = databaseHelper.GetData(query);
			DataGridView1.DataSource = ds.Tables[0];
			SetDataGridViewHeader();
			LoadComboBoxes();
			DataGridView1.AllowUserToAddRows = false;
		}

		private void SetDataGridViewHeader()
		{
			DataGridView1.Columns["id"].HeaderText = "Room ID";
			DataGridView1.Columns["no"].HeaderText = "Room Number";
			DataGridView1.Columns["type"].HeaderText = "Room Type";
			DataGridView1.Columns["bed"].HeaderText = "Bed Type";
			DataGridView1.Columns["price"].HeaderText = "Price";
			DataGridView1.Columns["booked"].HeaderText = "Booked";
			DataGridView1.ColumnHeadersHeight = 30;
		}

		private void btnAddRoom_Click(object sender, EventArgs e)
		{
			if (!string.IsNullOrWhiteSpace(txtRoomNo.Text) &&
				!string.IsNullOrWhiteSpace(txtType.Text) &&
				!string.IsNullOrWhiteSpace(txtBed.Text) &&
				!string.IsNullOrWhiteSpace(txtPrice.Text))
			{
				try
				{
					string room_no = txtRoomNo.Text;
					string type = txtType.SelectedValue.ToString();
					string bed = txtBed.SelectedValue.ToString();
					Int64 price = Int64.Parse(txtPrice.Text);
					using (SqlConnection con = databaseHelper.GetConnection())
					{
						string query = "EXEC InsertRoom @room_no, @type, @bed, @price";

						using (SqlCommand cmd = new SqlCommand(query, con))
						{
							cmd.Parameters.AddWithValue("@room_no", room_no);
							cmd.Parameters.AddWithValue("@type", type);
							cmd.Parameters.AddWithValue("@bed", bed);
							cmd.Parameters.AddWithValue("@price", price);
							con.Open();
							cmd.ExecuteNonQuery();
							MessageBox.Show("Room Added Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
						}
					}
					UC_AddRoom_Load(this, null);
					ClearAll();
				}
				catch (FormatException)
				{
					MessageBox.Show("Invalid price format.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
				catch (Exception ex)
				{
					MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
			else
			{
				MessageBox.Show("Fill All Fields.", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
		}

		public void ClearAll()
		{
			txtRoomNo.Clear();
			txtType.SelectedIndex = -1;
			txtBed.SelectedIndex = -1;
			txtPrice.Clear();
		}

		private void UC_AddRoom_Leave(object sender, EventArgs e)
		{
			ClearAll();
		}

		private void UC_AddRoom_Enter(object sender, EventArgs e)
		{
			UC_AddRoom_Load(this, null);
		}
	}
}
