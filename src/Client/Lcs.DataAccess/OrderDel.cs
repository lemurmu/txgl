using Lcs.Entity;
using Library.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lcs.DataAccess
{
    public class OrderDel
    {
        /// <summary>
        /// 查询历史订单
        /// </summary>
        /// <returns></returns>
        public List<pedidokehu> GetHistoricalOrders()
        {
            //const string sql = "select bianhao,fecha_c,beizhu,name,lianxiren,rate from pedidokehu";
           
            //using (var con = DbConfig.GetConnection())
            //{
            //    return con.Query<pedidokehu>(sql)
            //        .ToList();
            //}

            return DbConfig.DB.Queryable<pedidokehu>().ToList();
        }








    }
}
