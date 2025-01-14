using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dbcontext;

namespace Registration
{
    public enum Role
    {
        user,
        admin
    }
    public class registration_serv
    {
        Db_Context Context;
        public registration_serv()
        {
            Context = new Db_Context();
        }
        public void add_user(string name, string address, string password, string email,int age,Role role )
        {
            string query = $"insert into Users (Username,Address,Password,Email,Age,Role) values ('{name}','{address}','{password}','{email}',{age},'{role.ToString()}')";
            Context.Insert(query);
        }

    }
}
