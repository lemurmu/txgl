using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BizUtils.Data;
using System.Data;
using System.Text.RegularExpressions;

namespace BizUtils.Sec
{
    public class UsrAuthor
    {
        public static string AllowAccess(string token, string api, DbNetData db)
        {
            string result = "无访问权限";
            List<string> regLst = GetRegSet(token, db);
            if (regLst != null && regLst.Count > 0)
            {
                foreach (string reg in regLst)
                {
                    if (Regex.IsMatch(api, reg))
                    {
                        result = null;
                        break;
                    }
                }
            }
            else
            {
                result = "用户令牌无效";
            }
            return result;
        }

        public static string AllowAccess(string token, string api, DbNetDataProxy db)
        {
            DbNetData dbtmp = db.GetDb();
            string result = AllowAccess(token, api, dbtmp);
            db.PutDb(dbtmp);
            return result;
        }

        private static Dictionary<string, List<string>> regSetDic = new Dictionary<string, List<string>>();
        private static Dictionary<string, DateTime> regSetTouch = new Dictionary<string, DateTime>();
        public static List<string> GetRegSet(string token, DbNetData db)
        {
            if (!regSetDic.ContainsKey(token))
            {
                List<string> regset = new List<string>();

                QueryCommandConfig qry = new QueryCommandConfig("select funcset,roleset from t_usr where login_token = @token");
                qry.Params["token"] = token;
                DataTable dt = db.GetDataTable(qry);
                if (dt.Rows.Count > 0)
                {
                    List<string> roleset = new List<string>();
                    if (dt.Rows[0].Field<string>("roleset") != null)
                        roleset = dt.Rows[0].Field<string>("roleset").Split('|').ToList();
                    List<string> funcset = new List<string>();
                    if (dt.Rows[0].Field<string>("funcset") != null)
                        funcset = dt.Rows[0].Field<string>("funcset").Split('|').ToList();
                    List<string> apiset = new List<string>();
                    if (roleset.Count > 0)
                    {
                        QueryCommandConfig qry2 = new QueryCommandConfig(string.Format("select funcset from t_dic_role where role_name in ({0})", "'" + string.Join("','", roleset) + "'"));
                        DataTable fsdt = db.GetDataTable(qry2);
                        foreach (DataRow r in fsdt.Rows)
                        {
                            List<string> temp_funcset = r.Field<string>("funcset").Split('|').ToList();
                            funcset = funcset.Union(temp_funcset).ToList();
                        }
                    }
                    QueryCommandConfig qry3 = new QueryCommandConfig(string.Format("select apiset from t_dic_func where func_name in ({0})", "'" + string.Join("','", funcset) + "'"));
                    DataTable asdt = db.GetDataTable(qry3);
                    foreach (DataRow r in asdt.Rows)
                    {
                        List<string> temp_apiset = r.Field<string>("apiset").Split('|').ToList();
                        apiset = apiset.Union(temp_apiset).ToList();
                    }
                    foreach (string apiurl in apiset)
                    {
                        regset.Add("^" + apiurl.Replace("*", "\\S+") + "$");
                    }
                }

                regSetDic.Add(token, regset);
                regSetTouch.Add(token, DateTime.Now);
            }
            else
            {
                regSetTouch[token] = DateTime.Now;
            }

            List<string> outTimeTokens = new List<string>();
            foreach (string key in regSetTouch.Keys)
            {
                if (DateTime.Now.Subtract(regSetTouch[token]).TotalMinutes > 60)
                {
                    outTimeTokens.Add(key);
                }
            }
            foreach (string key in outTimeTokens)
            {
                regSetDic.Remove(key);
                regSetTouch.Remove(key);
            }

            return regSetDic[token];
        }

        public static bool DeleteToken(string token)
        {
            bool result = false;
            try
            {
                if (regSetDic.ContainsKey(token))
                {
                    regSetDic.Remove(token);
                }
                if (regSetTouch.ContainsKey(token))
                {
                    regSetTouch.Remove(token);
                }
            }
            catch (Exception)
            {
                result = false;
                //throw;
            }
            return result;
        }
    }
}
