using System;
namespace LogsManager.Model
{
	/// <summary>
	/// Info_User_Model:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class Info_User_Model
	{
		public Info_User_Model()
		{}
		#region Model
		private Guid _userid;
		private string _username;
		private string _useravatar;
		private int? _usersex;
		private string _userphone;
		private string _accountnum;
		private string _pwd;
		private Guid _createuser;
		private DateTime _createtime;
		private Guid _updateuser;
		private DateTime? _updatetime;
		private bool _isdelete= false;
		private string _remark;
		/// <summary>
		/// 用户ID
		/// </summary>
		public Guid UserID
		{
			set{ _userid=value;}
			get{return _userid;}
		}
		/// <summary>
		/// 用户姓名
		/// </summary>
		public string UserName
		{
			set{ _username=value;}
			get{return _username;}
		}
		/// <summary>
		/// 用户头像
		/// </summary>
		public string UserAvatar
		{
			set{ _useravatar=value;}
			get{return _useravatar;}
		}
		/// <summary>
		/// 用户性别
		/// </summary>
		public int? UserSex
		{
			set{ _usersex=value;}
			get{return _usersex;}
		}
		/// <summary>
		/// 手机号
		/// </summary>
		public string UserPhone
		{
			set{ _userphone=value;}
			get{return _userphone;}
		}
		/// <summary>
		/// 账号
		/// </summary>
		public string AccountNum
		{
			set{ _accountnum=value;}
			get{return _accountnum;}
		}
		/// <summary>
		/// 密码
		/// </summary>
		public string Pwd
		{
			set{ _pwd=value;}
			get{return _pwd;}
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

