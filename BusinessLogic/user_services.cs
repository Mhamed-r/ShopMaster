using Dbcontext;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static BusinessLogic.registration_services;

namespace BusinessLogic
{
    public class user_services
    {
        Db_Context Context;
        DataTable dt;
        public user_services()
        {
            Context = new Db_Context();

        }
        public DataTable GetUsers()
        {
            try
            {
                string sql = "select * From Users";
                dt = Context.Select(sql);
                return dt;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }



        }
        public DataTable GetRoles()
        {

            try
            {
                string sql = "select Role from Users";
                DataTable dt_cat = Context.Select(sql);
                return dt_cat;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }
        public int Adduser(string name, string address, string password, string email, int age, Role role)
        {
            try
            {
                string query = $"insert into Users (Username,Address,Password,Email,Age,Role) values ('{name}','{address}','{password}','{email}',{age},'{role.ToString()}')";
                int rowsAffected = Context.Insert(query);
                return rowsAffected;
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
        }
        public int updateUser(int id, string name, string address, string password, string email, int age, Role role)
        {

            try
            {
                int rowsAffected = Context.Insert($"UPDATE Users SET Username = '{name}', Address = '{address}', Password = '{password}', Email = '{email}', Age = {age}, Role = '{role.ToString()}' WHERE UserId = {id}");
                return rowsAffected;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public int deleteUser(int id)
        {
            try
            {
                int rowsAffected = Context.Insert($"Delete from Users where UserId={id};");
                return rowsAffected;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public int updateProfile(int id,string name, string password, string email)
        {

            try
            {
                int rowsAffected = Context.Insert($"UPDATE Users SET Username = '{name}', Password = '{password}', Email = '{email}' WHERE UserId = {id}");
                return rowsAffected;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
