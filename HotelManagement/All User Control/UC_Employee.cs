using Guna.UI2.WinForms;
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
	public partial class UC_Employee : UserControl
	{
		DatabaseHelper databaseHelper = new DatabaseHelper();
		Utils utils = new Utils();
		String query;
		int selectedEmpId = 0;

		public UC_Employee()
		{
			InitializeComponent();
		}

		private void UC_Employee_Load(object sender, EventArgs e)
		{
			LoadComboBoxes();
			txtIDEmp.Enabled = false;
		}

		private void LoadComboBoxes()
		{
			utils.LoadComboBox(cmbGender, "exec ui_GetGender", "name", "id");
		}

		private void btnRegisterEmp_Click(object sender, EventArgs e)
		{
			if (!ValidateFields())
			{
				MessageBox.Show("Please fill all required fields!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}

			try
			{
				var parameters = new Dictionary<string, object>
				{
					{ "@name", txtName.Text.Trim() },
					{ "@phone", txtPhone.Text.Trim() },
					{ "@gender", cmbGender.SelectedValue },
					{ "@email", txtEmail.Text.Trim() },
					{ "@username", txtLogin.Text.Trim() },
					{ "@password", txtPassword.Text.Trim() },
				};

				databaseHelper.ExecuteStoredProcedure("InsertEmployee", parameters);

				MessageBox.Show("Employee registered successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
				ClearForm();
			}
			catch (SqlException sqlEx)
			{
				MessageBox.Show($"Database error: {sqlEx.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			catch (Exception ex)
			{
				MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private bool ValidateFields()
		{
			return !(string.IsNullOrWhiteSpace(txtName.Text) ||
					string.IsNullOrWhiteSpace(txtPhone.Text) ||
					cmbGender.SelectedIndex == -1 ||
					string.IsNullOrWhiteSpace(txtEmail.Text) ||
					string.IsNullOrWhiteSpace(txtLogin.Text) ||
					string.IsNullOrWhiteSpace(txtPassword.Text));
		}

		private void ClearForm()
		{
			txtName.Clear();
			txtPhone.Clear();
			cmbGender.SelectedIndex = -1;
			txtEmail.Clear();
			txtLogin.Clear();
			txtPassword.Clear();
		}

		private void tcEmployee_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (tcEmployee.SelectedIndex == 1)
			{
				LoadData(dataGridViewEmp);
			}
			else if (tcEmployee.SelectedIndex == 2)
			{
				LoadData(dataGridViewEmpForDelete);
			}
		}

		private void LoadData(Guna2DataGridView dataGridView)
		{
			DataTable dt = databaseHelper.GetTable("exec ui_GetActiveEmployees");
			dataGridView.DataSource = dt;
			SetDataGridViewHeader(dataGridView);
			dataGridView.AllowUserToAddRows = false;
		}

		private void SetDataGridViewHeader(Guna2DataGridView dataGridView)
		{
			dataGridView.Columns["id"].HeaderText = "ID";
			dataGridView.Columns["name"].HeaderText = "Name";
			dataGridView.Columns["gender"].HeaderText = "Gender";
			dataGridView.Columns["email"].HeaderText = "Email";
			dataGridView.Columns["username"].HeaderText = "Login";
			dataGridView.Columns["start_date"].HeaderText = "Date";
			dataGridView.ColumnHeadersHeight = 30;
		}

		private void btnEmpDelete_Click(object sender, EventArgs e)
		{
			if (selectedEmpId == 0)
			{
				MessageBox.Show("Please select an employee from the list.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}

			try
			{
				var parameters = new Dictionary<string, object>
				{
					{ "@emp_id", selectedEmpId },
				};
				databaseHelper.ExecuteStoredProcedure("DeactivateEmployeeById", parameters);
				MessageBox.Show("Employee deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			catch (SqlException sqlEx)
			{
				MessageBox.Show($"Database error: {sqlEx.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			catch (Exception ex)
			{
				MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}

			txtIDEmp.Text = "";
			selectedEmpId = 0;
			LoadData(dataGridViewEmpForDelete);
		}

		private void dataGridViewEmpForDelete_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex >= 0)
			{
				DataGridViewRow row = dataGridViewEmpForDelete.Rows[e.RowIndex];
				if (row.Cells["id"] != null)
				{
					selectedEmpId = Convert.ToInt32(row.Cells["id"].Value);
					txtIDEmp.Text = row.Cells["id"].Value.ToString();
				}
			}
		}

		private void UC_Employee_Leave(object sender, EventArgs e)
		{
			ClearForm();
		}
	}
}