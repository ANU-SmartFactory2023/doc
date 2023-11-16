using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class Login_Form : Form
    {
        OracleConnection conn;
        OracleCommand cmd;
        OracleDataReader rdr;
        string strConn = "Data Source=(DESCRIPTION=" +
               "(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)" +
               "(HOST=localhost)(PORT=1521)))" +
               "(CONNECT_DATA=(SERVER=DEDICATED)" +
               "(SERVICE_NAME=xe)));" +
               "User Id=hr;Password=hr;";


        string login_Name;
        string login_Number;
        public Login_Form()
        {
            InitializeComponent();
            conn = new OracleConnection(strConn);
            conn.Open();
            cmd = new OracleCommand();
            cmd.Connection = conn;

        }
        
        bool TagMove;
        int MValX, MValY;
        main main1;

        private void button1_Click(object sender, EventArgs e)
        {
            //  cmd.CommandText = $"select Mpw from Manager WHERE MId = '{textBox1.Text}'";
            //  rdr = cmd.ExecuteReader();
            //  string pw = "";
            //  while (rdr.Read())
            //
            //{
            //    pw = rdr["Mpw"].ToString();
            //}
            //if (textBox2.Text == pw)
            //
            //{
            //    cmd.CommandText = $"select * from Manager WHERE MId = '{textBox1.Text}'";
            //    rdr = cmd.ExecuteReader();
            //
            //    while (rdr.Read())
            //    {
            //        login_Number = rdr["MNumber"].ToString();
            //        login_Name = rdr["MName"].ToString();
            //    }

            this.Hide();


                //cmd.CommandText = $"INSERT INTO CON VALUES (TO_CHAR(sysdate,'YYYY-MM-DD HH24:mi:SS'), {login_Number} ,'0')";
                //cmd.ExecuteNonQuery();

           //     cmd.CommandText = $"INSERT INTO CON VALUES (TO_CHAR(sysdate,'YYYY-MM-DD HH24:mi:SS'), {login_Number} ,'0')";
             //   cmd.ExecuteNonQuery();


                main1 = new main();
                main1.login_Name = login_Name;
                main1.login_Number = login_Number;
                main1.Show();

           // }
        }



        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if(TagMove == true)
            {
                this.SetDesktopLocation(MousePosition.X - MValX, MousePosition.Y - MValY);
            }
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            TagMove = false;
        }

        private void Login_Form_Load(object sender, EventArgs e)
        {

        }

        private void Exit_panel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            TagMove = true;
            MValX = e.X;
            MValY = e.Y;
        }
    }
}
