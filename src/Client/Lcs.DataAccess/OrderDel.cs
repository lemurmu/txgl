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
        public List<lcs_order_info> GetHistoricalOrders()
        {
            const string sql = "select order_id,order_sn,how_oos,consignee,mobile,agency_id,money_paid from lcs_order_info";
            using (var con = DbConfig.GetConnection())
            {
                return con.Query<lcs_order_info>(sql)
                    .ToList();
            }
        }








    }
}
