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
      
    public partial class ucScreen2 : UserControl
    {
        ucScreen1 ucsrennl;
        public ucScreen2()
        {
            InitializeComponent();
        }
        public ucScreen2(object mainForm)
        {
            InitializeComponent();
            ucsrennl = ((main)mainForm).ucSc1;
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void Lookup_Btn_Click(object sender, EventArgs e)
        {
            GridSelect();
            factoryoperation(ucsrennl);
        }
        public string CreateName(string inch ,string panel, string hz, string num)
        {
            string code = inch[1] + "I" + panel[0] + "P" + hz[0] + "H" + DateTime.Now.ToString("ddMMyy") + num + "new";
            return code;
        }
        private void ucScreen2_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = Program.f_function.select_ORD("");
        }
        public void Update(ucScreen2 ucsrennl)
        {
            ucsrennl.dataGridView1.DataSource = Program.f_function.select_ORD("");
        }
        public void GridAdd(string inch, string panel ,string hz)
        {
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                try
                {
                    if (row.Cells[1].Value.ToString() == inch && row.Cells[2].Value.ToString() == panel && row.Cells[3].Value.ToString() == hz)
                    {
                        row.Cells[5].Value = Int32.Parse(row.Cells[5].Value.ToString()) + 1;
                    }
                }
                catch (Exception ex)
                {
                }

            }
        }
        public void factoryoperation(ucScreen1 ucsrennl)
        {
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                try
                {
                    int neednum = Int32.Parse(row.Cells[4].Value.ToString());
                    int clearnum = Int32.Parse(row.Cells[5].Value.ToString());
                    if (neednum > clearnum)
                    {
                        int inch = Int32.Parse(row.Cells[1].Value.ToString());
                        ucsrennl.buttonColor(inch, 1, Color.Green, ucsrennl);
                        ucsrennl.buttonColor(inch, 2, Color.Green, ucsrennl);
                        ucsrennl.buttonColor(inch, 3, Color.Green, ucsrennl);
                        ucsrennl.buttonColor(inch, 4, Color.Green, ucsrennl);
                        ucsrennl.picBoxColor(inch, "ON", ucsrennl);
                        ucsrennl.Update();
                        break;
                    }
                }
                catch (Exception ex)
                {


                }

            }
        }
        public void GridSelect( )
        {
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                try
                {
                    int pack = Int32.Parse(row.Cells[4].Value.ToString());
                    for(int i = 0; i < pack; i++)
                    {
                        string[] result = new string[5];
                        result[0] = CreateName(row.Cells[1].Value.ToString(), row.Cells[2].Value.ToString(), row.Cells[3].Value.ToString(), i.ToString());
                        result[1] = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                        result[2] = row.Cells[1].Value.ToString();
                        result[3] = row.Cells[2].Value.ToString();
                        result[4] = row.Cells[3].Value.ToString();
                        Program.f_function.INSERTCommand(result, "PRD");
                    }
                }
                catch (Exception ex)
                {

                    
                }

            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
