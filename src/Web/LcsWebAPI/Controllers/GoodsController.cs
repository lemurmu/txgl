using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Lcs.DataAccess;
using Lcs.Entity;
using LcsWebAPI.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

namespace LcsWebAPI.Controllers
{
  //  [Route("api/[controller]")]
    [ApiController]
    public class GoodsController : ControllerBase
    {
        //private GoodsDel goodsDel = new GoodsDel();

        //private readonly AppSettingModel _appSettingModel;
        //private readonly ILogger<GoodsController> _logger;
        ////注入;
        //public GoodsController(IOptions<AppSettingModel> appSettingModel, ILogger<GoodsController> logger)
        //{
        //    _appSettingModel = appSettingModel.Value;
        //    DbConfig.ConnectionString = _appSettingModel.ConnectionString;
        //    _logger = logger;
        //}

        //[Route("list")]
        //[HttpGet]
        //public List<lcs_goods> GetGoodsList()
        //{
        //    return goodsDel.GetGoodsList();
        //}


        //[Route("insert")]
        //[HttpPost]
        //public bool Insert([FromBody] lcs_goods lcs_Goods)
        // {
        //    try
        //    {
        //        goodsDel.Insert(lcs_Goods);
        //        _logger.LogInformation("商品成功添加");
        //        return true;
        //    } 
        //    catch (Exception ex)
        //    {
        //        _logger.LogError(ex,"商品添加失败");
        //        return false;
        //    }
        //}
         



        //[Route("update")]
        //[HttpPost]
        //public bool Update([FromBody] lcs_goods lcs_Goods)
        //{
        //    return goodsDel.UpDate(lcs_Goods);``````````
        
        //}


        //[Route("delete")]
        //[HttpPost]
        //public bool Delete([FromBody] lcs_goods lcs_Goods)
        //{
        //    return goodsDel.Delete(lcs_Goods);
        //}



    }
}
