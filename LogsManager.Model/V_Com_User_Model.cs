using System;
namespace LogsManager.Model
{
    /// <summary>
    /// V_Com_User_Model:实体类(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Serializable]
    public partial class V_Com_User_Model
    {
        public V_Com_User_Model()
        {}
        #region Model
        private Guid _commentid;
        private Guid _logsid;
        private string _commentcontent;
        private Guid _commentator;
        private DateTime _commenttime;
        private bool _isdelete;
        private string _username;
        /// <summary>
        /// 
        /// </summary>
        public Guid CommentID
        {
            set{ _commentid=value;}
            get{return _commentid;}
        }
        /// <summary>
        /// 
        /// </summary>
        public Guid LogsID
        {
            set{ _logsid=value;}
            get{return _logsid;}
        }
        /// <summary>
        /// 
        /// </summary>
        public string CommentContent
        {
            set{ _commentcontent=value;}
            get{return _commentcontent;}
        }
        /// <summary>
        /// 
        /// </summary>
        public Guid Commentator
        {
            set{ _commentator=value;}
            get{return _commentator;}
        }
        /// <summary>
        /// 
        /// </summary>
        public DateTime CommentTime
        {
            set{ _commenttime=value;}
            get{return _commenttime;}
        }
        /// <summary>
        /// 
        /// </summary>
        public bool IsDelete
        {
            set{ _isdelete=value;}
            get{return _isdelete;}
        }
        /// <summary>
        /// 
        /// </summary>
        public string UserName
        {
            set{ _username=value;}
            get{return _username;}
        }
        #endregion Model

    }
}