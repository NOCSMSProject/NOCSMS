using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NOCSMS.Model.Tables
{
    public class T_TABLE_DIC_Model
    {
        /// <summary>
        /// 表标识
        /// </summary>
        public int TABLE { get; set; }

        /// <summary>
        /// 表编号
        /// </summary>
        public int TABNO { get; set; }

        /// <summary>
        /// 表中文名
        /// </summary>
        public string TABCN { get; set; }

        /// <summary>
        /// 表英文名
        /// </summary>
        public string TABEN { get; set; }

        /// <summary>
        /// 时间戳
        /// </summary>
        public DateTime MODITIME { get; set; }
    }

    public enum T_TABLE_DIC_ModelFields
    {
        /// <summary>
        /// 表标识
        /// </summary>
        TABID,

        /// <summary>
        /// 表编号
        /// </summary>
        TABNO,

        /// <summary>
        /// 表中文名
        /// </summary>
        TABCN,

        /// <summary>
        /// 表英文名
        /// </summary>
        TABEN,

        /// <summary>
        /// 时间戳
        /// </summary>
        MODITIME
    }

    /// <summary>
    /// 排序类
    /// </summary>
    public class T_TABLE_DIC_ModelOrderType
    {
        private T_TABLE_DIC_ModelFields field;

        private OrderType orderType;

        public T_TABLE_DIC_ModelOrderType(T_TABLE_DIC_ModelFields field)
        {
            this.field = field;
            this.orderType = OrderType.ASC;
        }

        public T_TABLE_DIC_ModelOrderType(T_TABLE_DIC_ModelFields field, OrderType orderType)
        {
            this.field = field;
            this.orderType = orderType;
        }

        public T_TABLE_DIC_ModelFields GetT_TABLE_DIC_ModelFields()
        {
            return this.field;
        }

        public OrderType GetFieldValue()
        {
            return this.orderType;
        }
    }

    /// <summary>
    /// 键值对类
    /// </summary>
    public class T_TABLE_DIC_ModelValuePair
    {
        private T_TABLE_DIC_Model field;

        private object fieldValue;

        public T_TABLE_DIC_ModelValuePair(T_TABLE_DIC_Model field, object fieldValue)
        {
            this.field = field;
            this.fieldValue = fieldValue;
        }

        public T_TABLE_DIC_Model GetT_TABLE_DIC_Model()
        {
            return this.field;
        }

        public object GetFieldValue()
        {
            return this.fieldValue;
        }
    }

    /// <summary>
    /// 条件类
    /// </summary>
    public class T_TABLE_DIC_ModelValueWhere
    {
        private T_TABLE_DIC_Model field;

        private object fieldValue;

        public T_TABLE_DIC_ModelValueWhere(T_TABLE_DIC_Model field ,object fieldValue)
        {
            this.field = field;
            this.fieldValue = fieldValue;
        }

        public T_TABLE_DIC_Model GetT_TABLE_DIC_Model()
        {
            return this.field;
        }

        public object GetFieldValue()
        {
            return this.fieldValue;
        }
    }
}
