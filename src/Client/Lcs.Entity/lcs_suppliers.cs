using System;
using System.Linq;
using System.Text;

namespace Lcs.Entity
{
    ///<summary>
    ///
    ///</summary>
    public partial class lcs_suppliers
    {
           public lcs_suppliers(){


           }
           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:False
           /// </summary>           
           public short suppliers_id {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string suppliers_name {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string suppliers_desc {get;set;}

           /// <summary>
           /// Desc:
           /// Default:1
           /// Nullable:False
           /// </summary>           
           public byte is_check {get;set;}

    }
}
