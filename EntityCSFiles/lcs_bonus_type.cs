using System;
using System.Linq;
using System.Text;

namespace Lcs.Entity
{
    ///<summary>
    ///
    ///</summary>
    public partial class lcs_bonus_type
    {
           public lcs_bonus_type(){


           }
           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:False
           /// </summary>           
           public short type_id {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string type_name {get;set;}

           /// <summary>
           /// Desc:
           /// Default:0.00
           /// Nullable:False
           /// </summary>           
           public decimal type_money {get;set;}

           /// <summary>
           /// Desc:
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public byte send_type {get;set;}

           /// <summary>
           /// Desc:
           /// Default:0.00
           /// Nullable:False
           /// </summary>           
           public decimal min_amount {get;set;}

           /// <summary>
           /// Desc:
           /// Default:0.00
           /// Nullable:False
           /// </summary>           
           public decimal max_amount {get;set;}

           /// <summary>
           /// Desc:
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public int send_start_date {get;set;}

           /// <summary>
           /// Desc:
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public int send_end_date {get;set;}

           /// <summary>
           /// Desc:
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public int use_start_date {get;set;}

           /// <summary>
           /// Desc:
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public int use_end_date {get;set;}

           /// <summary>
           /// Desc:
           /// Default:0.00
           /// Nullable:False
           /// </summary>           
           public decimal min_goods_amount {get;set;}

    }
}
