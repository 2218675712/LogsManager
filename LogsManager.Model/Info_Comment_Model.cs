using System;
namespace LogsManager.Model
{
    /// <summary>
    /// Info_Comment_Model:实体类(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Serializable]
    public partial class Info_Comment_Model
    {
        public Info_Comment_Model()
        {}
        #region Model
        private Guid _commentid;
        private Guid _logsid;
        private string _commentcontent;
        private Guid _commentator;
        private DateTime _commenttime;
        private bool _isdelete= false;
        /// <summary>
        /// 评论ID
        /// </summary>
        public Guid CommentID
        {
            set{ _commentid=value;}
            get{return _commentid;}
        }
        /// <summary>
        /// 日志ID
        /// </summary>
        public Guid LogsID
        {
            set{ _logsid=value;}
            get{return _logsid;}
        }
        /// <summary>
        /// 内容
        /// </summary>
        public string CommentContent
        {
            set{ _commentcontent=value;}
            get{return _commentcontent;}
        }
        /// <summary>
        /// 评论人
        /// </summary>
        public Guid Commentator
        {
            set{ _commentator=value;}
            get{return _commentator;}
        }
        /// <summary>
        /// 评论时间
        /// </summary>
        public DateTime CommentTime
        {
            set{ _commenttime=value;}
            get{return _commenttime;}
        }
        /// <summary>
        /// 逻辑删除
        /// </summary>
        public bool IsDelete
        {
            set{ _isdelete=value;}
            get{return _isdelete;}
        }
        #endregion Model

    }
}