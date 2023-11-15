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
	public partial class ucScreen1 : UserControl
	{
		ucScreen1 ucsrennl;
		public ucScreen1()
        {
            InitializeComponent();	
        }
		public ucScreen1(object mainForm)
		{
			InitializeComponent();
			ucsrennl = ((main)mainForm).ucSc1;
		}
		private void btn_Click(object sender, EventArgs e)
		{
			Button btn = (Button)sender;
			if(btn.BackColor == Color.Green)
            {
				DialogResult result2 = MessageBox.Show("해당 공정을 중지하겠습니까?", "공정 중지", MessageBoxButtons.YesNo);
				if (result2 == DialogResult.Yes)
				{
					btn.BackColor = SystemColors.Window;
				}
			}
			else if(btn.BackColor == Color.Red)
            {
				DialogResult result = MessageBox.Show("해당 공정에 문제가 발생하였습니다. 조치 하시겠습니다?", "공정 오류", MessageBoxButtons.YesNo);
				if (result == DialogResult.Yes)
				{
					btn.BackColor = Color.Green;
				}
			}
			else
			{
				DialogResult result3 = MessageBox.Show("해당 공정을 가동하겠습니까?", "공정 시작", MessageBoxButtons.YesNo);
				if (result3 == DialogResult.Yes)
				{
					btn.BackColor = Color.Green;
				}
			}

		}
		//문제가 생긴 공정 버튼을 빨간색으로 표시하는 코드
		public void buttonColor(int _inch, int _proc, Color _clr, ucScreen1 ucScreen1)
		{
			try
			{
				var panel = ucScreen1.panel1;
				if(_inch == 24)
                {
					panel = ucScreen1.panel1;
                }
				else if(_inch == 27)
                {
					panel = ucScreen1.panel2;
				}
				else
                {
					panel = ucScreen1.panel3;
				}
				var b = panel.Controls
						.OfType<Button>()
						.Where(btn => btn.Name == "btn_" + _inch.ToString() + "_" + _proc.ToString() )
						.First();

				b.BackColor = _clr;
				Invalidate();
			}
			catch( Exception ex )
			{

			}
		}
		public void buttontest()
        {
			btn_24_1.BackColor = Color.Red;
        }
		// 모니터 이동 중 화살표 색상 변경
		public void picBoxColor(int _inch , string state, ucScreen1 ucScreen1)
		{
			try
			{
				var picBox = ucScreen1.Controls
					.OfType<PictureBox>()
					.Where(pib => pib.Name == "pib_" + _inch.ToString())
					.First();
				if(state == "OFF")
                {
					picBox.Visible = false;
				}
				else 
                {
					Image img = (Image)Properties.Resources.ResourceManager.GetObject(picBox.Name + state, Properties.Resources.Culture);
					picBox.Image = img;
					picBox.Visible = true;
				}			
			}
			catch (Exception ex)
			{
				
			}

		}

		public void picBoxColor2(string _num, string state , ucScreen1 ucScreen1)
		{
			try
			{
				var picBox1 = ucScreen1.Controls
					.OfType<PictureBox>()
					.Where(pib => pib.Name == "pib_" + _num.ToString())
					.First();
				if (state == "OFF")
				{
					picBox1.Visible = false;
				}
				else
				{
					string image = "";
					if ( _num  == "1")
                    {
						image = "pib_32" + state;

					}
					else if ( _num == "2")
                    {
						image = "pib_27" + state;
					}
					else
                    {
						image = "pib_24" + state;
					}
					Image img = (Image)Properties.Resources.ResourceManager.GetObject(image, Properties.Resources.Culture);
					picBox1.Image = img;
					picBox1.Visible = true;
				}
			}
			catch (Exception ex)
			{

			}
		}
		public void Colorred()
        {
			panel7.BackColor = Color.Red;
        }
        private void ucScreen1_Load(object sender, EventArgs e)
        {
			
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {
			
		}

        private void panel7_Paint_1(object sender, PaintEventArgs e)
        {
		
		}

        private void label7_Click_1(object sender, EventArgs e)
        {
			
		}

        private void ucScreen1_Load_1(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
