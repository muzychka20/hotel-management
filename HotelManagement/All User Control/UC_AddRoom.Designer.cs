﻿namespace HotelManagement.All_User_Control
{
	partial class UC_AddRoom
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
			this.label1 = new System.Windows.Forms.Label();
			this.DataGridView1 = new Guna.UI2.WinForms.Guna2DataGridView();
			this.label2 = new System.Windows.Forms.Label();
			this.txtRoomNo = new Guna.UI2.WinForms.Guna2TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.txtPrice = new Guna.UI2.WinForms.Guna2TextBox();
			this.txtType = new Guna.UI2.WinForms.Guna2ComboBox();
			this.txtBed = new Guna.UI2.WinForms.Guna2ComboBox();
			this.btnAddRoom = new Guna.UI2.WinForms.Guna2Button();
			this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
			((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(40, 22);
			this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(226, 33);
			this.label1.TabIndex = 0;
			this.label1.Text = "Add New Room";
			// 
			// DataGridView1
			// 
			dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
			this.DataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
			this.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.DataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
			this.DataGridView1.ColumnHeadersHeight = 4;
			this.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
			dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
			dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
			dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
			dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.DataGridView1.DefaultCellStyle = dataGridViewCellStyle6;
			this.DataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
			this.DataGridView1.Location = new System.Drawing.Point(45, 66);
			this.DataGridView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.DataGridView1.Name = "DataGridView1";
			this.DataGridView1.RowHeadersVisible = false;
			this.DataGridView1.RowHeadersWidth = 51;
			this.DataGridView1.RowTemplate.Height = 24;
			this.DataGridView1.Size = new System.Drawing.Size(728, 429);
			this.DataGridView1.TabIndex = 1;
			this.DataGridView1.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
			this.DataGridView1.ThemeStyle.AlternatingRowsStyle.Font = null;
			this.DataGridView1.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
			this.DataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
			this.DataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
			this.DataGridView1.ThemeStyle.BackColor = System.Drawing.Color.White;
			this.DataGridView1.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
			this.DataGridView1.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
			this.DataGridView1.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			this.DataGridView1.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.DataGridView1.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
			this.DataGridView1.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
			this.DataGridView1.ThemeStyle.HeaderStyle.Height = 4;
			this.DataGridView1.ThemeStyle.ReadOnly = false;
			this.DataGridView1.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
			this.DataGridView1.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
			this.DataGridView1.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.DataGridView1.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
			this.DataGridView1.ThemeStyle.RowsStyle.Height = 24;
			this.DataGridView1.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
			this.DataGridView1.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(822, 66);
			this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(113, 20);
			this.label2.TabIndex = 2;
			this.label2.Text = "Room Number";
			// 
			// txtRoomNo
			// 
			this.txtRoomNo.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txtRoomNo.DefaultText = "";
			this.txtRoomNo.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.txtRoomNo.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
			this.txtRoomNo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.txtRoomNo.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.txtRoomNo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.txtRoomNo.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtRoomNo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.txtRoomNo.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.txtRoomNo.Location = new System.Drawing.Point(825, 87);
			this.txtRoomNo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.txtRoomNo.Name = "txtRoomNo";
			this.txtRoomNo.PlaceholderText = "";
			this.txtRoomNo.SelectedText = "";
			this.txtRoomNo.Size = new System.Drawing.Size(325, 37);
			this.txtRoomNo.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
			this.txtRoomNo.TabIndex = 3;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(822, 167);
			this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(88, 20);
			this.label3.TabIndex = 4;
			this.label3.Text = "Room Type";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(822, 255);
			this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(38, 20);
			this.label4.TabIndex = 5;
			this.label4.Text = "Bed";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(822, 350);
			this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(46, 20);
			this.label5.TabIndex = 6;
			this.label5.Text = "Price";
			// 
			// txtPrice
			// 
			this.txtPrice.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txtPrice.DefaultText = "";
			this.txtPrice.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.txtPrice.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
			this.txtPrice.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.txtPrice.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.txtPrice.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.txtPrice.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.txtPrice.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.txtPrice.Location = new System.Drawing.Point(825, 371);
			this.txtPrice.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.txtPrice.Name = "txtPrice";
			this.txtPrice.PlaceholderText = "";
			this.txtPrice.SelectedText = "";
			this.txtPrice.Size = new System.Drawing.Size(325, 37);
			this.txtPrice.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
			this.txtPrice.TabIndex = 7;
			// 
			// txtType
			// 
			this.txtType.BackColor = System.Drawing.Color.Transparent;
			this.txtType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
			this.txtType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.txtType.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.txtType.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.txtType.Font = new System.Drawing.Font("Segoe UI", 10.8F);
			this.txtType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.txtType.ItemHeight = 30;
			this.txtType.Location = new System.Drawing.Point(825, 187);
			this.txtType.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.txtType.Name = "txtType";
			this.txtType.Size = new System.Drawing.Size(326, 36);
			this.txtType.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
			this.txtType.TabIndex = 8;
			// 
			// txtBed
			// 
			this.txtBed.BackColor = System.Drawing.Color.Transparent;
			this.txtBed.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
			this.txtBed.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.txtBed.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.txtBed.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.txtBed.Font = new System.Drawing.Font("Segoe UI", 10.8F);
			this.txtBed.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.txtBed.ItemHeight = 30;
			this.txtBed.Location = new System.Drawing.Point(825, 275);
			this.txtBed.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.txtBed.Name = "txtBed";
			this.txtBed.Size = new System.Drawing.Size(326, 36);
			this.txtBed.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
			this.txtBed.TabIndex = 9;
			// 
			// btnAddRoom
			// 
			this.btnAddRoom.BorderRadius = 18;
			this.btnAddRoom.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
			this.btnAddRoom.BorderThickness = 1;
			this.btnAddRoom.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.ToogleButton;
			this.btnAddRoom.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(221)))));
			this.btnAddRoom.CheckedState.ForeColor = System.Drawing.Color.White;
			this.btnAddRoom.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
			this.btnAddRoom.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
			this.btnAddRoom.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
			this.btnAddRoom.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
			this.btnAddRoom.FillColor = System.Drawing.Color.White;
			this.btnAddRoom.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnAddRoom.ForeColor = System.Drawing.Color.Black;
			this.btnAddRoom.Location = new System.Drawing.Point(1015, 456);
			this.btnAddRoom.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.btnAddRoom.Name = "btnAddRoom";
			this.btnAddRoom.Size = new System.Drawing.Size(135, 39);
			this.btnAddRoom.TabIndex = 10;
			this.btnAddRoom.Text = "Add Room";
			this.btnAddRoom.Click += new System.EventHandler(this.btnAddRoom_Click);
			// 
			// guna2Elipse1
			// 
			this.guna2Elipse1.BorderRadius = 30;
			this.guna2Elipse1.TargetControl = this;
			// 
			// UC_AddRoom
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.Controls.Add(this.btnAddRoom);
			this.Controls.Add(this.txtBed);
			this.Controls.Add(this.txtType);
			this.Controls.Add(this.txtPrice);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.txtRoomNo);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.DataGridView1);
			this.Controls.Add(this.label1);
			this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.Name = "UC_AddRoom";
			this.Size = new System.Drawing.Size(1214, 520);
			this.Load += new System.EventHandler(this.UC_AddRoom_Load);
			this.Enter += new System.EventHandler(this.UC_AddRoom_Enter);
			this.Leave += new System.EventHandler(this.UC_AddRoom_Leave);
			((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private Guna.UI2.WinForms.Guna2DataGridView DataGridView1;
		private System.Windows.Forms.Label label2;
		private Guna.UI2.WinForms.Guna2TextBox txtRoomNo;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private Guna.UI2.WinForms.Guna2TextBox txtPrice;
		private Guna.UI2.WinForms.Guna2ComboBox txtType;
		private Guna.UI2.WinForms.Guna2ComboBox txtBed;
		private Guna.UI2.WinForms.Guna2Button btnAddRoom;
		private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
	}
}
