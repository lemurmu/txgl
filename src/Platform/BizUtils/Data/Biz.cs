using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BizUtils.Data;
using System.Data;

namespace BizUtils.Data
{
    public class Biz
    {
        private static Dictionary<int, string> zoneStrDic = new Dictionary<int, string>();
        public static string CalZonestr(int zoneid, DbNetDataProxy db)
        {
            if (!zoneStrDic.ContainsKey(zoneid))
            {
                string sql = null;
                int[] matchs = null;
                List<string> zoneList = new List<string>();

                matchs = new int[] { zoneid, 1000 * (int)Math.Floor(zoneid / 1000d), 100000 * (int)Math.Floor(zoneid / 100000d), 10000000 * (int)Math.Floor(zoneid / 10000000d) };

                sql = string.Format("select * from t_dic_zone where zoneid in ({0}) order by zoneid", string.Join(",", matchs));
                QueryCommandConfig CmdConfig = new QueryCommandConfig(sql);
                DataTable dt = db.GetDataTable(CmdConfig);

                if (dt != null && dt.Rows.Count > 0)
                {
                    foreach (DataRow r in dt.Rows)
                    {
                        zoneList.Add(r.Field<string>("zonename"));
                    }
                }

                zoneStrDic.Add(zoneid, string.Join("-", zoneList));
            }

            return zoneStrDic[zoneid];
        }

        public static List<string> CalFuncset(string res_type, List<string> rolesetList, DbNetDataProxy db)
        {
            List<string> funcset_List = new List<string>();
            QueryCommandConfig funcQryCmd = new QueryCommandConfig(
                        string.Format("select funcset from t_dic_resrole where res_type = @res_type and role_name in ('{0}')", string.Join("','", rolesetList)));
            funcQryCmd.Params["res_type"] = res_type;
            DataTable funcDt = db.GetDataTable(funcQryCmd);
            if (funcDt != null && funcDt.Rows.Count > 0)
            {
                foreach (DataRow r in funcDt.Rows)
                {
                    funcset_List = new List<string>(funcset_List.Union(r.Field<string>(0).Split('|')));
                }
                funcset_List.Sort();
            }

            return funcset_List;
        }

        static Dictionary<string, decimal> packDic = new Dictionary<string, decimal>();
        public static void CalXsVegdata(string gs_guid, string xs_guid, ref VegData vegdata, DbNetDataProxy db)
        {
            decimal packweight = 1;

            string key = string.Concat(gs_guid, xs_guid, vegdata.Vegname);
            if (!packDic.ContainsKey(key))
            {
                QueryCommandConfig qry = new QueryCommandConfig("select cfgdata from t_lk_chcfg where xs_guid = @xs_guid limit 1");
                qry.Params["xs_guid"] = xs_guid;
                object cfg = db.ExecuteScalar(qry);
                if (cfg != null)
                {
                    DataTable cfgDt = Rest.PackOrb.JsonToObj<DataTable>(cfg.ToString());
                    foreach (DataRow cfgR in cfgDt.Rows)
                    {
                        packDic.Add(string.Concat(gs_guid, xs_guid, cfgR.Field<string>("vegname")), Convert.ToDecimal(cfgR["packweight"]));
                        if (cfgR.Field<string>("vegname").Equals(vegdata.Vegname))
                        {
                            packweight = Convert.ToDecimal(cfgR["packweight"]);
                        }
                    }
                }
            }
            else
            {
                packweight = packDic[key];
            }

            vegdata.Amount = decimal.Round(vegdata.Amount * packweight, 3);
            vegdata.Totalcost = vegdata.Totalcost;
            vegdata.Unitcost = decimal.Round(vegdata.Unitcost / packweight, 3);
        }

        public static void CalXsVegdata(string gs_guid, string xs_guid, ref DataTable vegdata, DbNetDataProxy db)
        {
            QueryCommandConfig qry = new QueryCommandConfig("select vegunit from t_org_reginfo where org_guid = @xs_guid");
            qry.Params["xs_guid"] = xs_guid;
            object vegunitObj = db.ExecuteScalar(qry);
            if (vegunitObj == null)
                return;

            int vegunit = int.Parse(vegunitObj.ToString());
            if (vegunit != 2)
                return;

            string vegname = "vegname";
            string amount = "amount";
            string unitcost = "unitcost";
            if (vegdata.Columns.Contains("unitprice"))
            {
                unitcost = "unitprice";
            }
            string totalcost = "totalcost";
            if (vegdata.Columns.Contains("totalprice"))
            {
                totalcost = "totalprice";
            }

            if (vegdata != null && vegdata.Rows.Count > 0)
            {
                foreach (DataRow r in vegdata.Rows)
                {
                    VegData vd = new VegData { Vegname = r.Field<string>(vegname), Amount = r.Field<decimal>(amount), Unitcost = r.Field<decimal>(unitcost), Totalcost = r.Field<decimal>(totalcost) };
                    CalXsVegdata(gs_guid, xs_guid, ref vd, db);
                    r[amount] = vd.Amount;
                    r[unitcost] = vd.Unitcost;
                    r[totalcost] = vd.Totalcost;
                }
            }
        }
    }
}
