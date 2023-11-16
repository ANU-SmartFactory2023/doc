using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp4.ucPanel;

namespace WindowsFormsApp4
{
    internal class Function
    {
        OracleConnection conn;
        OracleCommand cmd;
        OracleDataReader rdr;
        OracleDataAdapter adapt = new OracleDataAdapter();
        OracleTransaction STrans = null;
        OracleTransaction transaction;
        string strconn = "data source=(description=" +
               "(address_list=(address=(protocol=tcp)" +
               "(host=localhost)(port=1521)))" +
               "(connect_data=(server=dedicated)" +
               "(service_name=xe)));" +
               "user id=hr;password=hr;";
        public void connect()
        {
            conn = new OracleConnection(strconn);
            conn.Open();
            cmd = new OracleCommand();
            cmd.Connection = conn;

        }

        //ORD 테이블 전체 불러오기
        public DataTable select_ORD(string _ORDN = "")
        {
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("주문번호", typeof(string));
            dataTable.Columns.Add("사이즈", typeof(string));
            dataTable.Columns.Add("패널", typeof(string));
            dataTable.Columns.Add("주사율", typeof(string));
            dataTable.Columns.Add("주문수량", typeof(string));
            dataTable.Columns.Add("완료수량", typeof(string));

            cmd.CommandText = $"select * from ORD";
            if (_ORDN != "")
            {
                cmd.CommandText += $" where  = '{_ORDN}'";
            }

            rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                string ordn = rdr["ORDN"].ToString();
                string oinch = rdr["OINCH"].ToString();
                string opn = rdr["OPN"].ToString();
                string orfh = rdr["ORFH"].ToString();
                string onum = rdr["ONUM"].ToString();

                string ocom = rdr["OCOM"].ToString();

                dataTable.Rows.Add(ordn, oinch, opn, orfh, onum, ocom);



            }
            return dataTable;
        }

        //PRD 테이블 인치,주사율,패널 
        public DataTable select_PRD(string str_inch, string str_panel, string str_hz)
        {
            string query = "SELECT d.PINCH as 사이즈,d.PPN as 패널,d.PRFH as 주사율,count(*) as 출고_개수,count(CASE WHEN m.prresult='정상' THEN 1 END) as 정상_개수, count(*)-count(CASE WHEN m.prresult='정상' THEN 1 END) as 비정상_개수 FROM PRD d, PRM m";
            List<string> where_item = new List<string>();

            if (str_inch != "전체")
            {
                where_item.Add("PINCH = '" + str_inch + "'");
            }
            if (str_panel != "전체")
            {
                where_item.Add("PPN = '" + str_panel + "'");
            }
            if (str_hz != "전체")
            {
                where_item.Add("PRFH = '" + str_hz + "'");
            }
            query += " where d.ppdnumber=m.prpdnumber";
            int where_item_cnt = where_item.Count();
            if (where_item_cnt > 0)
            {
                for (int i = 0; i < where_item_cnt; i++)
                {
                    if (i < where_item_cnt)
                    {
                        query += " AND ";
                    }
                    query += where_item[i];
                }
            }
            query += " group by d.PINCH,d.PPN,d.PRFH";

            DataTable dt = new DataTable();
            dt.Columns.Add("사이즈", typeof(string));
            dt.Columns.Add("패널", typeof(string));
            dt.Columns.Add("주사율", typeof(string));
            dt.Columns.Add("출고_개수", typeof(string));
            dt.Columns.Add("정상_개수", typeof(string));
            dt.Columns.Add("비정상_개수", typeof(string));
            cmd.CommandText = query;
            rdr = cmd.ExecuteReader();

            while (rdr.Read())
            {
                string pinch = rdr["사이즈"].ToString();
                string ppn = rdr["패널"].ToString();
                string prfh = rdr["주사율"].ToString();
                string all_pd = rdr["출고_개수"].ToString();
                string good_pd = rdr["정상_개수"].ToString();
                string not_pd = rdr["비정상_개수"].ToString();
                dt.Rows.Add(pinch, ppn, prfh, all_pd, good_pd, not_pd);
            }
            return dt;
        }

        // 오라클 데이터 삽입을 위한 함수s
        public void INSERTCommand(string[] Speci, string tname)
        {
            try
            {
                string commad = $"INSERT INTO {tname} VALUES (";
                for (int i = 0; i < Speci.Length; i++)
                {
                    if (i != Speci.Length - 1 )
                    {
                        commad += $"'{Speci[i]}',";
                    }
                    else
                    {
                        commad += $"'{Speci[i]}')";
                    }
                }
                cmd.CommandText = commad;
                cmd.ExecuteNonQuery();
                transaction.Commit();
            }
            catch(Exception ex)
            {
                System.Console.WriteLine(ex.Message);
       
            }
        }
        public void GridUpdate2(string inch, string panel, string hz)
        {      
            try
            {
                string COM= $"UPDATE ORD SET Ocom = Ocom + 1 WHERE (OINCH = {inch} AND OPn = '{panel}' AND ORfh = {hz})";
                cmd.CommandText = "";
                cmd.CommandText = COM;
                cmd.ExecuteNonQuery();
                transaction.Commit();
            }
            catch (Exception ex)
            {
                System.Console.WriteLine(ex.Message);

            }
        }
        //정상제품 카운트
        public string cnt_normal()
        {
             string normal1="";

             cmd.CommandText = $"SELECT COUNT(*) FROM PRM WHERE PRResult = '정상'";
             
             rdr = cmd.ExecuteReader();
             if (rdr.Read())
             {
                 normal1 = rdr["count(*)"].ToString();
                 
                return normal1;
             }
             else
             {
                 return "없습니다";
             }           
        }

        //비정상 제품카운트
        public string cnt_abnormal()
        {
            string abnormal1 = "";

            cmd.CommandText = $"SELECT COUNT(*) FROM PRM WHERE PRResult != '정상'";

            rdr = cmd.ExecuteReader();
            if (rdr.Read())
            {
                abnormal1 = rdr["count(*)"].ToString();

                return abnormal1;
            }
            else
            {
                return "없습니다";
            }
        }

        //핫픽셀
        public string cnt_hot()
        {
            string hot = "";

            cmd.CommandText = $"SELECT COUNT(*) FROM PRM WHERE PRResult = '핫'";

            rdr = cmd.ExecuteReader();
            if (rdr.Read())
            {
                hot = rdr["count(*)"].ToString();

                return hot;
            }
            else
            {
                return "없습니다";
            }
        }

        
        //데드픽셀
        public string cnt_dead()
        {
            string dead = "";

            cmd.CommandText = $"SELECT COUNT(*) FROM PRM WHERE PRResult = '데드'";

            rdr = cmd.ExecuteReader();
            if (rdr.Read())
            {
                dead = rdr["count(*)"].ToString();

                return dead;
            }
            else
            {
                return "없습니다";
            }

        }

        //스턱픽셀
        public string cnt_stuck()
        {
            string stuck = "";

            cmd.CommandText = $"SELECT COUNT(*) FROM PRM WHERE PRResult = '스턱'";

            rdr = cmd.ExecuteReader();
            if (rdr.Read())
            {
                stuck = rdr["count(*)"].ToString();

                return stuck;
            }
            else
            {
                return "없습니다";
            }
        }
        public DataSet dataColumn(string[] date, string name, string[] result)
        {
            string command = "select CONCAT(G.MName, CONCAT(CONCAT('(', G.MNUMBER), ')')) as 담당_사원, D.PPDNUMBER as 제품_번호,D.PINCH as 사이즈,D.PPN as 패널,D.PRFH as 주사율, D.PDATE as 제작_날짜, M.PRTIME as 분류_날짜, M.PRRESULT as 분류_결과 " +
                            "from MANAGER G, PRD D, PRM M " +
                            "where G.MNUMBER = M.PRNUMBER and D.PPDNUMBER = M.PRPDNUMBER";
            if (name != "") command += $"and G.MName = '{name}' ";
            for(int i=0; i<date.Length; i++)
            {
                if(date[i] != null)
                {
                    command += $" and M.PRRESULT = '{date[i]}' ";
                }
            }
            command += $" and TO_NUMBER(replace(substr(PDATE, 0, 10), '-', '')) between {result[0]} and {result[1]}";
            adapt.SelectCommand = new OracleCommand(command, conn);
            DataSet ds = new DataSet();
            adapt.Fill(ds);
            return ds;
        }
    }
}
