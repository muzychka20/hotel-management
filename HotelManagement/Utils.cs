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

		public void LoadComboBox(ComboBox comboBox, string query, string displayMember, string valueMember, Dictionary<string, object> parameters = null)
		{
			DataTable data = databaseHelper.GetTable(query, parameters);
			comboBox.DataSource = data;
			comboBox.DisplayMember = displayMember;
			comboBox.ValueMember = valueMember;
			comboBox.SelectedIndex = -1;
		}
	}
}
