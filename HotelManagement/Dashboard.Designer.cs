namespace HotelManagement
{
	partial class Dashboard
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
			this.panel1 = new System.Windows.Forms.Panel();
			this.MovingPanel = new System.Windows.Forms.Panel();
			this.panel2 = new System.Windows.Forms.Panel();
			this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
			this.btnMinimize = new Guna.UI2.WinForms.Guna2CircleButton();
			this.btnExit = new Guna.UI2.WinForms.Guna2CircleButton();
			this.btnEmployee = new Guna.UI2.WinForms.Guna2Button();
			this.btnCustomerDetail = new Guna.UI2.WinForms.Guna2Button();
			this.btnCheckOut = new Guna.UI2.WinForms.Guna2Button();
			this.btnCustomerRegistration = new Guna.UI2.WinForms.Guna2Button();
			this.btnAddRoom = new Guna.UI2.WinForms.Guna2Button();
			this.guna2Elipse2 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
			this.uC_AddRoom1 = new HotelManagement.All_User_Control.UC_AddRoom();
			this.uC_CustomerRegistration1 = new HotelManagement.All_User_Control.UC_CustomerRegistration();
			this.panel1.SuspendLayout();
			this.panel2.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
			this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel1.Controls.Add(this.MovingPanel);
			this.panel1.Controls.Add(this.btnEmployee);
			this.panel1.Controls.Add(this.btnCustomerDetail);
			this.panel1.Controls.Add(this.btnCheckOut);
			this.panel1.Controls.Add(this.btnCustomerRegistration);
			this.panel1.Controls.Add(this.btnAddRoom);
			this.panel1.Location = new System.Drawing.Point(100, 22);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(1545, 139);
			this.panel1.TabIndex = 0;
			// 
			// MovingPanel
			// 
			this.MovingPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.MovingPanel.Location = new System.Drawing.Point(37, 106);
			this.MovingPanel.Name = "MovingPanel";
			this.MovingPanel.Size = new System.Drawing.Size(249, 6);
			this.MovingPanel.TabIndex = 4;
			// 
			// panel2
			// 
			this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.panel2.Controls.Add(this.uC_CustomerRegistration1);
			this.panel2.Controls.Add(this.uC_AddRoom1);
			this.panel2.Location = new System.Drawing.Point(24, 185);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(1621, 646);
			this.panel2.TabIndex = 1;
			// 
			// guna2Elipse1
			// 
			this.guna2Elipse1.BorderRadius = 30;
			this.guna2Elipse1.TargetControl = this;
			// 
			// btnMinimize
			// 
			this.btnMinimize.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
			this.btnMinimize.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
			this.btnMinimize.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
			this.btnMinimize.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
			this.btnMinimize.FillColor = System.Drawing.Color.Empty;
			this.btnMinimize.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.btnMinimize.ForeColor = System.Drawing.Color.White;
			this.btnMinimize.Image = ((System.Drawing.Image)(resources.GetObject("btnMinimize.Image")));
			this.btnMinimize.ImageSize = new System.Drawing.Size(30, 30);
			this.btnMinimize.Location = new System.Drawing.Point(12, 68);
			this.btnMinimize.Name = "btnMinimize";
			this.btnMinimize.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
			this.btnMinimize.Size = new System.Drawing.Size(71, 53);
			this.btnMinimize.TabIndex = 3;
			this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
			// 
			// btnExit
			// 
			this.btnExit.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
			this.btnExit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
			this.btnExit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
			this.btnExit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
			this.btnExit.FillColor = System.Drawing.Color.Empty;
			this.btnExit.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.btnExit.ForeColor = System.Drawing.Color.White;
			this.btnExit.Image = global::HotelManagement.Properties.Resources.cancel_50px;
			this.btnExit.ImageSize = new System.Drawing.Size(30, 30);
			this.btnExit.Location = new System.Drawing.Point(12, 13);
			this.btnExit.Name = "btnExit";
			this.btnExit.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
			this.btnExit.Size = new System.Drawing.Size(71, 53);
			this.btnExit.TabIndex = 2;
			this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
			// 
			// btnEmployee
			// 
			this.btnEmployee.BorderRadius = 26;
			this.btnEmployee.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
			this.btnEmployee.CheckedState.FillColor = System.Drawing.Color.White;
			this.btnEmployee.CheckedState.ForeColor = System.Drawing.Color.Black;
			this.btnEmployee.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
			this.btnEmployee.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
			this.btnEmployee.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
			this.btnEmployee.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
			this.btnEmployee.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
			this.btnEmployee.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold);
			this.btnEmployee.ForeColor = System.Drawing.Color.White;
			this.btnEmployee.Image = ((System.Drawing.Image)(resources.GetObject("btnEmployee.Image")));
			this.btnEmployee.ImageSize = new System.Drawing.Size(50, 50);
			this.btnEmployee.Location = new System.Drawing.Point(1237, 22);
			this.btnEmployee.Name = "btnEmployee";
			this.btnEmployee.Size = new System.Drawing.Size(289, 87);
			this.btnEmployee.TabIndex = 4;
			this.btnEmployee.Text = "Employee";
			this.btnEmployee.Click += new System.EventHandler(this.btnEmployee_Click);
			// 
			// btnCustomerDetail
			// 
			this.btnCustomerDetail.BorderRadius = 26;
			this.btnCustomerDetail.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
			this.btnCustomerDetail.CheckedState.FillColor = System.Drawing.Color.White;
			this.btnCustomerDetail.CheckedState.ForeColor = System.Drawing.Color.Black;
			this.btnCustomerDetail.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
			this.btnCustomerDetail.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
			this.btnCustomerDetail.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
			this.btnCustomerDetail.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
			this.btnCustomerDetail.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
			this.btnCustomerDetail.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold);
			this.btnCustomerDetail.ForeColor = System.Drawing.Color.White;
			this.btnCustomerDetail.Image = ((System.Drawing.Image)(resources.GetObject("btnCustomerDetail.Image")));
			this.btnCustomerDetail.ImageSize = new System.Drawing.Size(30, 30);
			this.btnCustomerDetail.Location = new System.Drawing.Point(942, 22);
			this.btnCustomerDetail.Name = "btnCustomerDetail";
			this.btnCustomerDetail.Size = new System.Drawing.Size(289, 87);
			this.btnCustomerDetail.TabIndex = 3;
			this.btnCustomerDetail.Text = "Customer Details";
			this.btnCustomerDetail.Click += new System.EventHandler(this.btnCustomerDetail_Click);
			// 
			// btnCheckOut
			// 
			this.btnCheckOut.BorderRadius = 26;
			this.btnCheckOut.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
			this.btnCheckOut.CheckedState.FillColor = System.Drawing.Color.White;
			this.btnCheckOut.CheckedState.ForeColor = System.Drawing.Color.Black;
			this.btnCheckOut.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
			this.btnCheckOut.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
			this.btnCheckOut.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
			this.btnCheckOut.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
			this.btnCheckOut.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
			this.btnCheckOut.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold);
			this.btnCheckOut.ForeColor = System.Drawing.Color.White;
			this.btnCheckOut.Image = ((System.Drawing.Image)(resources.GetObject("btnCheckOut.Image")));
			this.btnCheckOut.ImageSize = new System.Drawing.Size(40, 40);
			this.btnCheckOut.Location = new System.Drawing.Point(647, 22);
			this.btnCheckOut.Name = "btnCheckOut";
			this.btnCheckOut.Size = new System.Drawing.Size(289, 87);
			this.btnCheckOut.TabIndex = 2;
			this.btnCheckOut.Text = "Check Out";
			this.btnCheckOut.Click += new System.EventHandler(this.btnCheckOut_Click);
			// 
			// btnCustomerRegistration
			// 
			this.btnCustomerRegistration.BorderRadius = 26;
			this.btnCustomerRegistration.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
			this.btnCustomerRegistration.CheckedState.FillColor = System.Drawing.Color.White;
			this.btnCustomerRegistration.CheckedState.ForeColor = System.Drawing.Color.Black;
			this.btnCustomerRegistration.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
			this.btnCustomerRegistration.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
			this.btnCustomerRegistration.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
			this.btnCustomerRegistration.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
			this.btnCustomerRegistration.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
			this.btnCustomerRegistration.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold);
			this.btnCustomerRegistration.ForeColor = System.Drawing.Color.White;
			this.btnCustomerRegistration.Image = ((System.Drawing.Image)(resources.GetObject("btnCustomerRegistration.Image")));
			this.btnCustomerRegistration.ImageSize = new System.Drawing.Size(35, 35);
			this.btnCustomerRegistration.Location = new System.Drawing.Point(309, 22);
			this.btnCustomerRegistration.Name = "btnCustomerRegistration";
			this.btnCustomerRegistration.Size = new System.Drawing.Size(332, 87);
			this.btnCustomerRegistration.TabIndex = 1;
			this.btnCustomerRegistration.Text = "Customer Registration";
			this.btnCustomerRegistration.Click += new System.EventHandler(this.btnCustomerRegistration_Click);
			// 
			// btnAddRoom
			// 
			this.btnAddRoom.BorderRadius = 26;
			this.btnAddRoom.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
			this.btnAddRoom.CheckedState.FillColor = System.Drawing.Color.White;
			this.btnAddRoom.CheckedState.ForeColor = System.Drawing.Color.Black;
			this.btnAddRoom.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
			this.btnAddRoom.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
			this.btnAddRoom.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
			this.btnAddRoom.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
			this.btnAddRoom.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
			this.btnAddRoom.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnAddRoom.ForeColor = System.Drawing.Color.White;
			this.btnAddRoom.Image = ((System.Drawing.Image)(resources.GetObject("btnAddRoom.Image")));
			this.btnAddRoom.ImageSize = new System.Drawing.Size(40, 40);
			this.btnAddRoom.Location = new System.Drawing.Point(14, 22);
			this.btnAddRoom.Name = "btnAddRoom";
			this.btnAddRoom.Size = new System.Drawing.Size(289, 87);
			this.btnAddRoom.TabIndex = 0;
			this.btnAddRoom.Text = "Add Room";
			this.btnAddRoom.Click += new System.EventHandler(this.btnAddRoom_Click);
			// 
			// guna2Elipse2
			// 
			this.guna2Elipse2.BorderRadius = 30;
			this.guna2Elipse2.TargetControl = this;
			// 
			// uC_AddRoom1
			// 
			this.uC_AddRoom1.BackColor = System.Drawing.Color.White;
			this.uC_AddRoom1.Location = new System.Drawing.Point(0, 3);
			this.uC_AddRoom1.Name = "uC_AddRoom1";
			this.uC_AddRoom1.Size = new System.Drawing.Size(1619, 651);
			this.uC_AddRoom1.TabIndex = 0;
			// 
			// uC_CustomerRegistration1
			// 
			this.uC_CustomerRegistration1.BackColor = System.Drawing.Color.White;
			this.uC_CustomerRegistration1.Location = new System.Drawing.Point(0, 3);
			this.uC_CustomerRegistration1.Name = "uC_CustomerRegistration1";
			this.uC_CustomerRegistration1.Size = new System.Drawing.Size(1618, 640);
			this.uC_CustomerRegistration1.TabIndex = 1;
			// 
			// Dashboard
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
			this.ClientSize = new System.Drawing.Size(1661, 845);
			this.Controls.Add(this.btnMinimize);
			this.Controls.Add(this.btnExit);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "Dashboard";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Dashboard";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.Load += new System.EventHandler(this.Dashboard_Load);
			this.panel1.ResumeLayout(false);
			this.panel2.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Panel panel2;
		private Guna.UI2.WinForms.Guna2CircleButton btnExit;
		private Guna.UI2.WinForms.Guna2CircleButton btnMinimize;
		private Guna.UI2.WinForms.Guna2Button btnAddRoom;
		private Guna.UI2.WinForms.Guna2Button btnCustomerRegistration;
		private Guna.UI2.WinForms.Guna2Button btnEmployee;
		private Guna.UI2.WinForms.Guna2Button btnCustomerDetail;
		private Guna.UI2.WinForms.Guna2Button btnCheckOut;
		private System.Windows.Forms.Panel MovingPanel;
		private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
		private All_User_Control.UC_AddRoom uC_AddRoom1;
		private Guna.UI2.WinForms.Guna2Elipse guna2Elipse2;
		private All_User_Control.UC_CustomerRegistration uC_CustomerRegistration1;
	}
}