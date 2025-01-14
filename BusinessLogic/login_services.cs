using Azure.Identity;
using Dbcontext;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class login_services
    {
        Db_Context Context;
        public login_services()
        {
            Context = new Db_Context();


        }
        public DataTable check_user(string username, string password)
        {
            string query = $"select * from Users where Username='{username}' and Password='{password}'";
            DataTable dt = Context.Select(query);
            return dt;
         
        }
       

    }
}
