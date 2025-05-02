namespace HotelManagement.All_User_Control
{
	partial class UC_Employee
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

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_Employee));
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
			this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
			this.label1 = new System.Windows.Forms.Label();
			this.tcEmployee = new System.Windows.Forms.TabControl();
			this.tabEmpReg = new System.Windows.Forms.TabPage();
			this.guna2ImageButton1 = new Guna.UI2.WinForms.Guna2ImageButton();
			this.btnRegisterEmp = new Guna.UI2.WinForms.Guna2Button();
			this.label8 = new System.Windows.Forms.Label();
			this.txtPassword = new Guna.UI2.WinForms.Guna2TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.txtLogin = new Guna.UI2.WinForms.Guna2TextBox();
			this.txtEmail = new Guna.UI2.WinForms.Guna2TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.cmbGender = new Guna.UI2.WinForms.Guna2ComboBox();
			this.label6 = new System.Windows.Forms.Label();
			this.txtPhone = new Guna.UI2.WinForms.Guna2TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.txtName = new Guna.UI2.WinForms.Guna2TextBox();
			this.tabEmpDetails = new System.Windows.Forms.TabPage();
			this.dataGridViewEmp = new Guna.UI2.WinForms.Guna2DataGridView();
			this.label9 = new System.Windows.Forms.Label();
			this.tabEmpDelete = new System.Windows.Forms.TabPage();
			this.dataGridViewEmpForDelete = new Guna.UI2.WinForms.Guna2DataGridView();
			this.btnEmpDelete = new Guna.UI2.WinForms.Guna2Button();
			this.label10 = new System.Windows.Forms.Label();
			this.txtIDEmp = new Guna.UI2.WinForms.Guna2TextBox();
			this.guna2ImageButton2 = new Guna.UI2.WinForms.Guna2ImageButton();
			this.tcEmployee.SuspendLayout();
			this.tabEmpReg.SuspendLayout();
			this.tabEmpDetails.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmp)).BeginInit();
			this.tabEmpDelete.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmpForDelete)).BeginInit();
			this.SuspendLayout();
			// 
			// guna2Elipse1
			// 
			this.guna2Elipse1.BorderRadius = 30;
			this.guna2Elipse1.TargetControl = this;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(50, 28);
			this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(148, 33);
			this.label1.TabIndex = 1;
			this.label1.Text = "Employee";
			// 
			// tcEmployee
			// 
			this.tcEmployee.Controls.Add(this.tabEmpReg);
			this.tcEmployee.Controls.Add(this.tabEmpDetails);
			this.tcEmployee.Controls.Add(this.tabEmpDelete);
			this.tcEmployee.Location = new System.Drawing.Point(56, 82);
			this.tcEmployee.Name = "tcEmployee";
			this.tcEmployee.SelectedIndex = 0;
			this.tcEmployee.Size = new System.Drawing.Size(1110, 414);
			this.tcEmployee.TabIndex = 2;
			this.tcEmployee.SelectedIndexChanged += new System.EventHandler(this.tcEmployee_SelectedIndexChanged);
			// 
			// tabEmpReg
			// 
			this.tabEmpReg.BackColor = System.Drawing.Color.White;
			this.tabEmpReg.Controls.Add(this.guna2ImageButton1);
			this.tabEmpReg.Controls.Add(this.btnRegisterEmp);
			this.tabEmpReg.Controls.Add(this.label8);
			this.tabEmpReg.Controls.Add(this.txtPassword);
			this.tabEmpReg.Controls.Add(this.label7);
			this.tabEmpReg.Controls.Add(this.txtLogin);
			this.tabEmpReg.Controls.Add(this.txtEmail);
			this.tabEmpReg.Controls.Add(this.label5);
			this.tabEmpReg.Controls.Add(this.cmbGender);
			this.tabEmpReg.Controls.Add(this.label6);
			this.tabEmpReg.Controls.Add(this.txtPhone);
			this.tabEmpReg.Controls.Add(this.label4);
			this.tabEmpReg.Controls.Add(this.label2);
			this.tabEmpReg.Controls.Add(this.txtName);
			this.tabEmpReg.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tabEmpReg.Location = new System.Drawing.Point(4, 22);
			this.tabEmpReg.Name = "tabEmpReg";
			this.tabEmpReg.Padding = new System.Windows.Forms.Padding(3);
			this.tabEmpReg.Size = new System.Drawing.Size(1102, 388);
			this.tabEmpReg.TabIndex = 0;
			this.tabEmpReg.Text = "Employee Registration";
			// 
			// guna2ImageButton1
			// 
			this.guna2ImageButton1.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
			this.guna2ImageButton1.HoverState.ImageSize = new System.Drawing.Size(512, 512);
			this.guna2ImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("guna2ImageButton1.Image")));
			this.guna2ImageButton1.ImageOffset = new System.Drawing.Point(0, 0);
			this.guna2ImageButton1.ImageRotate = 0F;
			this.guna2ImageButton1.ImageSize = new System.Drawing.Size(512, 512);
			this.guna2ImageButton1.Location = new System.Drawing.Point(26, 46);
			this.guna2ImageButton1.Name = "guna2ImageButton1";
			this.guna2ImageButton1.PressedState.ImageSize = new System.Drawing.Size(128, 128);
			this.guna2ImageButton1.Size = new System.Drawing.Size(287, 284);
			this.guna2ImageButton1.TabIndex = 31;
			// 
			// btnRegisterEmp
			// 
			this.btnRegisterEmp.BorderRadius = 18;
			this.btnRegisterEmp.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
			this.btnRegisterEmp.BorderThickness = 1;
			this.btnRegisterEmp.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.ToogleButton;
			this.btnRegisterEmp.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(221)))));
			this.btnRegisterEmp.CheckedState.ForeColor = System.Drawing.Color.White;
			this.btnRegisterEmp.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
			this.btnRegisterEmp.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
			this.btnRegisterEmp.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
			this.btnRegisterEmp.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
			this.btnRegisterEmp.FillColor = System.Drawing.Color.White;
			this.btnRegisterEmp.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnRegisterEmp.ForeColor = System.Drawing.Color.Black;
			this.btnRegisterEmp.Location = new System.Drawing.Point(909, 291);
			this.btnRegisterEmp.Margin = new System.Windows.Forms.Padding(2);
			this.btnRegisterEmp.Name = "btnRegisterEmp";
			this.btnRegisterEmp.Size = new System.Drawing.Size(152, 39);
			this.btnRegisterEmp.TabIndex = 30;
			this.btnRegisterEmp.Text = "Register";
			this.btnRegisterEmp.Click += new System.EventHandler(this.btnRegisterEmp_Click);
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.Location = new System.Drawing.Point(734, 118);
			this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(79, 20);
			this.label8.TabIndex = 21;
			this.label8.Text = "Password";
			// 
			// txtPassword
			// 
			this.txtPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txtPassword.DefaultText = "";
			this.txtPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.txtPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
			this.txtPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.txtPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.txtPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.txtPassword.Font = new System.Drawing.Font("Segoe UI", 10.8F);
			this.txtPassword.ForeColor = System.Drawing.Color.Black;
			this.txtPassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.txtPassword.Location = new System.Drawing.Point(737, 139);
			this.txtPassword.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.txtPassword.Name = "txtPassword";
			this.txtPassword.PasswordChar = '*';
			this.txtPassword.PlaceholderText = "Enter Password";
			this.txtPassword.SelectedText = "";
			this.txtPassword.Size = new System.Drawing.Size(325, 37);
			this.txtPassword.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
			this.txtPassword.TabIndex = 20;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.Location = new System.Drawing.Point(733, 42);
			this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(48, 20);
			this.label7.TabIndex = 19;
			this.label7.Text = "Login";
			// 
			// txtLogin
			// 
			this.txtLogin.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txtLogin.DefaultText = "";
			this.txtLogin.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.txtLogin.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
			this.txtLogin.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.txtLogin.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.txtLogin.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.txtLogin.Font = new System.Drawing.Font("Segoe UI", 10.8F);
			this.txtLogin.ForeColor = System.Drawing.Color.Black;
			this.txtLogin.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.txtLogin.Location = new System.Drawing.Point(736, 63);
			this.txtLogin.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.txtLogin.Name = "txtLogin";
			this.txtLogin.PlaceholderText = "Enter Login";
			this.txtLogin.SelectedText = "";
			this.txtLogin.Size = new System.Drawing.Size(325, 37);
			this.txtLogin.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
			this.txtLogin.TabIndex = 18;
			// 
			// txtEmail
			// 
			this.txtEmail.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txtEmail.DefaultText = "";
			this.txtEmail.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.txtEmail.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
			this.txtEmail.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.txtEmail.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.txtEmail.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.txtEmail.Font = new System.Drawing.Font("Segoe UI", 10.8F);
			this.txtEmail.ForeColor = System.Drawing.Color.Black;
			this.txtEmail.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.txtEmail.Location = new System.Drawing.Point(368, 293);
			this.txtEmail.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.txtEmail.Name = "txtEmail";
			this.txtEmail.PlaceholderText = "Enter Email";
			this.txtEmail.SelectedText = "";
			this.txtEmail.Size = new System.Drawing.Size(325, 37);
			this.txtEmail.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
			this.txtEmail.TabIndex = 17;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(365, 272);
			this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(46, 20);
			this.label5.TabIndex = 16;
			this.label5.Text = "Email";
			// 
			// cmbGender
			// 
			this.cmbGender.BackColor = System.Drawing.Color.Transparent;
			this.cmbGender.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
			this.cmbGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbGender.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.cmbGender.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.cmbGender.Font = new System.Drawing.Font("Segoe UI", 10.8F);
			this.cmbGender.ForeColor = System.Drawing.Color.Black;
			this.cmbGender.ItemHeight = 30;
			this.cmbGender.Location = new System.Drawing.Point(370, 216);
			this.cmbGender.Margin = new System.Windows.Forms.Padding(2);
			this.cmbGender.Name = "cmbGender";
			this.cmbGender.Size = new System.Drawing.Size(326, 36);
			this.cmbGender.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
			this.cmbGender.TabIndex = 15;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(367, 196);
			this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(66, 20);
			this.label6.TabIndex = 14;
			this.label6.Text = "Gender";
			// 
			// txtPhone
			// 
			this.txtPhone.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txtPhone.DefaultText = "";
			this.txtPhone.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.txtPhone.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
			this.txtPhone.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.txtPhone.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.txtPhone.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.txtPhone.Font = new System.Drawing.Font("Segoe UI", 10.8F);
			this.txtPhone.ForeColor = System.Drawing.Color.Black;
			this.txtPhone.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.txtPhone.Location = new System.Drawing.Point(369, 139);
			this.txtPhone.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.txtPhone.Name = "txtPhone";
			this.txtPhone.PlaceholderText = "Enter Contact Phone";
			this.txtPhone.SelectedText = "";
			this.txtPhone.Size = new System.Drawing.Size(325, 37);
			this.txtPhone.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
			this.txtPhone.TabIndex = 13;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(366, 118);
			this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(56, 20);
			this.label4.TabIndex = 12;
			this.label4.Text = "Phone";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(365, 42);
			this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(53, 20);
			this.label2.TabIndex = 10;
			this.label2.Text = "Name";
			// 
			// txtName
			// 
			this.txtName.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txtName.DefaultText = "";
			this.txtName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.txtName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
			this.txtName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.txtName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.txtName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.txtName.Font = new System.Drawing.Font("Segoe UI", 10.8F);
			this.txtName.ForeColor = System.Drawing.Color.Black;
			this.txtName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.txtName.Location = new System.Drawing.Point(368, 63);
			this.txtName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.txtName.Name = "txtName";
			this.txtName.PlaceholderText = "Enter Full Name";
			this.txtName.SelectedText = "";
			this.txtName.Size = new System.Drawing.Size(325, 37);
			this.txtName.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
			this.txtName.TabIndex = 9;
			// 
			// tabEmpDetails
			// 
			this.tabEmpDetails.BackColor = System.Drawing.Color.White;
			this.tabEmpDetails.Controls.Add(this.dataGridViewEmp);
			this.tabEmpDetails.Controls.Add(this.label9);
			this.tabEmpDetails.Font = new System.Drawing.Font("Century Gothic", 11.25F);
			this.tabEmpDetails.Location = new System.Drawing.Point(4, 22);
			this.tabEmpDetails.Name = "tabEmpDetails";
			this.tabEmpDetails.Padding = new System.Windows.Forms.Padding(3);
			this.tabEmpDetails.Size = new System.Drawing.Size(1102, 388);
			this.tabEmpDetails.TabIndex = 1;
			this.tabEmpDetails.Text = "Employee Details";
			// 
			// dataGridViewEmp
			// 
			dataGridViewCellStyle13.BackColor = System.Drawing.Color.White;
			this.dataGridViewEmp.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle13;
			this.dataGridViewEmp.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle14.Font = new System.Drawing.Font("Century Gothic", 11.25F);
			dataGridViewCellStyle14.ForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dataGridViewEmp.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle14;
			this.dataGridViewEmp.ColumnHeadersHeight = 4;
			this.dataGridViewEmp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
			dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle15.BackColor = System.Drawing.Color.White;
			dataGridViewCellStyle15.Font = new System.Drawing.Font("Century Gothic", 11.25F);
			dataGridViewCellStyle15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
			dataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
			dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dataGridViewEmp.DefaultCellStyle = dataGridViewCellStyle15;
			this.dataGridViewEmp.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
			this.dataGridViewEmp.Location = new System.Drawing.Point(24, 65);
			this.dataGridViewEmp.Name = "dataGridViewEmp";
			this.dataGridViewEmp.RowHeadersVisible = false;
			this.dataGridViewEmp.Size = new System.Drawing.Size(1054, 302);
			this.dataGridViewEmp.TabIndex = 3;
			this.dataGridViewEmp.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
			this.dataGridViewEmp.ThemeStyle.AlternatingRowsStyle.Font = null;
			this.dataGridViewEmp.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
			this.dataGridViewEmp.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
			this.dataGridViewEmp.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
			this.dataGridViewEmp.ThemeStyle.BackColor = System.Drawing.Color.White;
			this.dataGridViewEmp.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
			this.dataGridViewEmp.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
			this.dataGridViewEmp.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			this.dataGridViewEmp.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Century Gothic", 11.25F);
			this.dataGridViewEmp.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
			this.dataGridViewEmp.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
			this.dataGridViewEmp.ThemeStyle.HeaderStyle.Height = 4;
			this.dataGridViewEmp.ThemeStyle.ReadOnly = false;
			this.dataGridViewEmp.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
			this.dataGridViewEmp.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
			this.dataGridViewEmp.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Century Gothic", 11.25F);
			this.dataGridViewEmp.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
			this.dataGridViewEmp.ThemeStyle.RowsStyle.Height = 22;
			this.dataGridViewEmp.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
			this.dataGridViewEmp.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label9.Location = new System.Drawing.Point(18, 14);
			this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(243, 33);
			this.label9.TabIndex = 2;
			this.label9.Text = "Employee Details";
			// 
			// tabEmpDelete
			// 
			this.tabEmpDelete.BackColor = System.Drawing.Color.White;
			this.tabEmpDelete.Controls.Add(this.dataGridViewEmpForDelete);
			this.tabEmpDelete.Controls.Add(this.btnEmpDelete);
			this.tabEmpDelete.Controls.Add(this.label10);
			this.tabEmpDelete.Controls.Add(this.txtIDEmp);
			this.tabEmpDelete.Controls.Add(this.guna2ImageButton2);
			this.tabEmpDelete.Font = new System.Drawing.Font("Century Gothic", 11.25F);
			this.tabEmpDelete.Location = new System.Drawing.Point(4, 22);
			this.tabEmpDelete.Name = "tabEmpDelete";
			this.tabEmpDelete.Padding = new System.Windows.Forms.Padding(3);
			this.tabEmpDelete.Size = new System.Drawing.Size(1102, 388);
			this.tabEmpDelete.TabIndex = 2;
			this.tabEmpDelete.Text = "Delete Employee";
			// 
			// dataGridViewEmpForDelete
			// 
			dataGridViewCellStyle16.BackColor = System.Drawing.Color.White;
			this.dataGridViewEmpForDelete.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle16;
			this.dataGridViewEmpForDelete.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle17.Font = new System.Drawing.Font("Century Gothic", 11.25F);
			dataGridViewCellStyle17.ForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle17.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle17.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dataGridViewEmpForDelete.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle17;
			this.dataGridViewEmpForDelete.ColumnHeadersHeight = 4;
			this.dataGridViewEmpForDelete.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
			dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle18.BackColor = System.Drawing.Color.White;
			dataGridViewCellStyle18.Font = new System.Drawing.Font("Century Gothic", 11.25F);
			dataGridViewCellStyle18.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
			dataGridViewCellStyle18.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle18.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
			dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dataGridViewEmpForDelete.DefaultCellStyle = dataGridViewCellStyle18;
			this.dataGridViewEmpForDelete.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
			this.dataGridViewEmpForDelete.Location = new System.Drawing.Point(360, 119);
			this.dataGridViewEmpForDelete.Name = "dataGridViewEmpForDelete";
			this.dataGridViewEmpForDelete.RowHeadersVisible = false;
			this.dataGridViewEmpForDelete.Size = new System.Drawing.Size(703, 248);
			this.dataGridViewEmpForDelete.TabIndex = 36;
			this.dataGridViewEmpForDelete.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
			this.dataGridViewEmpForDelete.ThemeStyle.AlternatingRowsStyle.Font = null;
			this.dataGridViewEmpForDelete.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
			this.dataGridViewEmpForDelete.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
			this.dataGridViewEmpForDelete.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
			this.dataGridViewEmpForDelete.ThemeStyle.BackColor = System.Drawing.Color.White;
			this.dataGridViewEmpForDelete.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
			this.dataGridViewEmpForDelete.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
			this.dataGridViewEmpForDelete.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			this.dataGridViewEmpForDelete.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Century Gothic", 11.25F);
			this.dataGridViewEmpForDelete.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
			this.dataGridViewEmpForDelete.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
			this.dataGridViewEmpForDelete.ThemeStyle.HeaderStyle.Height = 4;
			this.dataGridViewEmpForDelete.ThemeStyle.ReadOnly = false;
			this.dataGridViewEmpForDelete.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
			this.dataGridViewEmpForDelete.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
			this.dataGridViewEmpForDelete.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Century Gothic", 11.25F);
			this.dataGridViewEmpForDelete.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
			this.dataGridViewEmpForDelete.ThemeStyle.RowsStyle.Height = 22;
			this.dataGridViewEmpForDelete.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
			this.dataGridViewEmpForDelete.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
			this.dataGridViewEmpForDelete.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewEmpForDelete_CellClick);
			// 
			// btnEmpDelete
			// 
			this.btnEmpDelete.BorderRadius = 18;
			this.btnEmpDelete.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
			this.btnEmpDelete.BorderThickness = 1;
			this.btnEmpDelete.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.ToogleButton;
			this.btnEmpDelete.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(221)))));
			this.btnEmpDelete.CheckedState.ForeColor = System.Drawing.Color.White;
			this.btnEmpDelete.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
			this.btnEmpDelete.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
			this.btnEmpDelete.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
			this.btnEmpDelete.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
			this.btnEmpDelete.FillColor = System.Drawing.Color.White;
			this.btnEmpDelete.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnEmpDelete.ForeColor = System.Drawing.Color.Black;
			this.btnEmpDelete.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
			this.btnEmpDelete.Location = new System.Drawing.Point(911, 59);
			this.btnEmpDelete.Margin = new System.Windows.Forms.Padding(2);
			this.btnEmpDelete.Name = "btnEmpDelete";
			this.btnEmpDelete.Size = new System.Drawing.Size(152, 39);
			this.btnEmpDelete.TabIndex = 35;
			this.btnEmpDelete.Text = "Delete";
			this.btnEmpDelete.Click += new System.EventHandler(this.btnEmpDelete_Click);
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label10.Location = new System.Drawing.Point(356, 38);
			this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(25, 20);
			this.label10.TabIndex = 34;
			this.label10.Text = "ID";
			// 
			// txtIDEmp
			// 
			this.txtIDEmp.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txtIDEmp.DefaultText = "";
			this.txtIDEmp.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.txtIDEmp.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
			this.txtIDEmp.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.txtIDEmp.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.txtIDEmp.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.txtIDEmp.Font = new System.Drawing.Font("Segoe UI", 10.8F);
			this.txtIDEmp.ForeColor = System.Drawing.Color.Black;
			this.txtIDEmp.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.txtIDEmp.Location = new System.Drawing.Point(359, 59);
			this.txtIDEmp.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.txtIDEmp.Name = "txtIDEmp";
			this.txtIDEmp.PlaceholderText = "Enter ID";
			this.txtIDEmp.SelectedText = "";
			this.txtIDEmp.Size = new System.Drawing.Size(325, 37);
			this.txtIDEmp.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
			this.txtIDEmp.TabIndex = 33;
			// 
			// guna2ImageButton2
			// 
			this.guna2ImageButton2.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
			this.guna2ImageButton2.HoverState.ImageSize = new System.Drawing.Size(512, 512);
			this.guna2ImageButton2.Image = ((System.Drawing.Image)(resources.GetObject("guna2ImageButton2.Image")));
			this.guna2ImageButton2.ImageOffset = new System.Drawing.Point(0, 0);
			this.guna2ImageButton2.ImageRotate = 0F;
			this.guna2ImageButton2.ImageSize = new System.Drawing.Size(512, 512);
			this.guna2ImageButton2.Location = new System.Drawing.Point(26, 46);
			this.guna2ImageButton2.Name = "guna2ImageButton2";
			this.guna2ImageButton2.PressedState.ImageSize = new System.Drawing.Size(128, 128);
			this.guna2ImageButton2.Size = new System.Drawing.Size(287, 284);
			this.guna2ImageButton2.TabIndex = 32;
			// 
			// UC_Employee
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.Controls.Add(this.tcEmployee);
			this.Controls.Add(this.label1);
			this.Name = "UC_Employee";
			this.Size = new System.Drawing.Size(1214, 520);
			this.Load += new System.EventHandler(this.UC_Employee_Load);
			this.Leave += new System.EventHandler(this.UC_Employee_Leave);
			this.tcEmployee.ResumeLayout(false);
			this.tabEmpReg.ResumeLayout(false);
			this.tabEmpReg.PerformLayout();
			this.tabEmpDetails.ResumeLayout(false);
			this.tabEmpDetails.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmp)).EndInit();
			this.tabEmpDelete.ResumeLayout(false);
			this.tabEmpDelete.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmpForDelete)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TabControl tcEmployee;
		private System.Windows.Forms.TabPage tabEmpReg;
		private System.Windows.Forms.TabPage tabEmpDetails;
		private System.Windows.Forms.TabPage tabEmpDelete;
		private System.Windows.Forms.Label label2;
		private Guna.UI2.WinForms.Guna2TextBox txtName;
		private Guna.UI2.WinForms.Guna2TextBox txtPhone;
		private System.Windows.Forms.Label label4;
		private Guna.UI2.WinForms.Guna2ComboBox cmbGender;
		private System.Windows.Forms.Label label6;
		private Guna.UI2.WinForms.Guna2TextBox txtEmail;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label7;
		private Guna.UI2.WinForms.Guna2TextBox txtLogin;
		private System.Windows.Forms.Label label8;
		private Guna.UI2.WinForms.Guna2TextBox txtPassword;
		private Guna.UI2.WinForms.Guna2Button btnRegisterEmp;
		private Guna.UI2.WinForms.Guna2ImageButton guna2ImageButton1;
		private Guna.UI2.WinForms.Guna2DataGridView dataGridViewEmp;
		private System.Windows.Forms.Label label9;
		private Guna.UI2.WinForms.Guna2Button btnEmpDelete;
		private System.Windows.Forms.Label label10;
		private Guna.UI2.WinForms.Guna2TextBox txtIDEmp;
		private Guna.UI2.WinForms.Guna2ImageButton guna2ImageButton2;
		private Guna.UI2.WinForms.Guna2DataGridView dataGridViewEmpForDelete;
	}
}
