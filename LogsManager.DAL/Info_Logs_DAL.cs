using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using LogsManager.DBUtility;
using LogsManager.Model;

namespace LogsManager.DAL
{
	/// <summary>
	/// 数据访问类:Info_Logs_DAL
	/// </summary>
	public partial class Info_Logs_DAL
	{
		public Info_Logs_DAL()
		{}
		#region  BasicMethod

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(Guid LogsID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from Info_Logs");
			strSql.Append(" where LogsID=SQL2012LogsID ");
			SqlParameter[] parameters = {
					new SqlParameter("SQL2012LogsID", SqlDbType.UniqueIdentifier,16)			};
			parameters[0].Value = LogsID;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(Info_Logs_Model model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into Info_Logs(");
			strSql.Append("LogsID,LogsTitle,LogsContent,CoverPictureUrl,CreateUser,CreateTime,UpdateUser,UpdateTime,isDelete,Remark)");
			strSql.Append(" values (");
			strSql.Append("SQL2012LogsID,SQL2012LogsTitle,SQL2012LogsContent,SQL2012CoverPictureUrl,SQL2012CreateUser,SQL2012CreateTime,SQL2012UpdateUser,SQL2012UpdateTime,SQL2012isDelete,SQL2012Remark)");
			SqlParameter[] parameters = {
					new SqlParameter("SQL2012LogsID", SqlDbType.UniqueIdentifier,16),
					new SqlParameter("SQL2012LogsTitle", SqlDbType.NVarChar,50),
					new SqlParameter("SQL2012LogsContent", SqlDbType.NVarChar,-1),
					new SqlParameter("SQL2012CoverPictureUrl", SqlDbType.NVarChar,255),
					new SqlParameter("SQL2012CreateUser", SqlDbType.UniqueIdentifier,16),
					new SqlParameter("SQL2012CreateTime", SqlDbType.DateTime),
					new SqlParameter("SQL2012UpdateUser", SqlDbType.UniqueIdentifier,16),
					new SqlParameter("SQL2012UpdateTime", SqlDbType.DateTime),
					new SqlParameter("SQL2012isDelete", SqlDbType.Bit,1),
					new SqlParameter("SQL2012Remark", SqlDbType.NVarChar,50)};
			parameters[0].Value = Guid.NewGuid();
			parameters[1].Value = model.LogsTitle;
			parameters[2].Value = model.LogsContent;
			parameters[3].Value = model.CoverPictureUrl;
			parameters[4].Value = Guid.NewGuid();
			parameters[5].Value = model.CreateTime;
			parameters[6].Value = Guid.NewGuid();
			parameters[7].Value = model.UpdateTime;
			parameters[8].Value = model.isDelete;
			parameters[9].Value = model.Remark;

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
		public bool Update(Info_Logs_Model model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update Info_Logs set ");
			strSql.Append("LogsTitle=SQL2012LogsTitle,");
			strSql.Append("LogsContent=SQL2012LogsContent,");
			strSql.Append("CoverPictureUrl=SQL2012CoverPictureUrl,");
			strSql.Append("CreateUser=SQL2012CreateUser,");
			strSql.Append("CreateTime=SQL2012CreateTime,");
			strSql.Append("UpdateUser=SQL2012UpdateUser,");
			strSql.Append("UpdateTime=SQL2012UpdateTime,");
			strSql.Append("isDelete=SQL2012isDelete,");
			strSql.Append("Remark=SQL2012Remark");
			strSql.Append(" where LogsID=SQL2012LogsID ");
			SqlParameter[] parameters = {
					new SqlParameter("SQL2012LogsTitle", SqlDbType.NVarChar,50),
					new SqlParameter("SQL2012LogsContent", SqlDbType.NVarChar,-1),
					new SqlParameter("SQL2012CoverPictureUrl", SqlDbType.NVarChar,255),
					new SqlParameter("SQL2012CreateUser", SqlDbType.UniqueIdentifier,16),
					new SqlParameter("SQL2012CreateTime", SqlDbType.DateTime),
					new SqlParameter("SQL2012UpdateUser", SqlDbType.UniqueIdentifier,16),
					new SqlParameter("SQL2012UpdateTime", SqlDbType.DateTime),
					new SqlParameter("SQL2012isDelete", SqlDbType.Bit,1),
					new SqlParameter("SQL2012Remark", SqlDbType.NVarChar,50),
					new SqlParameter("SQL2012LogsID", SqlDbType.UniqueIdentifier,16)};
			parameters[0].Value = model.LogsTitle;
			parameters[1].Value = model.LogsContent;
			parameters[2].Value = model.CoverPictureUrl;
			parameters[3].Value = model.CreateUser;
			parameters[4].Value = model.CreateTime;
			parameters[5].Value = model.UpdateUser;
			parameters[6].Value = model.UpdateTime;
			parameters[7].Value = model.isDelete;
			parameters[8].Value = model.Remark;
			parameters[9].Value = model.LogsID;

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
		public bool Delete(Guid LogsID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from Info_Logs ");
			strSql.Append(" where LogsID=SQL2012LogsID ");
			SqlParameter[] parameters = {
					new SqlParameter("SQL2012LogsID", SqlDbType.UniqueIdentifier,16)			};
			parameters[0].Value = LogsID;

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
		/// 批量删除数据
		/// </summary>
		public bool DeleteList(string LogsIDlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from Info_Logs ");
			strSql.Append(" where LogsID in ("+LogsIDlist + ")  ");
			int rows=DbHelperSQL.ExecuteSql(strSql.ToString());
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
		public Info_Logs_Model GetModel(Guid LogsID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 LogsID,LogsTitle,LogsContent,CoverPictureUrl,CreateUser,CreateTime,UpdateUser,UpdateTime,isDelete,Remark from Info_Logs ");
			strSql.Append(" where LogsID=SQL2012LogsID ");
			SqlParameter[] parameters = {
					new SqlParameter("SQL2012LogsID", SqlDbType.UniqueIdentifier,16)			};
			parameters[0].Value = LogsID;

			Info_Logs_Model model=new Info_Logs_Model();
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
		public Info_Logs_Model DataRowToModel(DataRow row)
		{
			Info_Logs_Model model=new Info_Logs_Model();
			if (row != null)
			{
				if(row["LogsID"]!=null && row["LogsID"].ToString()!="")
				{
					model.LogsID= new Guid(row["LogsID"].ToString());
				}
				if(row["LogsTitle"]!=null)
				{
					model.LogsTitle=row["LogsTitle"].ToString();
				}
				if(row["LogsContent"]!=null)
				{
					model.LogsContent=row["LogsContent"].ToString();
				}
				if(row["CoverPictureUrl"]!=null)
				{
					model.CoverPictureUrl=row["CoverPictureUrl"].ToString();
				}
				if(row["CreateUser"]!=null && row["CreateUser"].ToString()!="")
				{
					model.CreateUser= new Guid(row["CreateUser"].ToString());
				}
				if(row["CreateTime"]!=null && row["CreateTime"].ToString()!="")
				{
					model.CreateTime=DateTime.Parse(row["CreateTime"].ToString());
				}
				if(row["UpdateUser"]!=null && row["UpdateUser"].ToString()!="")
				{
					model.UpdateUser= new Guid(row["UpdateUser"].ToString());
				}
				if(row["UpdateTime"]!=null && row["UpdateTime"].ToString()!="")
				{
					model.UpdateTime=DateTime.Parse(row["UpdateTime"].ToString());
				}
				if(row["isDelete"]!=null && row["isDelete"].ToString()!="")
				{
					if((row["isDelete"].ToString()=="1")||(row["isDelete"].ToString().ToLower()=="true"))
					{
						model.isDelete=true;
					}
					else
					{
						model.isDelete=false;
					}
				}
				if(row["Remark"]!=null)
				{
					model.Remark=row["Remark"].ToString();
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
			strSql.Append("select LogsID,LogsTitle,LogsContent,CoverPictureUrl,CreateUser,CreateTime,UpdateUser,UpdateTime,isDelete,Remark ");
			strSql.Append(" FROM Info_Logs ");
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
			strSql.Append(" LogsID,LogsTitle,LogsContent,CoverPictureUrl,CreateUser,CreateTime,UpdateUser,UpdateTime,isDelete,Remark ");
			strSql.Append(" FROM Info_Logs ");
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
			strSql.Append("select count(1) FROM Info_Logs ");
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
				strSql.Append("order by T.LogsID desc");
			}
			strSql.Append(")AS Row, T.*  from Info_Logs T ");
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
			parameters[0].Value = "Info_Logs";
			parameters[1].Value = "LogsID";
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

