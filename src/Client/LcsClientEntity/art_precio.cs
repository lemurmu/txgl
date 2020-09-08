using System;
using System.Linq;
using System.Text;

namespace Lcs.Entity
{
    ///<summary>
    ///商品表
    ///</summary>
    public partial class art_precio
    {
           public art_precio(){


           }
           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:False
           /// </summary>           
           public int id {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string codigo {get;set;}

           /// <summary>
           /// Desc:
           /// Default:1
           /// Nullable:False
           /// </summary>           
           public int ptype {get;set;}

           /// <summary>
           /// Desc:
           /// Default:0.000
           /// Nullable:False
           /// </summary>           
           public decimal precio {get;set;}

           /// <summary>
           /// Desc:
           /// Default:0.000
           /// Nullable:False
           /// </summary>           
           public decimal des {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public DateTime? fecha {get;set;}

    }
}
