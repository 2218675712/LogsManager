using System;
using System.Data;
using System.Collections.Generic;
using LogsManager.DAL;
using LogsManager.Model;
namespace LogsManager.BLL
{
	/// <summary>
	/// V_Com_User_BLL
	/// </summary>
	public partial class V_Com_User_BLL
	{
		private readonly V_Com_User_DAL dal=new V_Com_User_DAL();
		public V_Com_User_BLL()
		{}
		#region  BasicMethod
		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(Guid CommentID,Guid LogsID,string CommentContent,Guid Commentator,DateTime CommentTime,bool IsDelete,string UserName)
		{
			return dal.Exists(CommentID,LogsID,CommentContent,Commentator,CommentTime,IsDelete,UserName);
		}

		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(V_Com_User_Model model)
		{
			return dal.Add(model);
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(V_Com_User_Model model)
		{
			return dal.Update(model);
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Delete(Guid CommentID,Guid LogsID,string CommentContent,Guid Commentator,DateTime CommentTime,bool IsDelete,string UserName)
		{
			
			return dal.Delete(CommentID,LogsID,CommentContent,Commentator,CommentTime,IsDelete,UserName);
		}

		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public V_Com_User_Model GetModel(Guid CommentID,Guid LogsID,string CommentContent,Guid Commentator,DateTime CommentTime,bool IsDelete,string UserName)
		{
			
			return dal.GetModel(CommentID,LogsID,CommentContent,Commentator,CommentTime,IsDelete,UserName);
		}

		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetList(string strWhere)
		{
			return dal.GetList(strWhere);
		}
		/// <summary>
		/// 获得前几行数据
		/// </summary>
		public DataSet GetList(int Top,string strWhere,string filedOrder)
		{
			return dal.GetList(Top,strWhere,filedOrder);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<V_Com_User_Model> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<V_Com_User_Model> DataTableToList(DataTable dt)
		{
			List<V_Com_User_Model> modelList = new List<V_Com_User_Model>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				V_Com_User_Model model;
				for (int n = 0; n < rowsCount; n++)
				{
					model = dal.DataRowToModel(dt.Rows[n]);
					if (model != null)
					{
						modelList.Add(model);
					}
				}
			}
			return modelList;
		}

		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetAllList()
		{
			return GetList("");
		}

		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		public int GetRecordCount(string strWhere)
		{
			return dal.GetRecordCount(strWhere);
		}
		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		public DataSet GetListByPage(string strWhere, string orderby, int startIndex, int endIndex)
		{
			return dal.GetListByPage( strWhere,  orderby,  startIndex,  endIndex);
		}
		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		//public DataSet GetList(int PageSize,int PageIndex,string strWhere)
		//{
			//return dal.GetList(PageSize,PageIndex,strWhere);
		//}

		#endregion  BasicMethod
		#region  ExtensionMethod

		#endregion  ExtensionMethod
	}
}

