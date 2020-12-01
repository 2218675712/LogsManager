using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using LogsManager.DBUtility;
using LogsManager.Model;
namespace LogsManager.DAL
{
	/// <summary>
	/// 数据访问类:V_Com_User_DAL
	/// </summary>
	public partial class V_Com_User_DAL
	{
		public V_Com_User_DAL()
		{}
		#region  BasicMethod

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(Guid CommentID,Guid LogsID,string CommentContent,Guid Commentator,DateTime CommentTime,bool IsDelete,string UserName)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from V_Com_User");
			strSql.Append(" where CommentID=SQL2012CommentID and LogsID=SQL2012LogsID and CommentContent=SQL2012CommentContent and Commentator=SQL2012Commentator and CommentTime=SQL2012CommentTime and IsDelete=SQL2012IsDelete and UserName=SQL2012UserName ");
			SqlParameter[] parameters = {
					new SqlParameter("SQL2012CommentID", SqlDbType.UniqueIdentifier,16),
					new SqlParameter("SQL2012LogsID", SqlDbType.UniqueIdentifier,16),
					new SqlParameter("SQL2012CommentContent", SqlDbType.NVarChar,255),
					new SqlParameter("SQL2012Commentator", SqlDbType.UniqueIdentifier,16),
					new SqlParameter("SQL2012CommentTime", SqlDbType.DateTime),
					new SqlParameter("SQL2012IsDelete", SqlDbType.Bit,1),
					new SqlParameter("SQL2012UserName", SqlDbType.NVarChar,255)			};
			parameters[0].Value = CommentID;
			parameters[1].Value = LogsID;
			parameters[2].Value = CommentContent;
			parameters[3].Value = Commentator;
			parameters[4].Value = CommentTime;
			parameters[5].Value = IsDelete;
			parameters[6].Value = UserName;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(V_Com_User_Model model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into V_Com_User(");
			strSql.Append("CommentID,LogsID,CommentContent,Commentator,CommentTime,IsDelete,UserName)");
			strSql.Append(" values (");
			strSql.Append("SQL2012CommentID,SQL2012LogsID,SQL2012CommentContent,SQL2012Commentator,SQL2012CommentTime,SQL2012IsDelete,SQL2012UserName)");
			SqlParameter[] parameters = {
					new SqlParameter("SQL2012CommentID", SqlDbType.UniqueIdentifier,16),
					new SqlParameter("SQL2012LogsID", SqlDbType.UniqueIdentifier,16),
					new SqlParameter("SQL2012CommentContent", SqlDbType.NVarChar,255),
					new SqlParameter("SQL2012Commentator", SqlDbType.UniqueIdentifier,16),
					new SqlParameter("SQL2012CommentTime", SqlDbType.DateTime),
					new SqlParameter("SQL2012IsDelete", SqlDbType.Bit,1),
					new SqlParameter("SQL2012UserName", SqlDbType.NVarChar,255)};
			parameters[0].Value = Guid.NewGuid();
			parameters[1].Value = Guid.NewGuid();
			parameters[2].Value = model.CommentContent;
			parameters[3].Value = Guid.NewGuid();
			parameters[4].Value = model.CommentTime;
			parameters[5].Value = model.IsDelete;
			parameters[6].Value = model.UserName;

			int rows=DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
			if (rows > 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}
		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(V_Com_User_Model model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update V_Com_User set ");
			strSql.Append("CommentID=SQL2012CommentID,");
			strSql.Append("LogsID=SQL2012LogsID,");
			strSql.Append("CommentContent=SQL2012CommentContent,");
			strSql.Append("Commentator=SQL2012Commentator,");
			strSql.Append("CommentTime=SQL2012CommentTime,");
			strSql.Append("IsDelete=SQL2012IsDelete,");
			strSql.Append("UserName=SQL2012UserName");
			strSql.Append(" where CommentID=SQL2012CommentID and LogsID=SQL2012LogsID and CommentContent=SQL2012CommentContent and Commentator=SQL2012Commentator and CommentTime=SQL2012CommentTime and IsDelete=SQL2012IsDelete and UserName=SQL2012UserName ");
			SqlParameter[] parameters = {
					new SqlParameter("SQL2012CommentID", SqlDbType.UniqueIdentifier,16),
					new SqlParameter("SQL2012LogsID", SqlDbType.UniqueIdentifier,16),
					new SqlParameter("SQL2012CommentContent", SqlDbType.NVarChar,255),
					new SqlParameter("SQL2012Commentator", SqlDbType.UniqueIdentifier,16),
					new SqlParameter("SQL2012CommentTime", SqlDbType.DateTime),
					new SqlParameter("SQL2012IsDelete", SqlDbType.Bit,1),
					new SqlParameter("SQL2012UserName", SqlDbType.NVarChar,255)};
			parameters[0].Value = model.CommentID;
			parameters[1].Value = model.LogsID;
			parameters[2].Value = model.CommentContent;
			parameters[3].Value = model.Commentator;
			parameters[4].Value = model.CommentTime;
			parameters[5].Value = model.IsDelete;
			parameters[6].Value = model.UserName;

			int rows=DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
			if (rows > 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Delete(Guid CommentID,Guid LogsID,string CommentContent,Guid Commentator,DateTime CommentTime,bool IsDelete,string UserName)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from V_Com_User ");
			strSql.Append(" where CommentID=SQL2012CommentID and LogsID=SQL2012LogsID and CommentContent=SQL2012CommentContent and Commentator=SQL2012Commentator and CommentTime=SQL2012CommentTime and IsDelete=SQL2012IsDelete and UserName=SQL2012UserName ");
			SqlParameter[] parameters = {
					new SqlParameter("SQL2012CommentID", SqlDbType.UniqueIdentifier,16),
					new SqlParameter("SQL2012LogsID", SqlDbType.UniqueIdentifier,16),
					new SqlParameter("SQL2012CommentContent", SqlDbType.NVarChar,255),
					new SqlParameter("SQL2012Commentator", SqlDbType.UniqueIdentifier,16),
					new SqlParameter("SQL2012CommentTime", SqlDbType.DateTime),
					new SqlParameter("SQL2012IsDelete", SqlDbType.Bit,1),
					new SqlParameter("SQL2012UserName", SqlDbType.NVarChar,255)			};
			parameters[0].Value = CommentID;
			parameters[1].Value = LogsID;
			parameters[2].Value = CommentContent;
			parameters[3].Value = Commentator;
			parameters[4].Value = CommentTime;
			parameters[5].Value = IsDelete;
			parameters[6].Value = UserName;

			int rows=DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
			if (rows > 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}


		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public V_Com_User_Model GetModel(Guid CommentID,Guid LogsID,string CommentContent,Guid Commentator,DateTime CommentTime,bool IsDelete,string UserName)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 CommentID,LogsID,CommentContent,Commentator,CommentTime,IsDelete,UserName from V_Com_User ");
			strSql.Append(" where CommentID=SQL2012CommentID and LogsID=SQL2012LogsID and CommentContent=SQL2012CommentContent and Commentator=SQL2012Commentator and CommentTime=SQL2012CommentTime and IsDelete=SQL2012IsDelete and UserName=SQL2012UserName ");
			SqlParameter[] parameters = {
					new SqlParameter("SQL2012CommentID", SqlDbType.UniqueIdentifier,16),
					new SqlParameter("SQL2012LogsID", SqlDbType.UniqueIdentifier,16),
					new SqlParameter("SQL2012CommentContent", SqlDbType.NVarChar,255),
					new SqlParameter("SQL2012Commentator", SqlDbType.UniqueIdentifier,16),
					new SqlParameter("SQL2012CommentTime", SqlDbType.DateTime),
					new SqlParameter("SQL2012IsDelete", SqlDbType.Bit,1),
					new SqlParameter("SQL2012UserName", SqlDbType.NVarChar,255)			};
			parameters[0].Value = CommentID;
			parameters[1].Value = LogsID;
			parameters[2].Value = CommentContent;
			parameters[3].Value = Commentator;
			parameters[4].Value = CommentTime;
			parameters[5].Value = IsDelete;
			parameters[6].Value = UserName;

			V_Com_User_Model model=new V_Com_User_Model();
			DataSet ds=DbHelperSQL.Query(strSql.ToString(),parameters);
			if(ds.Tables[0].Rows.Count>0)
			{
				return DataRowToModel(ds.Tables[0].Rows[0]);
			}
			else
			{
				return null;
			}
		}


		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public V_Com_User_Model DataRowToModel(DataRow row)
		{
			V_Com_User_Model model=new V_Com_User_Model();
			if (row != null)
			{
				if(row["CommentID"]!=null && row["CommentID"].ToString()!="")
				{
					model.CommentID= new Guid(row["CommentID"].ToString());
				}
				if(row["LogsID"]!=null && row["LogsID"].ToString()!="")
				{
					model.LogsID= new Guid(row["LogsID"].ToString());
				}
				if(row["CommentContent"]!=null)
				{
					model.CommentContent=row["CommentContent"].ToString();
				}
				if(row["Commentator"]!=null && row["Commentator"].ToString()!="")
				{
					model.Commentator= new Guid(row["Commentator"].ToString());
				}
				if(row["CommentTime"]!=null && row["CommentTime"].ToString()!="")
				{
					model.CommentTime=DateTime.Parse(row["CommentTime"].ToString());
				}
				if(row["IsDelete"]!=null && row["IsDelete"].ToString()!="")
				{
					if((row["IsDelete"].ToString()=="1")||(row["IsDelete"].ToString().ToLower()=="true"))
					{
						model.IsDelete=true;
					}
					else
					{
						model.IsDelete=false;
					}
				}
				if(row["UserName"]!=null)
				{
					model.UserName=row["UserName"].ToString();
				}
			}
			return model;
		}

		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetList(string strWhere)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select CommentID,LogsID,CommentContent,Commentator,CommentTime,IsDelete,UserName ");
			strSql.Append(" FROM V_Com_User ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			return DbHelperSQL.Query(strSql.ToString());
		}

		/// <summary>
		/// 获得前几行数据
		/// </summary>
		public DataSet GetList(int Top,string strWhere,string filedOrder)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select ");
			if(Top>0)
			{
				strSql.Append(" top "+Top.ToString());
			}
			strSql.Append(" CommentID,LogsID,CommentContent,Commentator,CommentTime,IsDelete,UserName ");
			strSql.Append(" FROM V_Com_User ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			strSql.Append(" order by " + filedOrder);
			return DbHelperSQL.Query(strSql.ToString());
		}

		/// <summary>
		/// 获取记录总数
		/// </summary>
		public int GetRecordCount(string strWhere)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) FROM V_Com_User ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			object obj = DbHelperSQL.GetSingle(strSql.ToString());
			if (obj == null)
			{
				return 0;
			}
			else
			{
				return Convert.ToInt32(obj);
			}
		}
		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		public DataSet GetListByPage(string strWhere, string orderby, int startIndex, int endIndex)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("SELECT * FROM ( ");
			strSql.Append(" SELECT ROW_NUMBER() OVER (");
			if (!string.IsNullOrEmpty(orderby.Trim()))
			{
				strSql.Append("order by T." + orderby );
			}
			else
			{
				strSql.Append("order by T.UserName desc");
			}
			strSql.Append(")AS Row, T.*  from V_Com_User T ");
			if (!string.IsNullOrEmpty(strWhere.Trim()))
			{
				strSql.Append(" WHERE " + strWhere);
			}
			strSql.Append(" ) TT");
			strSql.AppendFormat(" WHERE TT.Row between {0} and {1}", startIndex, endIndex);
			return DbHelperSQL.Query(strSql.ToString());
		}

		/*
		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		public DataSet GetList(int PageSize,int PageIndex,string strWhere)
		{
			SqlParameter[] parameters = {
					new SqlParameter("SQL2012tblName", SqlDbType.VarChar, 255),
					new SqlParameter("SQL2012fldName", SqlDbType.VarChar, 255),
					new SqlParameter("SQL2012PageSize", SqlDbType.Int),
					new SqlParameter("SQL2012PageIndex", SqlDbType.Int),
					new SqlParameter("SQL2012IsReCount", SqlDbType.Bit),
					new SqlParameter("SQL2012OrderType", SqlDbType.Bit),
					new SqlParameter("SQL2012strWhere", SqlDbType.VarChar,1000),
					};
			parameters[0].Value = "V_Com_User";
			parameters[1].Value = "UserName";
			parameters[2].Value = PageSize;
			parameters[3].Value = PageIndex;
			parameters[4].Value = 0;
			parameters[5].Value = 0;
			parameters[6].Value = strWhere;	
			return DbHelperSQL.RunProcedure("UP_GetRecordByPage",parameters,"ds");
		}*/

		#endregion  BasicMethod
		#region  ExtensionMethod

		#endregion  ExtensionMethod
	}
}

