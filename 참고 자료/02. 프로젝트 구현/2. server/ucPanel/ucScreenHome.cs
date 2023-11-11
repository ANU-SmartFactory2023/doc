using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4.ucPanel
{
	public partial class ucScreenHome : UserControl
	{
		public ucScreenHome()
		{
			InitializeComponent();
		}

		private void ucScreenHome_Load(object sender, EventArgs e)
		{
			timer1.Interval = 100;
			timer1.Start();
			timer2.Start();
		}

		private void timer1_Tick(object sender, EventArgs e)
		{
			label1.Text = DateTime.Now.ToString("hh:mm:ss");
		}

		private void timer2_Tick(object sender, EventArgs e)
		{
			label3.Text = DateTime.Now.ToString("yyyy-MM-dd");
		}

	}
}
