using System;
using System.Linq;
using System.Text;

namespace Lcs.Entity
{
    ///<summary>
    ///
    ///</summary>
    public partial class lcs_push
    {
           public lcs_push(){


           }
           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:False
           /// </summary>           
           public int id {get;set;}

           /// <summary>
           /// Desc:
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public int user_id {get;set;}

           /// <summary>
           /// Desc:标题
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string title {get;set;}

           /// <summary>
           /// Desc:内容
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string content {get;set;}

           /// <summary>
           /// Desc:图片
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string photo {get;set;}

           /// <summary>
           /// Desc:leancloud返回的objectId
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string objectId {get;set;}

           /// <summary>
           /// Desc:链接
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string link {get;set;}

           /// <summary>
           /// Desc:平台类型
           /// Default:3
           /// Nullable:False
           /// </summary>           
           public byte platform {get;set;}

           /// <summary>
           /// Desc:任务类型 1 定时任务 0 即时推送
           /// Default:0
           /// Nullable:True
           /// </summary>           
           public byte? push_type {get;set;}

           /// <summary>
           /// Desc:消息类型 1　系统消息 ２ 物流消息
           /// Default:1
           /// Nullable:True
           /// </summary>           
           public byte? message_type {get;set;}

           /// <summary>
           /// Desc:定时任务是否已经推送
           /// Default:0
           /// Nullable:True
           /// </summary>           
           public byte? isPush {get;set;}

           /// <summary>
           /// Desc:定时推送时间
           /// Default:
           /// Nullable:True
           /// </summary>           
           public DateTime? push_at {get;set;}

           /// <summary>
           /// Desc:状态 0:关闭 1:开启 默认开启
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
