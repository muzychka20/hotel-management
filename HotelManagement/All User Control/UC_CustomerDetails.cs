using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.HtmlControls;
using System.Windows.Forms;

namespace HotelManagement.All_User_Control
{
	public partial class UC_CustomerDetails : UserControl
	{
		DatabaseHelper databaseHelper = new DatabaseHelper();
		Utils utils = new Utils();
		String query;
		int searchType = 1;
		string name = null;

		public UC_CustomerDetails()
		{
			InitializeComponent();
		}

		private void UC_CustomerDetails_Load(object sender, EventArgs e)
		{
			LoadComboBoxes();
			LoadData();
		}

		private void LoadComboBoxes()
		{
			var cmdData = new Dictionary<int, string>
			{
				{ 1, " All Customers' Visits" },
				{ 2, "Search By Customer's Name" }
			};
			cmbSearchType.DataSource = new BindingSource(cmdData, null);
			cmbSearchType.DisplayMember = "Value";
			cmbSearchType.ValueMember = "Key";
			cmbSearchType.SelectedIndex = 0;
		}

		private void LoadData()
		{
			var parameters = new Dictionary<string, object>
			{
				{ "@name", this.name },
				{ "@searchType", this.searchType },
			};
			DataTable dt = databaseHelper.GetTable("exec ui_SearchCustomersVisits @name, @searchType", parameters);
			DataGridView1.DataSource = dt;
			SetDataGridViewHeader();
			DataGridView1.AllowUserToAddRows = false;
		}

		private void SetDataGridViewHeader()
		{
			DataGridView1.Columns["name"].HeaderText = "Client Name";
			DataGridView1.Columns["phone"].HeaderText = "Phone Number";
			DataGridView1.Columns["dob"].HeaderText = "Date of Birth";
			DataGridView1.Columns["idproof"].HeaderText = "ID Proof";
			DataGridView1.Columns["check_in"].HeaderText = "Check-in Date";
			DataGridView1.Columns["check_out"].HeaderText = "Check-out Date";
			DataGridView1.Columns["gender_name"].HeaderText = "Gender";
			DataGridView1.Columns["nationality_name"].HeaderText = "Nationality";
			DataGridView1.Columns["room_no"].HeaderText = "Room Number";
			DataGridView1.Columns["country"].HeaderText = "Country";
			DataGridView1.Columns["city"].HeaderText = "City";
			DataGridView1.Columns["street"].HeaderText = "Street";
			DataGridView1.Columns["house"].HeaderText = "House Number";
			DataGridView1.Columns["location"].HeaderText = "Location";
			DataGridView1.ColumnHeadersHeight = 30;
		}

		private void cmbSearchType_SelectedIndexChanged(object sender, EventArgs e)
		{
			this.searchType = cmbSearchType.SelectedIndex + 1; // 1 - all visits; 2 - customer's visits
			this.name = txtCustomerName.Text;			
			LoadData();
		}

		private void txtCustomerName_TextChanged(object sender, EventArgs e)
		{
			this.name = txtCustomerName.Text;
			LoadData();
		}

		private void UC_CustomerDetails_Enter(object sender, EventArgs e)
		{
			LoadData();
		}
	}
}
