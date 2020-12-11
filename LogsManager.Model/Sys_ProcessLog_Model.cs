using System;
namespace LogsManager.Model
{
    /// <summary>
    /// Sys_ProcessLog_Model:实体类(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Serializable]
    public partial class Sys_ProcessLog_Model
    {
        public Sys_ProcessLog_Model()
        {}
        #region Model
        private Guid _id;
        private int? _logtype;
        private string _logdescription;
        private Guid _createuser;
        private DateTime _createtime;
        private bool _isdelete= false;
        private string _remark;
        /// <summary>
        /// 主键
        /// </summary>
        public Guid ID
        {
            set{ _id=value;}
            get{return _id;}
        }
        /// <summary>
        /// 日志类型
        /// </summary>
        public int? LogType
        {
            set{ _logtype=value;}
            get{return _logtype;}
        }
        /// <summary>
        /// 描述信息
        /// </summary>
        public string LogDescription
        {
            set{ _logdescription=value;}
            get{return _logdescription;}
        }
        /// <summary>
        /// 创建人
        /// </summary>
        public Guid CreateUser
        {
            set{ _createuser=value;}
            get{return _createuser;}
        }
        /// <summary>
        /// 创建时间
        /// </summary>
        public DateTime CreateTime
        {
            set{ _createtime=value;}
            get{return _createtime;}
        }
        /// <summary>
        /// 逻辑删除
        /// </summary>
        public bool IsDelete
        {
            set{ _isdelete=value;}
            get{return _isdelete;}
        }
        /// <summary>
        /// 备注(备用字段)
        /// </summary>
        public string Remark
        {
            set{ _remark=value;}
            get{return _remark;}
        }
        #endregion Model

    }
}