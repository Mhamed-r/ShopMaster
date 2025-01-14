using Dbcontext;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BusinessLogic
{
    public class categories_services
    {
        Db_Context Context;
        public categories_services()
        {
            Context = new Db_Context();
        }
        public DataTable GetCategories()
        {

            try
            {
                string sql = "select Cat_id as CategoryID,Cat_name as CategoryName from Categories";
                DataTable dt_cat = Context.Select(sql);
                return dt_cat;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }
        public int Addcategory(string name)
        {
            try
            {
                int rowsAffected = Context.Insert($"insert into Categories values('{name}')");

                return rowsAffected;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }


        }
        public int updatecategory(int id, string name)
        {

            try
            {
                int rowsAffected = Context.Insert($"UPDATE Categories SET Cat_name = '{name}' WHERE Cat_id = {id};");
                return rowsAffected;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }





        }
        public int deletecategory(int id)
        {
            try
            {
                int rowsAffected = Context.Insert($"Delete from Categories where Cat_id={id};");
                return rowsAffected;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
