﻿﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Xml.Serialization;
using XCode;
using XCode.Configuration;
using XCode.DataAccessLayer;

namespace NewLife.CMX
{
    /// <summary>实体分类</summary>
    [Serializable]
    [DataObject]
    [Description("实体分类")]
    [BindIndex("IX_EntityCategory_Name", false, "Name")]
    [BindIndex("IX_EntityCategory_ParentID", false, "ParentID")]
    [BindIndex("IU_EntityCategory_ParentID_Name", true, "ParentID,Name")]
    [BindTable("EntityCategory", Description = "实体分类", ConnName = "CMX", DbType = DatabaseType.None)]
    public abstract partial class EntityCategory<TEntity> : IEntityCategory
    {
        #region 属性
        private Int32 _ID;
        /// <summary>编号</summary>
        [DisplayName("编号")]
        [Description("编号")]
        [DataObjectField(true, true, false, 10)]
        [BindColumn(1, "ID", "编号", null, "int", 10, 0, false)]
        public virtual Int32 ID
        {
            get { return _ID; }
            set { if (OnPropertyChanging(__.ID, value)) { _ID = value; OnPropertyChanged(__.ID); } }
        }

        private String _Name;
        /// <summary>名称</summary>
        [DisplayName("名称")]
        [Description("名称")]
        [DataObjectField(false, false, false, 50)]
        [BindColumn(2, "Name", "名称", null, "nvarchar(50)", 0, 0, true)]
        public virtual String Name
        {
            get { return _Name; }
            set { if (OnPropertyChanging(__.Name, value)) { _Name = value; OnPropertyChanged(__.Name); } }
        }

        private Int32 _ParentID;
        /// <summary>父类</summary>
        [DisplayName("父类")]
        [Description("父类")]
        [DataObjectField(false, false, true, 10)]
        [BindColumn(3, "ParentID", "父类", null, "int", 10, 0, false)]
        public virtual Int32 ParentID
        {
            get { return _ParentID; }
            set { if (OnPropertyChanging(__.ParentID, value)) { _ParentID = value; OnPropertyChanged(__.ParentID); } }
        }

        private Boolean _IsEnd;
        /// <summary>是否最终分类</summary>
        [DisplayName("是否最终分类")]
        [Description("是否最终分类")]
        [DataObjectField(false, false, true, 1)]
        [BindColumn(4, "IsEnd", "是否最终分类", null, "bit", 0, 0, false)]
        public virtual Boolean IsEnd
        {
            get { return _IsEnd; }
            set { if (OnPropertyChanging(__.IsEnd, value)) { _IsEnd = value; OnPropertyChanged(__.IsEnd); } }
        }

        private Int32 _Sort;
        /// <summary>排序</summary>
        [DisplayName("排序")]
        [Description("排序")]
        [DataObjectField(false, false, true, 10)]
        [BindColumn(5, "Sort", "排序", null, "int", 10, 0, false)]
        public virtual Int32 Sort
        {
            get { return _Sort; }
            set { if (OnPropertyChanging(__.Sort, value)) { _Sort = value; OnPropertyChanged(__.Sort); } }
        }

        private Int32 _Num;
        /// <summary>数量</summary>
        [DisplayName("数量")]
        [Description("数量")]
        [DataObjectField(false, false, true, 10)]
        [BindColumn(6, "Num", "数量", null, "int", 10, 0, false)]
        public virtual Int32 Num
        {
            get { return _Num; }
            set { if (OnPropertyChanging(__.Num, value)) { _Num = value; OnPropertyChanged(__.Num); } }
        }

        private String _CategoryTemplate;
        /// <summary>分类页模版。前台分类页</summary>
        [DisplayName("分类页模版")]
        [Description("分类页模版。前台分类页")]
        [DataObjectField(false, false, true, 200)]
        [BindColumn(7, "CategoryTemplate", "分类页模版。前台分类页", null, "nvarchar(200)", 0, 0, true)]
        public virtual String CategoryTemplate
        {
            get { return _CategoryTemplate; }
            set { if (OnPropertyChanging(__.CategoryTemplate, value)) { _CategoryTemplate = value; OnPropertyChanged(__.CategoryTemplate); } }
        }

        private String _TitleTemplate;
        /// <summary>标题页模版。前台列表页</summary>
        [DisplayName("标题页模版")]
        [Description("标题页模版。前台列表页")]
        [DataObjectField(false, false, true, 200)]
        [BindColumn(8, "TitleTemplate", "标题页模版。前台列表页", null, "nvarchar(200)", 0, 0, true)]
        public virtual String TitleTemplate
        {
            get { return _TitleTemplate; }
            set { if (OnPropertyChanging(__.TitleTemplate, value)) { _TitleTemplate = value; OnPropertyChanged(__.TitleTemplate); } }
        }

        private String _ContentTemplate;
        /// <summary>内容页模版。前台内容页</summary>
        [DisplayName("内容页模版")]
        [Description("内容页模版。前台内容页")]
        [DataObjectField(false, false, true, 200)]
        [BindColumn(9, "ContentTemplate", "内容页模版。前台内容页", null, "nvarchar(200)", 0, 0, true)]
        public virtual String ContentTemplate
        {
            get { return _ContentTemplate; }
            set { if (OnPropertyChanging(__.ContentTemplate, value)) { _ContentTemplate = value; OnPropertyChanged(__.ContentTemplate); } }
        }

        private String _Remark;
        /// <summary>备注</summary>
        [DisplayName("备注")]
        [Description("备注")]
        [DataObjectField(false, false, true, 200)]
        [BindColumn(10, "Remark", "备注", null, "nvarchar(200)", 0, 0, true)]
        public virtual String Remark
        {
            get { return _Remark; }
            set { if (OnPropertyChanging(__.Remark, value)) { _Remark = value; OnPropertyChanged(__.Remark); } }
        }
        #endregion

        #region 获取/设置 字段值
        /// <summary>
        /// 获取/设置 字段值。
        /// 一个索引，基类使用反射实现。
        /// 派生实体类可重写该索引，以避免反射带来的性能损耗
        /// </summary>
        /// <param name="name">字段名</param>
        /// <returns></returns>
        public override Object this[String name]
        {
            get
            {
                switch (name)
                {
                    case __.ID : return _ID;
                    case __.Name : return _Name;
                    case __.ParentID : return _ParentID;
                    case __.IsEnd : return _IsEnd;
                    case __.Sort : return _Sort;
                    case __.Num : return _Num;
                    case __.CategoryTemplate : return _CategoryTemplate;
                    case __.TitleTemplate : return _TitleTemplate;
                    case __.ContentTemplate : return _ContentTemplate;
                    case __.Remark : return _Remark;
                    default: return base[name];
                }
            }
            set
            {
                switch (name)
                {
                    case __.ID : _ID = Convert.ToInt32(value); break;
                    case __.Name : _Name = Convert.ToString(value); break;
                    case __.ParentID : _ParentID = Convert.ToInt32(value); break;
                    case __.IsEnd : _IsEnd = Convert.ToBoolean(value); break;
                    case __.Sort : _Sort = Convert.ToInt32(value); break;
                    case __.Num : _Num = Convert.ToInt32(value); break;
                    case __.CategoryTemplate : _CategoryTemplate = Convert.ToString(value); break;
                    case __.TitleTemplate : _TitleTemplate = Convert.ToString(value); break;
                    case __.ContentTemplate : _ContentTemplate = Convert.ToString(value); break;
                    case __.Remark : _Remark = Convert.ToString(value); break;
                    default: base[name] = value; break;
                }
            }
        }
        #endregion

        #region 字段名
        /// <summary>取得实体分类字段信息的快捷方式</summary>
        partial class _
        {
            ///<summary>编号</summary>
            public static readonly Field ID = FindByName(__.ID);

            ///<summary>名称</summary>
            public static readonly Field Name = FindByName(__.Name);

            ///<summary>父类</summary>
            public static readonly Field ParentID = FindByName(__.ParentID);

            ///<summary>是否最终分类</summary>
            public static readonly Field IsEnd = FindByName(__.IsEnd);

            ///<summary>排序</summary>
            public static readonly Field Sort = FindByName(__.Sort);

            ///<summary>数量</summary>
            public static readonly Field Num = FindByName(__.Num);

            ///<summary>分类页模版。前台分类页</summary>
            public static readonly Field CategoryTemplate = FindByName(__.CategoryTemplate);

            ///<summary>标题页模版。前台列表页</summary>
            public static readonly Field TitleTemplate = FindByName(__.TitleTemplate);

            ///<summary>内容页模版。前台内容页</summary>
            public static readonly Field ContentTemplate = FindByName(__.ContentTemplate);

            ///<summary>备注</summary>
            public static readonly Field Remark = FindByName(__.Remark);

            static Field FindByName(String name) { return Meta.Table.FindByName(name); }
        }

        /// <summary>取得实体分类字段名称的快捷方式</summary>
        partial class __
        {
            ///<summary>编号</summary>
            public const String ID = "ID";

            ///<summary>名称</summary>
            public const String Name = "Name";

            ///<summary>父类</summary>
            public const String ParentID = "ParentID";

            ///<summary>是否最终分类</summary>
            public const String IsEnd = "IsEnd";

            ///<summary>排序</summary>
            public const String Sort = "Sort";

            ///<summary>数量</summary>
            public const String Num = "Num";

            ///<summary>分类页模版。前台分类页</summary>
            public const String CategoryTemplate = "CategoryTemplate";

            ///<summary>标题页模版。前台列表页</summary>
            public const String TitleTemplate = "TitleTemplate";

            ///<summary>内容页模版。前台内容页</summary>
            public const String ContentTemplate = "ContentTemplate";

            ///<summary>备注</summary>
            public const String Remark = "Remark";

        }
        #endregion
    }

    /// <summary>实体分类接口</summary>
    public partial interface IEntityCategory : IEntityTree
    {
        #region 属性
        /// <summary>编号</summary>
        Int32 ID { get; set; }

        /// <summary>名称</summary>
        String Name { get; set; }

        /// <summary>父类</summary>
        Int32 ParentID { get; set; }

        /// <summary>是否最终分类</summary>
        Boolean IsEnd { get; set; }

        /// <summary>排序</summary>
        Int32 Sort { get; set; }

        /// <summary>数量</summary>
        Int32 Num { get; set; }

        /// <summary>分类页模版。前台分类页</summary>
        String CategoryTemplate { get; set; }

        /// <summary>标题页模版。前台列表页</summary>
        String TitleTemplate { get; set; }

        /// <summary>内容页模版。前台内容页</summary>
        String ContentTemplate { get; set; }

        /// <summary>备注</summary>
        String Remark { get; set; }
        #endregion
    }
}