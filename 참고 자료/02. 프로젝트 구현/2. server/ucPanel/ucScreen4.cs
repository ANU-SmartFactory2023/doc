using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace WindowsFormsApp4.ucPanel
{
    public partial class ucScreen4 : UserControl
    {
        ucScreen4 ucScreenl;
        public ucScreen4()
        {
            InitializeComponent();
        }
        public ucScreen4(object mainForm)
        {
            InitializeComponent();
            ucScreenl = ((main)mainForm).ucSc4;
        }
        private void ucScreen4_Load(object sender, EventArgs e)
		{
           
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] datetime = new string[2];
            datetime[0] = Regex.Replace(dateTimePicker1.Text, @"[^0-9]", "");
            datetime[1] = Regex.Replace(dateTimePicker2.Text, @"[^0-9]", "");
            string[] result = new string[4];
            if (checkBox1.Checked) result[0] = checkBox1.Text;
            if (checkBox2.Checked) result[1] = checkBox2.Text;
            if (checkBox3.Checked) result[2] = checkBox3.Text;
            if (checkBox4.Checked) result[3] = checkBox4.Text;
            DataSet ds = Program.f_function.dataColumn(result, textBox1.Text, datetime);
            dataGridView2.DataSource = ds.Tables[0].DefaultView;
            dataGridView2.Update();
        }
    }
}
