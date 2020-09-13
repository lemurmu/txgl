using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lcs.Entity;
using Library.DataAccess;
using SqlSugar;

namespace Lcs.DataAccess
{
    public class GoodsDel
    {
        public List<articulo> GetGoodsList()
        {
            //const string sql = "select status,bianhao,codigo,baozhuangshu,zhuangxiangshu,kucun,namecn,Weizhi,beizhu,maijia from articulo";
            //using (var con = DbConfig.GetConnection())
            //{
            //    return con.Query<articulo>(sql)
            //        .ToList();
            //}
            var list = DbConfig.DB.Queryable<articulo>().Select(f => new
            {
                f.id,
                f.status,
                f.bianhao,
                f.codigo,
                f.baozhuangshu,
                f.zhuangxiangshu,
                f.kucun,
                f.namecn,
                f.weizhi,
                f.beizhu,
                f.maijia
            }).ToList();
            List<articulo> articulos = new List<articulo>();
            foreach (var item in list)
            {
                articulos.Add(new articulo
                {
                    id = item.id,
                    status = item.status,
                    bianhao = item.bianhao,
                    codigo = item.codigo,
                    baozhuangshu = item.baozhuangshu,
                    zhuangxiangshu = item.zhuangxiangshu,
                    kucun = item.kucun,
                    namecn = item.namecn,
                    weizhi = item.weizhi,
                    beizhu = item.beizhu,
                    maijia = item.maijia
                });
            }
            return articulos;
        }

        public articulo GetGoodsByKey(int id)
        {
            return DbConfig.DB.Queryable<articulo>().Where(T => T.id == id).ToList()[0];
        }

        public int Insert(articulo lcs_Goods)
        {
            //            const string sql = "INSERT INTO lcs_goods (codigo,bianhao,codigoAnte,multi,namecn,namees,py,muluID,subMuluID,jinjia,maijia,maijia2,maijia3,des,des2,des3,changjia," +
            //"baozhuangshu,zhuangxiangshu,kucun,kucun2,kucunWeizhi,min,max,weizhi,jinyong,tuijian,cuxiao,attributes,beizhu,,beizhu2,riqi,fecha_cfecha,,px,px2,status)" +
            //"VALUES (@cat_id,@goods_name)";

            //            using (var con = DbConfig.GetConnection())
            //            {
            //                con.Execute(sql, lcs_Goods);
            //            }

            //using (var con = DbConfig.GetConnection())
            //{
            //    con.Insert<articulo>(lcs_Goods);
            //}
            return DbConfig.DB.Insertable(lcs_Goods).ExecuteCommand();
        }

        public int UpDate(articulo lcs_Goods)
        {
            //using (var con = DbConfig.GetConnection())
            //{
            //    return con.Update<articulo>(lcs_Goods);
            //}
            IUpdateable<articulo> updateable = DbConfig.DB.Updateable<articulo>();
            return updateable.ExecuteCommand();
        }

        public int Delete(int primaryKey)
        {
            //using (var con = DbConfig.GetConnection())
            //{
            //    return con.Delete<articulo>(lcs_Goods);
            //}
            return DbConfig.DB.Deleteable<articulo>().Where(new articulo() { id = primaryKey }).ExecuteCommand();
        }

    }
}
