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
        public List<lcs_goods> GetGoodsList()
        {
            const string sql = "select is_check,goods_id,goods_img,goods_sn,goods_thumb,goods_name,click_count,shop_price,warn_number,seller_note from lcs_goods";
            using (var con = DbConfig.GetConnection())
            {
                return con.Query<lcs_goods>(sql)
                    .ToList();
            }
        }

        public void Insert(lcs_goods lcs_Goods)
        {
            const string sql = "INSERT INTO lcs_goods (cat_id, goods_name) VALUES (@cat_id,@goods_name)";

            using (var con = DbConfig.GetConnection())
            {
                con.Execute(sql, lcs_Goods);
            }

            //using (var con = DbConfig.GetConnection())
            //{

            //    return con.Insert<lcs_goods>(lcs_Goods);
            //}
        }

        public bool UpDate(lcs_goods lcs_Goods)
        {
            using (var con = DbConfig.GetConnection())
            {
                return con.Update<lcs_goods>(lcs_Goods);
            }
        }

        public bool Delete(lcs_goods lcs_Goods)
        {
            using (var con = DbConfig.GetConnection())
            {
                return con.Delete<lcs_goods>(lcs_Goods);
            }
        }

    }
}
