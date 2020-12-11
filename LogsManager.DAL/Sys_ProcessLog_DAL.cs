using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using LogsManager.DBUtility;
using LogsManager.Model;

namespace LogsManager.DAL
{
	/// <summary>
	/// 数据访问类:Sys_ProcessLog_DAL
	/// </summary>
	public partial class Sys_ProcessLog_DAL
	{
		public Sys_ProcessLog_DAL()
		{}
		#region  BasicMethod

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(Guid ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from Sys_ProcessLog");
			strSql.Append(" where ID=@ID ");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.UniqueIdentifier,16)			};
			parameters[0].Value = ID;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(Sys_ProcessLog_Model model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into Sys_ProcessLog(");
			strSql.Append("ID,LogType,LogDescription,CreateUser,CreateTime,IsDelete,Remark)");
			strSql.Append(" values (");
			strSql.Append("@ID,@LogType,@LogDescription,@CreateUser,@CreateTime,@IsDelete,@Remark)");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.UniqueIdentifier,16),
					new SqlParameter("@LogType", SqlDbType.Int,4),
					new SqlParameter("@LogDescription", SqlDbType.NVarChar,50),
					new SqlParameter("@CreateUser", SqlDbType.UniqueIdentifier,16),
					new SqlParameter("@CreateTime", SqlDbType.DateTime),
					new SqlParameter("@IsDelete", SqlDbType.Bit,1),
					new SqlParameter("@Remark", SqlDbType.NVarChar,50)};
			parameters[0].Value = Guid.NewGuid();
			parameters[1].Value = model.LogType;
			parameters[2].Value = model.LogDescription;
			parameters[3].Value = model.CreateUser;
			parameters[4].Value = model.CreateTime;
			parameters[5].Value = model.IsDelete;
			parameters[6].Value = model.Remark;

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
		public bool Update(Sys_ProcessLog_Model model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update Sys_ProcessLog set ");
			strSql.Append("LogType=@LogType,");
			strSql.Append("LogDescription=@LogDescription,");
			strSql.Append("CreateUser=@CreateUser,");
			strSql.Append("CreateTime=@CreateTime,");
			strSql.Append("IsDelete=@IsDelete,");
			strSql.Append("Remark=@Remark");
			strSql.Append(" where ID=@ID ");
			SqlParameter[] parameters = {
					new SqlParameter("@LogType", SqlDbType.Int,4),
					new SqlParameter("@LogDescription", SqlDbType.NVarChar,50),
					new SqlParameter("@CreateUser", SqlDbType.UniqueIdentifier,16),
					new SqlParameter("@CreateTime", SqlDbType.DateTime),
					new SqlParameter("@IsDelete", SqlDbType.Bit,1),
					new SqlParameter("@Remark", SqlDbType.NVarChar,50),
					new SqlParameter("@ID", SqlDbType.UniqueIdentifier,16)};
			parameters[0].Value = model.LogType;
			parameters[1].Value = model.LogDescription;
			parameters[2].Value = model.CreateUser;
			parameters[3].Value = model.CreateTime;
			parameters[4].Value = model.IsDelete;
			parameters[5].Value = model.Remark;
			parameters[6].Value = model.ID;

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
		public bool Delete(Guid ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from Sys_ProcessLog ");
			strSql.Append(" where ID=@ID ");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.UniqueIdentifier,16)			};
			parameters[0].Value = ID;

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
		public bool DeleteList(string IDlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from Sys_ProcessLog ");
			strSql.Append(" where ID in ("+IDlist + ")  ");
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
		public Sys_ProcessLog_Model GetModel(Guid ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 ID,LogType,LogDescription,CreateUser,CreateTime,IsDelete,Remark from Sys_ProcessLog ");
			strSql.Append(" where ID=@ID ");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.UniqueIdentifier,16)			};
			parameters[0].Value = ID;

			Sys_ProcessLog_Model model=new Sys_ProcessLog_Model();
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
		public Sys_ProcessLog_Model DataRowToModel(DataRow row)
		{
			Sys_ProcessLog_Model model=new Sys_ProcessLog_Model();
			if (row != null)
			{
				if(row["ID"]!=null && row["ID"].ToString()!="")
				{
					model.ID= new Guid(row["ID"].ToString());
				}
				if(row["LogType"]!=null && row["LogType"].ToString()!="")
				{
					model.LogType=int.Parse(row["LogType"].ToString());
				}
				if(row["LogDescription"]!=null)
				{
					model.LogDescription=row["LogDescription"].ToString();
				}
				if(row["CreateUser"]!=null && row["CreateUser"].ToString()!="")
				{
					model.CreateUser= new Guid(row["CreateUser"].ToString());
				}
				if(row["CreateTime"]!=null && row["CreateTime"].ToString()!="")
				{
					model.CreateTime=DateTime.Parse(row["CreateTime"].ToString());
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
			strSql.Append("select ID,LogType,LogDescription,CreateUser,CreateTime,IsDelete,Remark ");
			strSql.Append(" FROM Sys_ProcessLog ");
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
			strSql.Append(" ID,LogType,LogDescription,CreateUser,CreateTime,IsDelete,Remark ");
			strSql.Append(" FROM Sys_ProcessLog ");
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
			strSql.Append("select count(1) FROM Sys_ProcessLog ");
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
				strSql.Append("order by T.ID desc");
			}
			strSql.Append(")AS Row, T.*  from Sys_ProcessLog T ");
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
					new SqlParameter("@tblName", SqlDbType.VarChar, 255),
					new SqlParameter("@fldName", SqlDbType.VarChar, 255),
					new SqlParameter("@PageSize", SqlDbType.Int),
					new SqlParameter("@PageIndex", SqlDbType.Int),
					new SqlParameter("@IsReCount", SqlDbType.Bit),
					new SqlParameter("@OrderType", SqlDbType.Bit),
					new SqlParameter("@strWhere", SqlDbType.VarChar,1000),
					};
			parameters[0].Value = "Sys_ProcessLog";
			parameters[1].Value = "ID";
			parameters[2].Value = PageSize;
			parameters[3].Value = PageIndex;
			parameters[4].Value = 0;
			parameters[5].Value = 0;
			parameters[6].Value = strWhere;	
			return DbHelperSQL.RunProcedure("UP_GetRecordByPage",parameters,"ds");
		}*/

		#endregion  BasicMethod
		#region  ExtensionMethod

		
		/// <summary>
		/// 增加一条数据,使用事务
		/// </summary>
		public bool Add(SqlConnection conn,SqlTransaction trans,Sys_ProcessLog_Model model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into Sys_ProcessLog(");
			strSql.Append("ID,LogType,LogDescription,CreateUser,CreateTime,IsDelete,Remark)");
			strSql.Append(" values (");
			strSql.Append("@ID,@LogType,@LogDescription,@CreateUser,@CreateTime,@IsDelete,@Remark)");
			SqlParameter[] parameters = {
				new SqlParameter("@ID", SqlDbType.UniqueIdentifier,16),
				new SqlParameter("@LogType", SqlDbType.Int,4),
				new SqlParameter("@LogDescription", SqlDbType.NVarChar,50),
				new SqlParameter("@CreateUser", SqlDbType.UniqueIdentifier,16),
				new SqlParameter("@CreateTime", SqlDbType.DateTime),
				new SqlParameter("@IsDelete", SqlDbType.Bit,1),
				new SqlParameter("@Remark", SqlDbType.NVarChar,50)};
			parameters[0].Value = Guid.NewGuid();
			parameters[1].Value = model.LogType;
			parameters[2].Value = model.LogDescription;
			parameters[3].Value = model.CreateUser;
			parameters[4].Value = model.CreateTime;
			parameters[5].Value = model.IsDelete;
			parameters[6].Value = model.Remark;

			int result=DbHelperSQL.ExecuteSql(conn, trans, strSql.ToString(), parameters);
			if (result>0)
			{
				return true;
			}
			else
			{
				return false;
	
			}
		}



		#endregion  ExtensionMethod
	}
}

