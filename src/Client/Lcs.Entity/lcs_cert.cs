using System;
using System.Linq;
using System.Text;

namespace Lcs.Entity
{
    ///<summary>
    ///
    ///</summary>
    public partial class lcs_cert
    {
           public lcs_cert(){


           }
           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:False
           /// </summary>           
           public int id {get;set;}

           /// <summary>
           /// Desc:配置id
           /// Default:
           /// Nullable:False
           /// </summary>           
           public byte config_id {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:False
           /// </summary>           
           public byte[] file {get;set;}

    }
}
