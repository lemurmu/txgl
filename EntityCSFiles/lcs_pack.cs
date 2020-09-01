using System;
using System.Linq;
using System.Text;

namespace Lcs.Entity
{
    ///<summary>
    ///
    ///</summary>
    public partial class lcs_pack
    {
           public lcs_pack(){


           }
           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:False
           /// </summary>           
           public byte pack_id {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string pack_name {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string pack_img {get;set;}

           /// <summary>
           /// Desc:
           /// Default:0.00
           /// Nullable:False
           /// </summary>           
           public decimal pack_fee {get;set;}

           /// <summary>
           /// Desc:
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public short free_money {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string pack_desc {get;set;}

    }
}
