using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelManagement.All_User_Control
{
	public partial class UC_CustomerRegistration : UserControl
	{
		DatabaseHelper databaseHelper = new DatabaseHelper();
		Utils utils = new Utils();
		String query;

		public UC_CustomerRegistration()
		{
			InitializeComponent();
		}

		private void LoadComboBoxes()
		{
			utils.LoadComboBox(cmbBed, "exec ui_GetBedTypes", "name", "id");
			utils.LoadComboBox(cmbRoomType, "exec ui_GetRoomTypes", "name", "id");
			utils.LoadComboBox(cmbNationality, "exec ui_GetNationlities", "name", "id");
			utils.LoadComboBox(cmbGender, "exec ui_GetGender", "name", "id");
			utils.LoadComboBox(cmbCountry, "exec ui_GetCountries", "name", "id");
		}

		private void UC_CustomerRegistration_Load(object sender, EventArgs e)
		{
			LoadComboBoxes();
			cmbCity.Enabled = false;
			cmbStreet.Enabled = false;
			cmbHouse.Enabled = false;
			cmbApartment.Enabled = false;
		}

		private void cmbCountry_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (cmbCountry.SelectedValue != null && int.TryParse(cmbCountry.SelectedValue.ToString(), out int countryId))
			{
				cmbCity.Enabled = true;
				var parameters = new Dictionary<string, object>
				{
					{ "@country_id", countryId }
				};
				utils.LoadComboBox(cmbCity, "exec ui_GetCitiesByCountryId @country_id", "name", "id", parameters);
			}
			else
			{
				cmbCity.Enabled = false;
				cmbCity.DataSource = null;
			}
		}

		private void cmbCity_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (cmbCity.SelectedValue != null && int.TryParse(cmbCity.SelectedValue.ToString(), out int cityId))
			{
				cmbStreet.Enabled = true;
				var parameters = new Dictionary<string, object>
				{
					{ "@city_id", cityId }
				};
				utils.LoadComboBox(cmbStreet, "exec ui_GetStreetsByCityId @city_id", "name", "id", parameters);
			}
			else
			{
				cmbStreet.Enabled = false;
				cmbStreet.DataSource = null;
			}
		}

		private void cmbStreet_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (cmbStreet.SelectedValue != null && int.TryParse(cmbStreet.SelectedValue.ToString(), out int streetId))
			{
				cmbHouse.Enabled = true;
				var parameters = new Dictionary<string, object>
				{
					{ "@street_id", streetId }
				};
				utils.LoadComboBox(cmbHouse, "exec ui_GetHousesByStreetId @street_id", "house_number", "id", parameters);
			}
			else
			{
				cmbHouse.Enabled = false;
				cmbHouse.DataSource = null;
			}
		}

		private void cmbHouse_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (cmbHouse.SelectedValue != null && int.TryParse(cmbHouse.SelectedValue.ToString(), out int houseId))
			{
				cmbApartment.Enabled = true;
				var parameters = new Dictionary<string, object>
				{
					{ "@house_id", houseId }
				};
				utils.LoadComboBox(cmbApartment, "exec ui_GetLocationsByHouseId @house_id", "name", "id", parameters);
			}
			else
			{
				cmbApartment.Enabled = false;
				cmbApartment.DataSource = null;
			}
		}

		private void cmbRoom_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (cmbRoom.SelectedValue != null && int.TryParse(cmbRoom.SelectedValue.ToString(), out int roomId))
			{
				var parameters = new Dictionary<string, object>
				{
					{ "@room_id", roomId }
				};

				DataTable dt = databaseHelper.GetTable("exec ui_GetPriceByRoomId @room_id", parameters);

				if (dt.Rows.Count > 0)
				{
					txtPrice.Text = dt.Rows[0][0].ToString();
				}
				else
				{
					Console.WriteLine("false");
					txtPrice.Text = "";
				}
			}
			else
			{
				txtPrice.Text = "";
			}
		}

		private void LoadAvailableRooms()
		{
			int roomTypeId = 0;
			int bedTypeId = 0;

			if (cmbRoomType.SelectedValue != null)
				int.TryParse(cmbRoomType.SelectedValue.ToString(), out roomTypeId);
			if (cmbBed.SelectedValue != null)
				int.TryParse(cmbBed.SelectedValue.ToString(), out bedTypeId);

			var parameters = new Dictionary<string, object>
			{
				{ "@room_type", roomTypeId == 0 ? DBNull.Value : (object)roomTypeId },
				{ "@bed", bedTypeId == 0 ? DBNull.Value : (object)bedTypeId }
			};

			utils.LoadComboBox(cmbRoom, "exec ui_GetFilteredRooms @room_type, @bed", "room_no", "room_id", parameters);
		}

		private void cmbBed_SelectedIndexChanged(object sender, EventArgs e)
		{
			LoadAvailableRooms();
		}

		private void cmbRoomType_SelectedIndexChanged(object sender, EventArgs e)
		{
			LoadAvailableRooms();
		}

		private void btnAlloteRoom_Click(object sender, EventArgs e)
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
					{ "@nationality", cmbNationality.SelectedValue },
					{ "@gender", cmbGender.SelectedValue },
					{ "@dob", dtBirth.Value.Date },
					{ "@idproof", txtID.Text.Trim() },
					{ "@location", cmbApartment.SelectedValue },
					{ "@checkin", dtCheckIn.Value },
					{ "@room_id", cmbRoom.SelectedValue }
				};

				databaseHelper.ExecuteStoredProcedure("InsertCustomer", parameters);

				MessageBox.Show("Customer registered successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
					cmbNationality.SelectedIndex == -1 ||
					cmbGender.SelectedIndex == -1 ||
					cmbCountry.SelectedIndex == -1 ||
					cmbCity.SelectedIndex == -1 ||
					cmbStreet.SelectedIndex == -1 ||
					cmbHouse.SelectedIndex == -1 ||
					cmbApartment.SelectedIndex == -1 ||
					string.IsNullOrWhiteSpace(txtID.Text) ||
					cmbRoom.SelectedIndex == -1);
		}

		private void ClearForm()
		{
			txtName.Clear();
			txtPhone.Clear();
			txtID.Clear();
			txtPrice.Clear();

			cmbNationality.SelectedIndex = -1;
			cmbGender.SelectedIndex = -1;
			cmbCountry.SelectedIndex = -1;
			cmbCity.SelectedIndex = -1;
			cmbStreet.SelectedIndex = -1;
			cmbHouse.SelectedIndex = -1;
			cmbApartment.SelectedIndex = -1;
			cmbBed.SelectedIndex = -1;
			cmbRoomType.SelectedIndex = -1;
			cmbRoom.SelectedIndex = -1;

			dtBirth.Value = DateTime.Today;
			dtCheckIn.Value = DateTime.Today;

			cmbCity.Enabled = false;
			cmbStreet.Enabled = false;
			cmbHouse.Enabled = false;
			cmbApartment.Enabled = false;
		}

		private void UC_CustomerRegistration_Leave(object sender, EventArgs e)
		{
			ClearForm();
		}
	}
}
