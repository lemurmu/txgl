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

namespace LCSClientApplication.Controls
{
    public partial class ActionProductCtr : CCSkinMain
    {
        public ActionProductCtr(ActoinType actoinType)
        {
            InitializeComponent();
            this.actoinType = actoinType;
        }

        ActoinType actoinType;
        private void skinButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void skinButton1_Click(object sender, EventArgs e)
        {
            lcs_goods goods = new lcs_goods
            {
                cat_id = short.Parse(goods_id_txt.Text),
                goods_thumb = goods_thumb_txt.Text,
                goods_name = zh_name_txt.Text,

            };
            var restclient = new RestClient("https://localhost:5001");
            var rq = new RestRequest("/api/Goods/list", Method.GET);
            IRestResponse resp = restclient.Execute(rq);
            List<lcs_goods> list = JsonConvert.DeserializeObject<List<lcs_goods>>(resp.Content);
            goods = list[0];

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


    }

    public enum ActoinType
    {
        add = 0,
        modify = 1,

    }
}
