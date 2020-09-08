using System;
using System.Linq;
using System.Text;

namespace Lcs.Entity
{
    ///<summary>
    ///
    ///</summary>
    public partial class lcs_device
    {
           public lcs_device(){


           }
           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:False
           /// </summary>           
           public int user_id {get;set;}

           /// <summary>
           /// Desc:设备id
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string device_id {get;set;}

           /// <summary>
           /// Desc:设备类型
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string device_type {get;set;}

           /// <summary>
           /// Desc:平台类型
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string platform_type {get;set;}

           /// <summary>
           /// Desc:推送开关 0:关闭 1:开启 默认开启
           /// Default:1
           /// Nullable:False
           /// </summary>           
           public byte status {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public DateTime? created_at {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public DateTime? updated_at {get;set;}

    }
}
