using gregn6Lib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace LCSClientApplication.CommonToolKit
{
    /// <summary>
    /// Gird++报表的辅助类
    /// </summary>
    public class GridReportHelper
    {
        private struct MatchFieldPairType
        {
            public IGRField grField;
            public int MatchColumnIndex;
        }

        /// <summary>
        /// 将 DataReader 的数据转储到 Grid++Report 的数据集中
        /// </summary>
        /// <param name="Report">报表对象</param>
        /// <param name="dr">DataReader对象</param>
        public static void FillRecordToReport(IGridppReport Report, IDataReader dr)
        {
            MatchFieldPairType[] MatchFieldPairs = new MatchFieldPairType[Math.Min(Report.DetailGrid.Recordset.Fields.Count, dr.FieldCount)];

            //根据字段名称与列名称进行匹配，建立DataReader字段与Grid++Report记录集的字段之间的对应关系
            int MatchFieldCount = 0;
            for (int i = 0; i < dr.FieldCount; ++i)
            {
                foreach (IGRField fld in Report.DetailGrid.Recordset.Fields)
                {
                    if (string.Compare(fld.RunningDBField, dr.GetName(i), true) == 0)
                    {
                        MatchFieldPairs[MatchFieldCount].grField = fld;
                        MatchFieldPairs[MatchFieldCount].MatchColumnIndex = i;
                        ++MatchFieldCount;
                        break;
                    }
                }
            }

            // 将 DataReader 中的每一条记录转储到Grid++Report 的数据集中去
            while (dr.Read())
            {
                Report.DetailGrid.Recordset.Append();
                for (int i = 0; i < MatchFieldCount; ++i)
                {
                    var columnIndex = MatchFieldPairs[i].MatchColumnIndex;
                    if (!dr.IsDBNull(columnIndex))
                    {
                        MatchFieldPairs[i].grField.Value = dr.GetValue(columnIndex);
                    }
                }
                Report.DetailGrid.Recordset.Post();
            }
        }

        /// <summary>
        /// 将 DataTable 的数据转储到 Grid++Report 的数据集中
        /// </summary>
        /// <param name="Report">报表对象</param>
        /// <param name="dt">DataTable对象</param>
        public static void FillRecordToReport(IGridppReport Report, DataTable dt)
        {
            MatchFieldPairType[] MatchFieldPairs = new MatchFieldPairType[Math.Min(Report.DetailGrid.Recordset.Fields.Count, dt.Columns.Count)];

            //根据字段名称与列名称进行匹配，建立DataReader字段与Grid++Report记录集的字段之间的对应关系
            int MatchFieldCount = 0;
            for (int i = 0; i < dt.Columns.Count; ++i)
            {
                foreach (IGRField fld in Report.DetailGrid.Recordset.Fields)
                {
                    if (string.Compare(fld.Name, dt.Columns[i].ColumnName, true) == 0)
                    {
                        MatchFieldPairs[MatchFieldCount].grField = fld;
                        MatchFieldPairs[MatchFieldCount].MatchColumnIndex = i;
                        ++MatchFieldCount;
                        break;
                    }
                }
            }

            // 将 DataTable 中的每一条记录转储到 Grid++Report 的数据集中去
            foreach (DataRow dr in dt.Rows)
            {
                Report.DetailGrid.Recordset.Append();
                for (int i = 0; i < MatchFieldCount; ++i)
                {
                    var columnIndex = MatchFieldPairs[i].MatchColumnIndex;
                    if (!dr.IsNull(columnIndex))
                    {
                        MatchFieldPairs[i].grField.Value = dr[columnIndex];
                    }
                }
                Report.DetailGrid.Recordset.Post();
            }
        }

        /// <summary>
        /// List加载数据集
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="Report">报表对象</param>
        /// <param name="list">列表数据</param>
        public static void FillRecordToReport<T>(IGridppReport Report, List<T> list)
        {
            Type type = typeof(T);  //反射类型             

            MatchFieldPairType[] MatchFieldPairs = new MatchFieldPairType[Math.Min(Report.DetailGrid.Recordset.Fields.Count, type.GetProperties().Length)];

            //根据字段名称与列名称进行匹配，建立字段与Grid++Report记录集的字段之间的对应关系
            int MatchFieldCount = 0;
            int i = 0;
            MemberInfo[] members = type.GetMembers();
            foreach (MemberInfo memberInfo in members)
            {
                foreach (IGRField fld in Report.DetailGrid.Recordset.Fields)
                {
                    if (string.Compare(fld.Name, memberInfo.Name, true) == 0)
                    {
                        MatchFieldPairs[MatchFieldCount].grField = fld;
                        MatchFieldPairs[MatchFieldCount].MatchColumnIndex = i;
                        ++MatchFieldCount;
                        break;
                    }
                }
                ++i;
            }

            // 将 DataTable 中的每一条记录转储到 Grid++Report 的数据集中去
            foreach (T t in list)
            {
                Report.DetailGrid.Recordset.Append();
                for (i = 0; i < MatchFieldCount; ++i)
                {
                    object objValue = GetPropertyValue(t, MatchFieldPairs[i].grField.Name);
                    if (objValue != null)
                    {
                        MatchFieldPairs[i].grField.Value = objValue;
                    }
                }
                Report.DetailGrid.Recordset.Post();
            }
        }

        /// <summary>
        /// 获取对象实例的属性值
        /// </summary>
        /// <param name="obj">对象实例</param>
        /// <param name="name">属性名称</param>
        /// <returns></returns>
        public static object GetPropertyValue(object obj, string name)
        {
            //这个无法获取基类
            //PropertyInfo fieldInfo = obj.GetType().GetProperty(name, bf);
            //return fieldInfo.GetValue(obj, null);

            //下面方法可以获取基类属性
            object result = null;
            foreach (PropertyDescriptor prop in TypeDescriptor.GetProperties(obj))
            {
                if (prop.Name == name)
                {
                    result = prop.GetValue(obj);
                }
            }
            return result;
        }
    }
}
