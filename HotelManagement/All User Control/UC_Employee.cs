using System;
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
	public partial class UC_Employee : UserControl
	{
		DatabaseHelper databaseHelper = new DatabaseHelper();
		Utils utils = new Utils();
		String query;

		public UC_Employee()
		{
			InitializeComponent();
		}

		private void UC_Employee_Load(object sender, EventArgs e)
		{
			LoadComboBoxes();
		}

		private void LoadComboBoxes()
		{
			utils.LoadComboBox(cmbGender, "exec ui_GetGender", "name", "id");
		}
	}
}
