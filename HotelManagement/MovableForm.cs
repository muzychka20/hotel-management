using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;


namespace HotelManagement
{
	public class MovableForm : Form
	{
		[DllImport("user32.dll")]
		private static extern bool ReleaseCapture();

		[DllImport("user32.dll")]
		private static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

		private const int WM_NCLBUTTONDOWN = 0xA1;
		private const int HTCAPTION = 0x2;

		protected void EnableWindowDrag(Control targetControl)
		{
			targetControl.MouseDown += (sender, e) =>
			{
				if (e.Button == MouseButtons.Left)
				{
					ReleaseCapture();
					SendMessage(this.Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0);
				}
			};
		}

		private void InitializeComponent()
		{
			this.SuspendLayout();
			// 
			// MovableForm
			// 
			this.ClientSize = new System.Drawing.Size(284, 261);
			this.Name = "MovableForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.ResumeLayout(false);

		}
	}
}
