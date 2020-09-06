using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BizUtils.Data;
using System.Data;

namespace BizUtils.Data
{
    public class VegunitTrans
    {
        DbNetDataProxy db;
        string gs_guid;
        string xs_guid;
        decimal packweight = 1;
        Dictionary<string, decimal> packDic = new Dictionary<string, decimal>();
        Dictionary<string, decimal> roughDic = new Dictionary<string, decimal>();
        Dictionary<string, decimal> packDicNeutral = new Dictionary<string, decimal>();
        Dictionary<string, decimal> roughDicNeutral = new Dictionary<string, decimal>();
        Dictionary<string, DataTable> cfgDataDic = new Dictionary<string, DataTable>();
        int vegunit = 0;

        public VegunitTrans(string gs_guid, string xs_guid, DbNetDataProxy db)
        {
            this.gs_guid = gs_guid;
            this.xs_guid = xs_guid;
            this.db = db;
        }

        public decimal CalAmount(string vegname, decimal amount)
        {
            return decimal.Round(amount * this.GetPackweight(vegname), 3);
        }


        public decimal CalUnitcost(string vegname, decimal unitcost)
        {
            return decimal.Round(unitcost / this.GetPackweight(vegname), 3);
        }

        public decimal RevertAmount(string vegname, decimal amount)
        {
            return decimal.Round(amount / this.GetPackweight(vegname), 3);
        }


        public decimal RevertUnitcost(string vegname, decimal unitcost)
        {
            return decimal.Round(unitcost * this.GetPackweight(vegname), 3);
        }

        public decimal CalWeight(string vegname, decimal amount)
        {
            return decimal.Round(amount * this.GetPackweightNeutral(vegname), 3);
        }

        public void CalDataTable(ref DataTable vegdata)
        {
            if (vegdata != null && vegdata.Rows.Count > 0)
            {
                foreach (DataRow r in vegdata.Rows)
                {
                    if (vegdata.Columns.Contains("amount") && r["amount"] != DBNull.Value)
                        r["amount"] = this.CalAmount(r.Field<string>("vegname"), Convert.ToDecimal(r["amount"]));

                    if (vegdata.Columns.Contains("jd_amount") && r["jd_amount"] != DBNull.Value)
                        r["jd_amount"] = this.CalAmount(r.Field<string>("vegname"), Convert.ToDecimal(r["jd_amount"]));

                    if (vegdata.Columns.Contains("jh_amount") && r["jh_amount"] != DBNull.Value)
                        r["jh_amount"] = this.CalAmount(r.Field<string>("vegname"), Convert.ToDecimal(r["jh_amount"]));

                    if (vegdata.Columns.Contains("sh_amount") && r["sh_amount"] != DBNull.Value)
                        r["sh_amount"] = this.CalAmount(r.Field<string>("vegname"), Convert.ToDecimal(r["sh_amount"]));

                    if (vegdata.Columns.Contains("xs_amount") && r["xs_amount"] != DBNull.Value)
                        r["xs_amount"] = this.CalAmount(r.Field<string>("vegname"), Convert.ToDecimal(r["xs_amount"]));

                    if (vegdata.Columns.Contains("unitcost") && r["unitcost"] != DBNull.Value)
                        r["unitcost"] = this.CalUnitcost(r.Field<string>("vegname"), Convert.ToDecimal(r["unitcost"]));

                    if (vegdata.Columns.Contains("unitprice") && r["unitprice"] != DBNull.Value)
                        r["unitprice"] = this.CalUnitcost(r.Field<string>("vegname"), Convert.ToDecimal(r["unitprice"]));

                    if (vegdata.Columns.Contains("lastprice") && r["lastprice"] != DBNull.Value)
                        r["lastprice"] = this.CalUnitcost(r.Field<string>("vegname"), Convert.ToDecimal(r["lastprice"]));
                }
            }
        }

        public void RevertDataTable(ref DataTable vegdata)
        {
            if (vegdata != null && vegdata.Rows.Count > 0)
            {
                foreach (DataRow r in vegdata.Rows)
                {
                    if (vegdata.Columns.Contains("amount") && r["amount"] != DBNull.Value)
                        r["amount"] = this.RevertAmount(r.Field<string>("vegname"), Convert.ToDecimal(r["amount"]));

                    if (vegdata.Columns.Contains("jd_amount") && r["jd_amount"] != DBNull.Value)
                        r["jd_amount"] = this.RevertAmount(r.Field<string>("vegname"), Convert.ToDecimal(r["jd_amount"]));

                    if (vegdata.Columns.Contains("unitcost") && r["unitcost"] != DBNull.Value)
                        r["unitcost"] = this.RevertUnitcost(r.Field<string>("vegname"), Convert.ToDecimal(r["unitcost"]));

                    if (vegdata.Columns.Contains("unitprice") && r["unitprice"] != DBNull.Value)
                        r["unitprice"] = this.RevertUnitcost(r.Field<string>("vegname"), Convert.ToDecimal(r["unitprice"]));

                    if (vegdata.Columns.Contains("lastprice") && r["lastprice"] != DBNull.Value)
                        r["lastprice"] = this.RevertUnitcost(r.Field<string>("vegname"), Convert.ToDecimal(r["lastprice"]));
                }
            }
        }

        /// <summary>
        /// 当销售点配置为公斤模式时返回packweight值
        /// </summary>
        /// <param name="vegname"></param>
        /// <returns></returns>
        public decimal GetPackweight(string vegname)
        {
            decimal packweight = 1;
            string key = string.Concat(gs_guid, xs_guid, vegname);

            try
            {
                if (!packDic.ContainsKey(key))
                {
                    if (this.getVegunit(gs_guid, xs_guid) == 2)
                    {
                        DataTable dt = this.getCfgData();
                        if (dt.Rows.Count > 0)
                        {
                            foreach (DataRow r in dt.Rows)
                            {
                                DataTable cfgDt = Rest.PackOrb.JsonToObj<DataTable>(r[0].ToString());
                                foreach (DataRow cfgR in cfgDt.Rows)
                                {
                                    if (!packDic.ContainsKey(string.Concat(gs_guid, xs_guid, cfgR.Field<string>("vegname"))))
                                    {
                                        packDic.Add(string.Concat(gs_guid, xs_guid, cfgR.Field<string>("vegname")), Convert.ToDecimal(cfgR["packweight"]));
                                        if (cfgR.Field<string>("vegname").Equals(vegname))
                                        {
                                            packweight = Convert.ToDecimal(cfgR["packweight"]);
                                        }
                                    }
                                }
                            }
                        }
                    }
                    else
                    {
                        packDic.Add(key, packweight);
                    }
                }
                else
                {
                    packweight = packDic[key];
                }
            }
            catch (Exception ex)
            {
                DC.DCLogger.LogError(ex.Message);
            }

            return packweight;
        }

        /// <summary>
        /// 无论销售点配置为何模式均返回packweight值
        /// </summary>
        /// <param name="vegname"></param>
        /// <returns></returns>
        public decimal GetPackweightNeutral(string vegname)
        {
            decimal packweight = 1;
            string key = string.Concat(gs_guid, xs_guid, vegname);

            try
            {
                if (!packDicNeutral.ContainsKey(key))
                {
                    DataTable dt = this.getCfgData();
                    if (dt.Rows.Count > 0)
                    {
                        foreach (DataRow r in dt.Rows)
                        {
                            DataTable cfgDt = Rest.PackOrb.JsonToObj<DataTable>(r[0].ToString());
                            foreach (DataRow cfgR in cfgDt.Rows)
                            {
                                if (!packDicNeutral.ContainsKey(string.Concat(gs_guid, xs_guid, cfgR.Field<string>("vegname"))))
                                {
                                    packDicNeutral.Add(string.Concat(gs_guid, xs_guid, cfgR.Field<string>("vegname")), Convert.ToDecimal(cfgR["packweight"]));
                                    if (cfgR.Field<string>("vegname").Equals(vegname))
                                    {
                                        packweight = Convert.ToDecimal(cfgR["packweight"]);
                                    }
                                }
                            }
                        }
                    }
                }
                else
                {
                    packweight = packDicNeutral[key];
                }
            }
            catch (Exception ex)
            {
                DC.DCLogger.LogError(ex.Message);
            }

            return packweight;
        }

        /// <summary>
        /// 无论销售点配置为何模式均返回roughweight值
        /// </summary>
        /// <param name="vegname"></param>
        /// <returns></returns>
        public decimal GetRoughweightNeutral(string vegname)
        {
            decimal roughweight = 1;
            string key = string.Concat(gs_guid, xs_guid, vegname);

            try
            {
                if (!roughDicNeutral.ContainsKey(key))
                {
                    DataTable dt = this.getCfgData();
                    if (dt.Rows.Count > 0)
                    {
                        foreach (DataRow r in dt.Rows)
                        {
                            DataTable cfgDt = Rest.PackOrb.JsonToObj<DataTable>(r[0].ToString());
                            foreach (DataRow cfgR in cfgDt.Rows)
                            {
                                if (!roughDicNeutral.ContainsKey(string.Concat(gs_guid, xs_guid, cfgR.Field<string>("vegname"))))
                                {
                                    roughDicNeutral.Add(string.Concat(gs_guid, xs_guid, cfgR.Field<string>("vegname")), Convert.ToDecimal(cfgR["roughweight"]));
                                    if (cfgR.Field<string>("vegname").Equals(vegname))
                                    {
                                        roughweight = Convert.ToDecimal(cfgR["roughweight"]);
                                    }
                                }
                            }
                        }
                    }
                }
                else
                {
                    roughweight = roughDicNeutral[key];
                }
            }
            catch (Exception ex)
            {
                DC.DCLogger.LogError(ex.Message);
            }

            return roughweight;
        }

        private DataTable getCfgData()
        {
            DataTable dt = null;
            string key = string.Concat(gs_guid, xs_guid);
            if (cfgDataDic.ContainsKey(key))
            {
                dt = cfgDataDic[key];
            }
            else
            {
                string addLk = "";
                QueryCommandConfig qry = new QueryCommandConfig();
                if (!string.IsNullOrWhiteSpace(gs_guid))
                {
                    addLk = "and lk_guid in (select org_guid from t_org_reginfo where super_guid = @gs_guid and org_type = 2)";
                    qry.Params["gs_guid"] = gs_guid;
                }
                qry.Sql = string.Format("select cfgdata from t_lk_chcfg where xs_guid = @xs_guid {0}", addLk);
                qry.Params["xs_guid"] = xs_guid;
                dt = db.GetDataTable(qry);
                cfgDataDic.Add(key, dt);
            }

            return dt;
        }

        private int getVegunit(string gs_guid, string xs_guid)
        {
            if (this.vegunit != 0)
                return this.vegunit;
            else
            {
                try
                {
                    QueryCommandConfig qry = new QueryCommandConfig("select vegunit from t_org_reginfo where org_guid = @xs_guid");
                    qry.Params["xs_guid"] = xs_guid;
                    object vegunitObj = db.ExecuteScalar(qry);
                    if (vegunitObj == null)
                    {
                        return 1;
                    }
                    else
                    {
                        this.vegunit = int.Parse(vegunitObj.ToString());
                        return this.vegunit;
                    }
                }
                catch (Exception ex)
                {
                    DC.DCLogger.LogError(ex.Message);
                }
            }

            return 1;
        }
    }
}
