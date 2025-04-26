using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelManagement.All_User_Control
{
	public partial class UC_CustomerCheckOut : UserControl
	{
		DatabaseHelper databaseHelper = new DatabaseHelper();
		Utils utils = new Utils();
		String query;
		private int selectedRoomId;
		private DateTime selectedCheckInDate;

		public UC_CustomerCheckOut()
		{
			InitializeComponent();
		}

		private void UC_CustomerCheckOut_Load(object sender, EventArgs e)
		{
			LoadData();
		}

		private void LoadData()
		{
			query = "exec ui_GetCurrentCustomers";
			DataSet ds = databaseHelper.GetData(query);
			dataGridCustomerCheckOut.DataSource = ds.Tables[0];
			SetDataGridViewHeader();
			dataGridCustomerCheckOut.AllowUserToAddRows = false;
		}

		private void SetDataGridViewHeader()
		{
			dataGridCustomerCheckOut.Columns["name"].HeaderText = "Client Name";
			dataGridCustomerCheckOut.Columns["phone"].HeaderText = "Phone Number";
			dataGridCustomerCheckOut.Columns["dob"].HeaderText = "Date of Birth";
			dataGridCustomerCheckOut.Columns["idproof"].HeaderText = "ID Proof";
			dataGridCustomerCheckOut.Columns["check_in"].HeaderText = "Check-in Date";
			dataGridCustomerCheckOut.Columns["gender_name"].HeaderText = "Gender";
			dataGridCustomerCheckOut.Columns["nationality_name"].HeaderText = "Nationality";
			dataGridCustomerCheckOut.Columns["room_no"].HeaderText = "Room Number";
			dataGridCustomerCheckOut.Columns["country"].HeaderText = "Country";
			dataGridCustomerCheckOut.Columns["city"].HeaderText = "City";
			dataGridCustomerCheckOut.Columns["street"].HeaderText = "Street";
			dataGridCustomerCheckOut.Columns["house"].HeaderText = "House Number";
			dataGridCustomerCheckOut.Columns["location"].HeaderText = "Location";
			dataGridCustomerCheckOut.Columns["room_id"].Visible = false;
			dataGridCustomerCheckOut.ColumnHeadersHeight = 30;
		}

		private void dataGridCustomerCheckOut_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex >= 0)
			{
				DataGridViewRow row = dataGridCustomerCheckOut.Rows[e.RowIndex];
				txtName.Text = row.Cells["name"].Value.ToString();
				txtRoom.Text = row.Cells["room_no"].Value.ToString();
				if (row.Cells["room_id"] != null)
				{
					selectedRoomId = Convert.ToInt32(row.Cells["room_id"].Value);
				}
				if (row.Cells["check_in"] != null && row.Cells["check_in"].Value != DBNull.Value)
				{
					selectedCheckInDate = Convert.ToDateTime(row.Cells["check_in"].Value);
				}
			}
		}

		private void btnCheckOut_Click(object sender, EventArgs e)
		{
			if (selectedRoomId == 0)
			{
				MessageBox.Show("Please select a customer from the list.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}

			DateTime checkoutDate = dtCheckOut.Value;

			if (checkoutDate <= selectedCheckInDate)
			{
				MessageBox.Show("Checkout date must be after check-in date.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			var parameters = new Dictionary<string, object>
			{
				{ "@room_id", selectedRoomId },
				{ "@checkout_date", checkoutDate }
			};

			databaseHelper.ExecuteStoredProcedure("CheckoutCustomer", parameters);

			MessageBox.Show("Customer checked out successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

			txtName.Text = "";
			txtRoom.Text = "";
			selectedRoomId = 0;

			LoadData();
		}

		private void UC_CustomerCheckOut_Enter(object sender, EventArgs e)
		{
			LoadData();
		}
	}
}
