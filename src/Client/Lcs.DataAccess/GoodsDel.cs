using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lcs.Entity;
using Library.DataAccess;

namespace Lcs.DataAccess
{
    public class GoodsDel
    {
        public List<articulo> GetGoodsList()
        {
            const string sql = "select status,bianhao,codigo,baozhuangshu,zhuangxiangshu,kucun,namecn,Weizhi,beizhu,maijia from articulo";
            using (var con = DbConfig.GetConnection())
            {
                return con.Query<articulo>(sql)
                    .ToList();
            }
        }

        public void Insert(articulo lcs_Goods)
        {
            //const string sql = "INSERT INTO lcs_goods (cat_id, goods_name) VALUES (@cat_id,@goods_name)";

            //using (var con = DbConfig.GetConnection())
            //{
            //    con.Execute(sql, lcs_Goods);
            //}

            using (var con = DbConfig.GetConnection())
            {

                con.Insert<articulo>(lcs_Goods);
            }
        }

        public bool UpDate(articulo lcs_Goods)
        {
            using (var con = DbConfig.GetConnection())
            {
                return con.Update<articulo>(lcs_Goods);
            }
        }

        public bool Delete(articulo lcs_Goods)
        {
            using (var con = DbConfig.GetConnection())
            {
                return con.Delete<articulo>(lcs_Goods);
            }
        }

    }
}
