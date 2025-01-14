using Dbcontext;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class product_services
    {
        Db_Context Context;
        DataTable dt;

        public product_services() {
            Context=new Db_Context();


        }
        public DataTable GetData() {
            try
            {
                string sql = "SELECT ProductId,ProductName,Price,Cat_name as CategoryName FROM Products P JOIN Categories C ON C.Cat_id = P.Cat_id;";
                dt = Context.Select(sql);
                return dt;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }



        }
      
        public int AddProduct(string name,decimal price, int category)
        {
            try
            {
           int rowsAffected= Context.Insert($"insert into Products (ProductName,Price,Cat_id) Values('{name}',{price},{category})");
                
                return rowsAffected;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            

        }
        public int updateProduct(int id,string name, decimal price, int category) {

            try
            {
                int rowsAffected = Context.Insert($"UPDATE Products SET ProductName = '{name}', Price = {price}, Cat_id = {category} WHERE ProductId = {id};");
                return rowsAffected;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }





        }
        public int deleteProduct(int id)
        {
            try
            {
                int rowsAffected = Context.Insert($"Delete from Products where ProductId={id};");
                return rowsAffected;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }

   

  

}
