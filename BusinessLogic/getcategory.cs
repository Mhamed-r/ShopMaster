using Dbcontext;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class getcategory
    {
        Db_Context Context;

        public getcategory()
        {
            Context=new Db_Context();
        }
        public DataTable GetCategories()
        {

            try
            {
                string sql = "select Cat_id,Cat_name from Categories";
                DataTable dt_cat = Context.Select(sql);
                return dt_cat;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }
    }
}
