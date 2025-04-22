using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelManagement
{
	internal class Utils
	{
		DatabaseHelper databaseHelper = new DatabaseHelper();

		public void LoadComboBox(ComboBox comboBox, string query, string displayMember, string valueMember)
		{
			DataTable data = databaseHelper.GetTable(query);
			comboBox.DataSource = data;
			comboBox.DisplayMember = displayMember;
			comboBox.ValueMember = valueMember;
			comboBox.SelectedIndex = -1;
		}
	}
}
