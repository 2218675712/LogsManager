using System;
namespace Maticsoft.Model
{
    /// <summary>
    /// Info_Logs_Model:实体类(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Serializable]
    public partial class Info_Logs_Model
    {
        public Info_Logs_Model()
        {}
        #region Model
        private Guid _logsid;
        private string _logstitle;
        private string _logscontent;
        private string _coverpictureurl;
        private Guid _createuser;
        private DateTime _createtime;
        private Guid _updateuser;
        private DateTime? _updatetime;
        private bool _isdelete= false;
        private string _remark;
        /// <summary>
        /// 日志ID
        /// </summary>
        public Guid LogsID
        {
            set{ _logsid=value;}
            get{return _logsid;}
        }
        /// <summary>
        /// 标题
        /// </summary>
        public string LogsTitle
        {
            set{ _logstitle=value;}
            get{return _logstitle;}
        }
        /// <summary>
        /// 内容
        /// </summary>
        public string LogsContent
        {
            set{ _logscontent=value;}
            get{return _logscontent;}
        }
        /// <summary>
        /// 封面图片
        /// </summary>
        public string CoverPictureUrl
        {
            set{ _coverpictureurl=value;}
            get{return _coverpictureurl;}
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
        /// 更新人
        /// </summary>
        public Guid UpdateUser
        {
            set{ _updateuser=value;}
            get{return _updateuser;}
        }
        /// <summary>
        /// 更新时间
        /// </summary>
        public DateTime? UpdateTime
        {
            set{ _updatetime=value;}
            get{return _updatetime;}
        }
        /// <summary>
        /// 逻辑删除
        /// </summary>
        public bool isDelete
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