using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace ClinicalManagement.Models
{
    public class login
    {
        private SqlConnection con;
        private SqlCommand cmd;
        private DataTable dt;
        private string constr;
        private SqlDataAdapter sda;
        public login()
        {
            constr = @"Data Source=IND-CHN-LT10364\SQLEXPRESS;Initial Catalog=clinic;Integrated Security=True;MultipleActiveResultSets=True;Application Name=EntityFramework";
            con = new SqlConnection(constr);
            cmd = new SqlCommand();
            cmd.Connection = con;
        }
        public int SetDatas(string sql)
        {
            int cnt = 0;
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            cmd.CommandText = sql;
            cnt = cmd.ExecuteNonQuery();
            con.Close();
            return cnt;
        }
        public DataTable GetDatas(string Query)
        {
            dt = new DataTable();
            sda = new SqlDataAdapter(Query, constr);
            sda.Fill(dt);
            return dt;
        }
    }
}
