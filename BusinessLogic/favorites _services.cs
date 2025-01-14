using Dbcontext;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class favorites__services
    {
        Db_Context Context;
        DataTable dt;
        public favorites__services()
        {
            Context = new Db_Context();
            dt=new DataTable();
        }
        public DataTable GetFavData(int userid)
        {
            try
            {
                string sql = $"select P.ProductId,ProductName,Price,C.Cat_name as CategoryName From Users U,Products P ,Favorites F,Categories C where U.UserId=F.UserId and F.ProductId=P.ProductId and P.Cat_id=C.Cat_id and U.UserId={userid}";
                dt = Context.Select(sql);
                return dt;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }



        }
        public int AddFavProduct(int userid,int productid)
        {
            try
            {
                int rowsAffected = Context.Insert($"insert into Favorites (UserId,ProductId) Values({userid},{productid})");

                return rowsAffected;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }


        }
        public int deleteFavProduct(int userid, int productid)
        {
            try
            {
                int rowsAffected = Context.Insert($"delete from Favorites where  ProductId={productid} and UserId={userid}");
                return rowsAffected;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

    }
}
