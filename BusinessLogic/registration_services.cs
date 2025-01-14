using Dbcontext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class registration_services
    {
        public enum Role
        {
            user,
            admin
        }
        Db_Context Context;
        public registration_services()
        {
            Context = new Db_Context();
        }
        public void add_user(string name, string address, string password, string email, int age, Role role)
        {
            string query = $"insert into Users (Username,Address,Password,Email,Age,Role) values ('{name}','{address}','{password}','{email}',{age},'{role.ToString()}')";
            Context.Insert(query);
        }
    }
}
