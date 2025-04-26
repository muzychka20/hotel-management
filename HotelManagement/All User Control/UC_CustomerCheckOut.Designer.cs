namespace HotelManagement.All_User_Control
{
	partial class UC_CustomerCheckOut
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.dataGridCustomerCheckOut = new Guna.UI2.WinForms.Guna2DataGridView();
			this.label1 = new System.Windows.Forms.Label();
			this.dtCheckOut = new Guna.UI2.WinForms.Guna2DateTimePicker();
			this.label7 = new System.Windows.Forms.Label();
			this.btnCheckOut = new Guna.UI2.WinForms.Guna2Button();
			this.cmbRoom = new Guna.UI2.WinForms.Guna2ComboBox();
			this.cmbCustomerName = new Guna.UI2.WinForms.Guna2ComboBox();
			((System.ComponentModel.ISupportInitialize)(this.dataGridCustomerCheckOut)).BeginInit();
			this.SuspendLayout();
			// 
			// guna2Elipse1
			// 
			this.guna2Elipse1.BorderRadius = 30;
			this.guna2Elipse1.TargetControl = this;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(50, 28);
			this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(293, 33);
			this.label2.TabIndex = 6;
			this.label2.Text = "Customer Check Out";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(52, 445);
			this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(53, 20);
			this.label3.TabIndex = 7;
			this.label3.Text = "Name";
			// 
			// dataGridCustomerCheckOut
			// 
			dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
			this.dataGridCustomerCheckOut.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
			this.dataGridCustomerCheckOut.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dataGridCustomerCheckOut.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
			this.dataGridCustomerCheckOut.ColumnHeadersHeight = 4;
			this.dataGridCustomerCheckOut.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
			dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
			dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
			dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dataGridCustomerCheckOut.DefaultCellStyle = dataGridViewCellStyle3;
			this.dataGridCustomerCheckOut.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
			this.dataGridCustomerCheckOut.Location = new System.Drawing.Point(56, 83);
			this.dataGridCustomerCheckOut.Name = "dataGridCustomerCheckOut";
			this.dataGridCustomerCheckOut.RowHeadersVisible = false;
			this.dataGridCustomerCheckOut.Size = new System.Drawing.Size(1102, 342);
			this.dataGridCustomerCheckOut.TabIndex = 9;
			this.dataGridCustomerCheckOut.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
			this.dataGridCustomerCheckOut.ThemeStyle.AlternatingRowsStyle.Font = null;
			this.dataGridCustomerCheckOut.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
			this.dataGridCustomerCheckOut.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
			this.dataGridCustomerCheckOut.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
			this.dataGridCustomerCheckOut.ThemeStyle.BackColor = System.Drawing.Color.White;
			this.dataGridCustomerCheckOut.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
			this.dataGridCustomerCheckOut.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
			this.dataGridCustomerCheckOut.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			this.dataGridCustomerCheckOut.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dataGridCustomerCheckOut.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
			this.dataGridCustomerCheckOut.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
			this.dataGridCustomerCheckOut.ThemeStyle.HeaderStyle.Height = 4;
			this.dataGridCustomerCheckOut.ThemeStyle.ReadOnly = false;
			this.dataGridCustomerCheckOut.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
			this.dataGridCustomerCheckOut.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
			this.dataGridCustomerCheckOut.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dataGridCustomerCheckOut.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
			this.dataGridCustomerCheckOut.ThemeStyle.RowsStyle.Height = 22;
			this.dataGridCustomerCheckOut.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
			this.dataGridCustomerCheckOut.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(381, 445);
			this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(76, 20);
			this.label1.TabIndex = 10;
			this.label1.Text = "Room No";
			// 
			// dtCheckOut
			// 
			this.dtCheckOut.Animated = true;
			this.dtCheckOut.AutoRoundedCorners = true;
			this.dtCheckOut.BackColor = System.Drawing.Color.Transparent;
			this.dtCheckOut.Checked = true;
			this.dtCheckOut.CheckedState.FillColor = System.Drawing.Color.White;
			this.dtCheckOut.CheckedState.ForeColor = System.Drawing.Color.Black;
			this.dtCheckOut.FillColor = System.Drawing.Color.White;
			this.dtCheckOut.Font = new System.Drawing.Font("Segoe UI", 10.8F);
			this.dtCheckOut.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtCheckOut.IndicateFocus = true;
			this.dtCheckOut.Location = new System.Drawing.Point(705, 471);
			this.dtCheckOut.Margin = new System.Windows.Forms.Padding(2);
			this.dtCheckOut.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
			this.dtCheckOut.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
			this.dtCheckOut.Name = "dtCheckOut";
			this.dtCheckOut.Size = new System.Drawing.Size(228, 29);
			this.dtCheckOut.TabIndex = 16;
			this.dtCheckOut.UseTransparentBackground = true;
			this.dtCheckOut.Value = new System.DateTime(2025, 4, 21, 20, 56, 32, 515);
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.Location = new System.Drawing.Point(701, 445);
			this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(89, 20);
			this.label7.TabIndex = 15;
			this.label7.Text = "Check Out";
			// 
			// btnCheckOut
			// 
			this.btnCheckOut.BorderRadius = 18;
			this.btnCheckOut.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
			this.btnCheckOut.BorderThickness = 1;
			this.btnCheckOut.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.ToogleButton;
			this.btnCheckOut.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(221)))));
			this.btnCheckOut.CheckedState.ForeColor = System.Drawing.Color.White;
			this.btnCheckOut.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
			this.btnCheckOut.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
			this.btnCheckOut.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
			this.btnCheckOut.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
			this.btnCheckOut.FillColor = System.Drawing.Color.White;
			this.btnCheckOut.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnCheckOut.ForeColor = System.Drawing.Color.Black;
			this.btnCheckOut.Location = new System.Drawing.Point(979, 461);
			this.btnCheckOut.Margin = new System.Windows.Forms.Padding(2);
			this.btnCheckOut.Name = "btnCheckOut";
			this.btnCheckOut.Size = new System.Drawing.Size(179, 39);
			this.btnCheckOut.TabIndex = 30;
			this.btnCheckOut.Text = "Check Out";
			// 
			// cmbRoom
			// 
			this.cmbRoom.BackColor = System.Drawing.Color.Transparent;
			this.cmbRoom.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
			this.cmbRoom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbRoom.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.cmbRoom.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.cmbRoom.Font = new System.Drawing.Font("Segoe UI", 10.8F);
			this.cmbRoom.ForeColor = System.Drawing.Color.Black;
			this.cmbRoom.ItemHeight = 30;
			this.cmbRoom.Location = new System.Drawing.Point(385, 464);
			this.cmbRoom.Margin = new System.Windows.Forms.Padding(2);
			this.cmbRoom.Name = "cmbRoom";
			this.cmbRoom.Size = new System.Drawing.Size(287, 36);
			this.cmbRoom.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
			this.cmbRoom.TabIndex = 36;
			// 
			// cmbCustomerName
			// 
			this.cmbCustomerName.BackColor = System.Drawing.Color.Transparent;
			this.cmbCustomerName.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
			this.cmbCustomerName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbCustomerName.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.cmbCustomerName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.cmbCustomerName.Font = new System.Drawing.Font("Segoe UI", 10.8F);
			this.cmbCustomerName.ForeColor = System.Drawing.Color.Black;
			this.cmbCustomerName.ItemHeight = 30;
			this.cmbCustomerName.Location = new System.Drawing.Point(56, 464);
			this.cmbCustomerName.Margin = new System.Windows.Forms.Padding(2);
			this.cmbCustomerName.Name = "cmbCustomerName";
			this.cmbCustomerName.Size = new System.Drawing.Size(287, 36);
			this.cmbCustomerName.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
			this.cmbCustomerName.TabIndex = 37;
			// 
			// UC_CustomerCheckOut
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.Controls.Add(this.cmbCustomerName);
			this.Controls.Add(this.cmbRoom);
			this.Controls.Add(this.btnCheckOut);
			this.Controls.Add(this.dtCheckOut);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.dataGridCustomerCheckOut);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Name = "UC_CustomerCheckOut";
			this.Size = new System.Drawing.Size(1214, 520);
			this.Load += new System.EventHandler(this.UC_CustomerCheckOut_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridCustomerCheckOut)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private Guna.UI2.WinForms.Guna2DataGridView dataGridCustomerCheckOut;
		private System.Windows.Forms.Label label1;
		private Guna.UI2.WinForms.Guna2DateTimePicker dtCheckOut;
		private System.Windows.Forms.Label label7;
		private Guna.UI2.WinForms.Guna2Button btnCheckOut;
		private Guna.UI2.WinForms.Guna2ComboBox cmbRoom;
		private Guna.UI2.WinForms.Guna2ComboBox cmbCustomerName;
	}
}
