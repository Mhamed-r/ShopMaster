using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dbcontext
{
    public class Db_Context
    {
        SqlConnection con;
        DataTable dt;
        SqlDataAdapter adapter;
        public Db_Context()
        {
            con = new SqlConnection();
            con.ConnectionString = "Server=desktop-gtd3iip\\sqlexpress;Database=FavShop;Trusted_Connection=True;TrustServerCertificate=True";
            dt = new DataTable();
            adapter = new SqlDataAdapter();
        }
        public DataTable Select(String CommandTxt)
        {
            try
            {
                SqlCommand Command = new SqlCommand(CommandTxt, con);
                adapter.SelectCommand = Command;
                dt.Clear();
                adapter.Fill(dt);
                return dt;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }


        }
        //public DataTable Select(String CommandTxt)
        //{
        //    try
        //    {
        //        SqlCommand Command = new SqlCommand(CommandTxt, con);
        //        con.Open();
        //        SqlDataReader rdr = Command.ExecuteReader();
        //        DataTable dt = new DataTable();
        //        dt.Load(rdr);
        //        con.Close();
        //        return dt;

        //    }
        //    catch (Exception ex)
        //    {
        //        throw new Exception(ex.Message);
        //    }
        //}

        public int Insert(String CommandTxt)
        {
            int rowsAffected = 0;
            try
            {
                SqlCommand Command = new SqlCommand(CommandTxt, con);
                con.Open();
                rowsAffected=Command.ExecuteNonQuery();
                con.Close();
                return rowsAffected;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public int Update(String CommandTxt)
        {
            int rowsAffected = 0;

            try
            {
                SqlCommand Command = new SqlCommand(CommandTxt, con);
                con.Open();
                rowsAffected=Command.ExecuteNonQuery();
                con.Close();
                return rowsAffected;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }


        }
        public int Delete(String CommandTxt)
        {
            int rowsAffected = 0;

            try
            {
                SqlCommand Command = new SqlCommand(CommandTxt, con);
                con.Open();
                rowsAffected=Command.ExecuteNonQuery();
                con.Close();
                return rowsAffected;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }


    }
}
