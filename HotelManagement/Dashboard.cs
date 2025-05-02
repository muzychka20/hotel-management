using HotelManagement.All_User_Control;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;


namespace HotelManagement
{
	public partial class Dashboard : MovableForm
	{
		public Dashboard()
		{
			InitializeComponent();
			EnableWindowDrag(panel1);
			MovingPanel.Left = btnAddRoom.Left + 15;
			MovingPanel.Width = btnAddRoom.Width - 30;
		}

		private void btnExit_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void btnCustomerRegistration_Click(object sender, EventArgs e)
		{
			MovingPanel.Left = btnCustomerRegistration.Left + 15;
			MovingPanel.Width = btnCustomerRegistration.Width - 30;
			uC_CustomerRegistration1.Visible = true;
			uC_CustomerRegistration1.BringToFront();
		}

		private void btnAddRoom_Click(object sender, EventArgs e)
		{
			MovingPanel.Left = btnAddRoom.Left + 15;
			MovingPanel.Width = btnAddRoom.Width - 30;
			uC_AddRoom1.Visible = true;
			uC_AddRoom1.BringToFront();
		}

		private void btnCheckOut_Click(object sender, EventArgs e)
		{
			MovingPanel.Left = btnCheckOut.Left + 15;
			MovingPanel.Width = btnCheckOut.Width - 30;
			uC_CustomerCheckOut1.Visible = true;
			uC_CustomerCheckOut1.BringToFront();
		}

		private void btnCustomerDetail_Click(object sender, EventArgs e)
		{
			MovingPanel.Left = btnCustomerDetail.Left + 15;
			MovingPanel.Width = btnCustomerDetail.Width - 30;
			uC_CustomerDetails1.Visible = true;
			uC_CustomerDetails1.BringToFront();
		}

		private void btnEmployee_Click(object sender, EventArgs e)
		{
			MovingPanel.Left = btnEmployee.Left + 15;
			MovingPanel.Width = btnEmployee.Width - 30;
			uC_Employee1.Visible = true;
			uC_Employee1.BringToFront();
		}

		private void btnMinimize_Click(object sender, EventArgs e)
		{
			this.WindowState = FormWindowState.Minimized;
		}

		private void Dashboard_Load(object sender, EventArgs e)
		{
			uC_AddRoom1.Visible = false;
			uC_CustomerRegistration1.Visible = false;
			uC_CustomerCheckOut1.Visible = false;
			uC_CustomerDetails1.Visible = false;
			uC_Employee1.Visible = false;
			btnAddRoom.PerformClick();
		}
	}
}
