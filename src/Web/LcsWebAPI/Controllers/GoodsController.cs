using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CloudDBEntity2;
using LcsWebAPI.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace LcsWebAPI.Controllers
{
    [Route("api/[controller]/[Action]")]
    [ApiController]
    public class GoodsController : ControllerBase
    {

        private readonly h5_lisboa_tkContext _context;
        private readonly ILogger<GoodsController> _logger;


        //注入数据库上下文对象和日志对象
        public GoodsController(h5_lisboa_tkContext context, ILogger<GoodsController> logger)
        {
            _context = context;
            _logger = logger;
        }

        [HttpGet]
        public void Get()
        {

        }

        /// <summary>
        /// 添加产品
        /// </summary>
        /// <param name="lcs_Goods"></param>
        /// <returns></returns>
        [HttpPost]
        public bool Insert(JObject lcs_Goods)
        {
            try
            {
                //_context.LcsGoods.Add(new LcsGoods
                //{



                //});
                _logger.LogInformation("商品成功添加");
                return true;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "商品添加失败");
                return false;
            }
        }


        /// <summary>
        /// 修改
        /// </summary>
        /// <param name="lcs_Goods"></param>
        /// <returns></returns>

        [HttpPost]
        public bool Update(dynamic data)
        {
            try
            {
                //_context.LcsGoods.Update(new LcsGoods
                //{
                JObject jObj = JObject.Parse(data);

                //});
                _logger.LogInformation("修改商品成功");
                return true;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "修改商品成失败");
                return false;
            }
        }

        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="lcs_Goods"></param>
        /// <returns></returns>
        [Route("delete")]
        [HttpPost]
        public bool Delete(JObject lcs_Goods)
        {
            try
            {
                //_context.LcsGoods.Remove(new LcsGoods
                //{



                //});
                _logger.LogInformation("商品成功删除");
                return true;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "商品删除失败");
                return false;
            }
        }



    }
}
