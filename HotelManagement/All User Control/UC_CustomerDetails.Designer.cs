namespace HotelManagement.All_User_Control
{
	partial class UC_CustomerDetails
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
			this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
			this.label1 = new System.Windows.Forms.Label();
			this.cmbSearchType = new Guna.UI2.WinForms.Guna2ComboBox();
			this.label3 = new System.Windows.Forms.Label();
			this.txtCustomerName = new Guna.UI2.WinForms.Guna2TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.DataGridView1 = new Guna.UI2.WinForms.Guna2DataGridView();
			((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).BeginInit();
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
			this.label1.Location = new System.Drawing.Point(40, 22);
			this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(329, 33);
			this.label1.TabIndex = 1;
			this.label1.Text = "Customer Details  - Visits";
			// 
			// cmbSearchType
			// 
			this.cmbSearchType.BackColor = System.Drawing.Color.Transparent;
			this.cmbSearchType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
			this.cmbSearchType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbSearchType.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.cmbSearchType.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.cmbSearchType.Font = new System.Drawing.Font("Segoe UI", 10.8F);
			this.cmbSearchType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.cmbSearchType.ItemHeight = 30;
			this.cmbSearchType.Location = new System.Drawing.Point(46, 96);
			this.cmbSearchType.Margin = new System.Windows.Forms.Padding(2);
			this.cmbSearchType.Name = "cmbSearchType";
			this.cmbSearchType.Size = new System.Drawing.Size(326, 36);
			this.cmbSearchType.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
			this.cmbSearchType.TabIndex = 10;
			this.cmbSearchType.SelectedIndexChanged += new System.EventHandler(this.cmbSearchType_SelectedIndexChanged);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(42, 76);
			this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(81, 20);
			this.label3.TabIndex = 9;
			this.label3.Text = "Search By";
			// 
			// txtCustomerName
			// 
			this.txtCustomerName.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txtCustomerName.DefaultText = "";
			this.txtCustomerName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.txtCustomerName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
			this.txtCustomerName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.txtCustomerName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.txtCustomerName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.txtCustomerName.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtCustomerName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.txtCustomerName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.txtCustomerName.Location = new System.Drawing.Point(393, 95);
			this.txtCustomerName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.txtCustomerName.Name = "txtCustomerName";
			this.txtCustomerName.PlaceholderText = "";
			this.txtCustomerName.SelectedText = "";
			this.txtCustomerName.Size = new System.Drawing.Size(325, 37);
			this.txtCustomerName.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
			this.txtCustomerName.TabIndex = 12;
			this.txtCustomerName.TextChanged += new System.EventHandler(this.txtCustomerName_TextChanged);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(389, 76);
			this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(53, 20);
			this.label2.TabIndex = 11;
			this.label2.Text = "Name";
			// 
			// DataGridView1
			// 
			dataGridViewCellStyle16.BackColor = System.Drawing.Color.White;
			this.DataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle16;
			this.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle17.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle17.ForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle17.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle17.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.DataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle17;
			this.DataGridView1.ColumnHeadersHeight = 4;
			this.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
			dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle18.BackColor = System.Drawing.Color.White;
			dataGridViewCellStyle18.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle18.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
			dataGridViewCellStyle18.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle18.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
			dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.DataGridView1.DefaultCellStyle = dataGridViewCellStyle18;
			this.DataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
			this.DataGridView1.Location = new System.Drawing.Point(46, 159);
			this.DataGridView1.Margin = new System.Windows.Forms.Padding(2);
			this.DataGridView1.Name = "DataGridView1";
			this.DataGridView1.RowHeadersVisible = false;
			this.DataGridView1.RowHeadersWidth = 51;
			this.DataGridView1.RowTemplate.Height = 24;
			this.DataGridView1.Size = new System.Drawing.Size(1110, 308);
			this.DataGridView1.TabIndex = 13;
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
			// UC_CustomerDetails
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.Controls.Add(this.DataGridView1);
			this.Controls.Add(this.txtCustomerName);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.cmbSearchType);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label1);
			this.Name = "UC_CustomerDetails";
			this.Size = new System.Drawing.Size(1214, 520);
			this.Load += new System.EventHandler(this.UC_CustomerDetails_Load);
			this.Enter += new System.EventHandler(this.UC_CustomerDetails_Enter);
			((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
		private System.Windows.Forms.Label label1;
		private Guna.UI2.WinForms.Guna2ComboBox cmbSearchType;
		private System.Windows.Forms.Label label3;
		private Guna.UI2.WinForms.Guna2TextBox txtCustomerName;
		private System.Windows.Forms.Label label2;
		private Guna.UI2.WinForms.Guna2DataGridView DataGridView1;
	}
}
