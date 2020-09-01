using System;
using System.Linq;
using System.Text;

namespace Lcs.Entity
{
    ///<summary>
    ///
    ///</summary>
    public partial class lcs_keywords
    {
           public lcs_keywords(){


           }
           /// <summary>
           /// Desc:
           /// Default:0000-00-00
           /// Nullable:False
           /// </summary>           
           public DateTime date {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string searchengine {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string keyword {get;set;}

           /// <summary>
           /// Desc:
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public int count {get;set;}

    }
}
