using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CCWin;
using RestSharp;
using Newtonsoft.Json;
using Lcs.Entity;
using System.Windows.Forms.VisualStyles;
using LcsClient;
using Newtonsoft.Json.Linq;
using Lcs.DataAccess;

namespace LCSClientApplication.Controls
{
    public partial class ActionProductCtr : CCSkinMain
    {
        public ActionProductCtr(ActoinType actoinType)
        {
            InitializeComponent();
            this.actoinType = actoinType;
            this.jinyong_cmb.SelectedIndex = 0;
            this.goods_type_txt.SelectedIndex = 0;
        }

        ActoinType actoinType;
        GoodsDel goodsDel = new GoodsDel();
        private void skinButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void skinButton1_Click(object sender, EventArgs e)
        {
            JObject goods = new JObject();
            articulo articulo = new articulo();
            try
            {
                string goodNum = goods_id_txt.Text;
                string tiaoxing = goods_thumb_txt.Text;
                string zhcName = zh_name_txt.Text;
                string enName = en_name_txt.Text;
                string baozhuangshu = baozhuang_num_txt.Text;
                string zhaungxiangshu = zhaungxiang_num_txt.Text;
                string gonghuo = gonghuo_txt.Text;
                string rank = rank_txt.Text;
                int goodType = goods_type_txt.SelectedIndex;
                string beizhu = beizhu_txt.Text;
                string jinjie = jinjie_txt.Text;
                string shijai1 = shaijia1_txt.Text;
                string shijai_tt = shiajia_tt.Text;
                string shijai2 = shiaji2_txt.Text;
                string shijia_tt = shiajia_tt1.Text;
                string shijia3 = shijia3_txt.Text;
                string shijia_ttt = shijia_tt3.Text;
                string mubiaokucun = mubiaokucun_txt.Text;
                string zuidikucun = zuidikuucn_txt.Text;
                string goodposition = goods_position_txt.Text;
                string modifyDate = modify_date_dt.Text;
                int jinyong = jinyong_cmb.SelectedIndex;//0正常 1禁用

                //本地数据实体
                articulo.bianhao = goodNum;
                articulo.codigo = tiaoxing;
                articulo.namecn = zhcName;
                articulo.namees = enName;
                articulo.baozhuangshu = decimal.Parse(baozhuangshu);
                articulo.zhuangxiangshu = decimal.Parse(zhaungxiangshu);
                articulo.py = gonghuo;//供货对应字段
                articulo.px = int.Parse(rank);
                articulo.beizhu = beizhu;
                articulo.jinjia = decimal.Parse(jinjie);
                articulo.maijia = decimal.Parse(shijai1);
                articulo.des = decimal.Parse(shijai_tt);
                articulo.maijia2 = decimal.Parse(shijai2);
                articulo.des2 = decimal.Parse(shijia_tt);
                articulo.maijia3 = decimal.Parse(shijia3);
                articulo.des3 = decimal.Parse(shijia_ttt);
                articulo.kucun = decimal.Parse(mubiaokucun);
                articulo.kucun2 = decimal.Parse(zuidikucun);
                articulo.weizhi = goodposition;
                articulo.riqi = DateTime.Now;
                articulo.fecha = DateTime.Parse(modifyDate);
                articulo.jinyong = jinyong;

                //同步到云端API的JSON数据
                goods["goodsNum"] = goodNum;//产品编号
                goods["cat_id"] = goodType;
                goods["goosName"] = zhcName;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"产品内容填写错误{ex.Message}！");
                Logger.Error(ex.Message);
                return;
            }

            //产品信息保存到本地
            try
            {
                goodsDel.Insert(articulo);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"添加数据到本地数据库失败：{ex.Message}！");
                Logger.Error(ex.Message);
                return;
            }

            //同步到云数据库
            try
            {
                var restclient = new RestClient(Globle.ClouldWebAPI);
                string api = "";
                if (actoinType == ActoinType.add)
                {
                    api = "/api/Goods/insert";

                }
                else if (actoinType == ActoinType.modify)
                {
                    api = "/api/Goods/update";
                }

                var request = new RestRequest(api, Method.POST);
                request.AddHeader("Content-Type", "application/json");
                request.AddJsonBody(goods);
                var response = restclient.Execute(request);
                var resout = JsonConvert.DeserializeObject<bool>(response.Content);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"同步到云端失败:{ex.Message}！");
                Logger.Error(ex.Message);
                return;
            }
        }

    }

    public enum ActoinType
    {
        add = 0,
        modify = 1,

    }
}
