using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace HotelManagement
{
	public partial class Form1 : MovableForm
	{
		public Form1()
		{
			InitializeComponent();
			EnableWindowDrag(panel1);
		}

		private void btnExit_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void btnLogin_Click(object sender, EventArgs e)
		{
			string username = txtUsername.Text.Trim();
			string password = txtPassword.Text.Trim();

			if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
			{
				labelError.Visible = true;
				return;
			}

			try
			{
				DatabaseHelper db = new DatabaseHelper();

				var parameters = new Dictionary<string, object>
				{
					{ "@emp_login", username },
					{ "@emp_pass", password }
				};

				db.ExecuteStoredProcedure("AuthUser", parameters);

				labelError.Visible = false;
				Dashboard ds = new Dashboard();
				this.Hide();
				ds.Show();
			}
			catch (SqlException ex)
			{
				labelError.Visible = true;
			}
			catch (Exception ex)
			{
				labelError.Visible = true;
			}

			txtPassword.Clear();
		}
	}
}
