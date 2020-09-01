using System;
using System.Linq;
using System.Text;

namespace Lcs.Entity
{
    ///<summary>
    ///
    ///</summary>
    public partial class lcs_shop_bind
    {
           public lcs_shop_bind(){


           }
           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:False
           /// </summary>           
           public int shop_id {get;set;}

           /// <summary>
           /// Desc:名称
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string name {get;set;}

           /// <summary>
           /// Desc:节点
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string node_id {get;set;}

           /// <summary>
           /// Desc:节点类型
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string node_type {get;set;}

           /// <summary>
           /// Desc:状态
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string status {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string app_url {get;set;}

    }
}
