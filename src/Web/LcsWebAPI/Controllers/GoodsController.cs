using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Lcs.DataAccess;
using Lcs.Entity;
using LcsWebAPI.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;

namespace LcsWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GoodsController : ControllerBase
    {
        private GoodsDel goodsDel = new GoodsDel();

        public readonly AppSettingModel _appSettingModel;
        //注入;
        public GoodsController(IOptions<AppSettingModel> appSettingModel)
        {
            _appSettingModel = appSettingModel.Value;
            DbConfig.ConnectionString = _appSettingModel.ConnectionString;
        }

        [Route("list")]
        [HttpGet]
        public List<lcs_goods> GetGoodsList()
        {
            return goodsDel.GetGoodsList();
        }


        [Route("insert")]
        [HttpPost]
        public bool Insert([FromBody] lcs_goods lcs_Goods)
         {
            try
            {
                goodsDel.Insert(lcs_Goods);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }


        [Route("update")]
        [HttpPost]
        public bool Update([FromBody] lcs_goods lcs_Goods)
        {
            return goodsDel.UpDate(lcs_Goods);
        }


        [Route("delete")]
        [HttpPost]
        public bool Delete([FromBody] lcs_goods lcs_Goods)
        {
            return goodsDel.Delete(lcs_Goods);
        }



    }
}
