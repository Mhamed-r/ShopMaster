using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dbcontext;

namespace Login
{
    public class login_serv
    {
        Db_Context Context;
        public login_serv()
        {
            Context = new Db_Context();


        }
        public bool check_user(string username, string password)
        {
            string query = $"select * from Users where Username='{username}' and Password='{password}'";
            DataTable dt = Context.Select(query);
            if (dt.Rows.Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
