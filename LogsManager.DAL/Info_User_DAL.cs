using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using LogsManager.DBUtility;
using LogsManager.Model;

namespace LogsManager.DAL
{
    /// <summary>
    /// 数据访问类:Info_User_DAL
    /// </summary>
    public partial class Info_User_DAL
    {
        public Info_User_DAL()
        {
        }

        #region BasicMethod

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(Guid UserID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from Info_User");
            strSql.Append(" where UserID=@UserID ");
            SqlParameter[] parameters =
            {
                new SqlParameter("@UserID", SqlDbType.UniqueIdentifier, 16)
            };
            parameters[0].Value = UserID;

            return DbHelperSQL.Exists(strSql.ToString(), parameters);
        }


        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add(Info_User_Model model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into Info_User(");
            strSql.Append(
                "UserID,UserName,UserAvatar,UserSex,UserPhone,AccountNum,Pwd,CreateUser,CreateTime,UpdateUser,UpdateTime,IsDelete,Remark)");
            strSql.Append(" values (");
            strSql.Append(
                "@UserID,@UserName,@UserAvatar,@UserSex,@UserPhone,@AccountNum,@Pwd,@CreateUser,@CreateTime,@UpdateUser,@UpdateTime,@IsDelete,@Remark)");
            SqlParameter[] parameters =
            {
                new SqlParameter("@UserID", SqlDbType.UniqueIdentifier, 16),
                new SqlParameter("@UserName", SqlDbType.NVarChar, 255),
                new SqlParameter("@UserAvatar", SqlDbType.NVarChar, 255),
                new SqlParameter("@UserSex", SqlDbType.Int, 4),
                new SqlParameter("@UserPhone", SqlDbType.NVarChar, 50),
                new SqlParameter("@AccountNum", SqlDbType.NVarChar, 50),
                new SqlParameter("@Pwd", SqlDbType.NVarChar, 255),
                new SqlParameter("@CreateUser", SqlDbType.UniqueIdentifier, 16),
                new SqlParameter("@CreateTime", SqlDbType.DateTime),
                new SqlParameter("@UpdateUser", SqlDbType.UniqueIdentifier, 16),
                new SqlParameter("@UpdateTime", SqlDbType.DateTime),
                new SqlParameter("@IsDelete", SqlDbType.Bit, 1),
                new SqlParameter("@Remark", SqlDbType.NVarChar, 50)
            };
            parameters[0].Value = Guid.NewGuid();
            parameters[1].Value = model.UserName;
            parameters[2].Value = model.UserAvatar;
            parameters[3].Value = model.UserSex;
            parameters[4].Value = model.UserPhone;
            parameters[5].Value = model.AccountNum;
            parameters[6].Value = model.Pwd;
            // parameters[7].Value = Guid.NewGuid();
            parameters[7].Value = model.CreateUser;

            parameters[8].Value = model.CreateTime;
            // parameters[9].Value = Guid.NewGuid();
            parameters[9].Value = model.UpdateUser;

            parameters[10].Value = model.UpdateTime;
            parameters[11].Value = model.IsDelete;
            parameters[12].Value = model.Remark;

            int rows = DbHelperSQL.ExecuteSql(strSql.ToString(), parameters);
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
        public bool Update(Info_User_Model model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update Info_User set ");
            strSql.Append("UserName=@UserName,");
            strSql.Append("UserAvatar=@UserAvatar,");
            strSql.Append("UserSex=@UserSex,");
            strSql.Append("UserPhone=@UserPhone,");
            strSql.Append("AccountNum=@AccountNum,");
            strSql.Append("Pwd=@Pwd,");
            strSql.Append("CreateUser=@CreateUser,");
            strSql.Append("CreateTime=@CreateTime,");
            strSql.Append("UpdateUser=@UpdateUser,");
            strSql.Append("UpdateTime=@UpdateTime,");
            strSql.Append("IsDelete=@IsDelete,");
            strSql.Append("Remark=@Remark");
            strSql.Append(" where UserID=@UserID ");
            SqlParameter[] parameters =
            {
                new SqlParameter("@UserName", SqlDbType.NVarChar, 255),
                new SqlParameter("@UserAvatar", SqlDbType.NVarChar, 255),
                new SqlParameter("@UserSex", SqlDbType.Int, 4),
                new SqlParameter("@UserPhone", SqlDbType.NVarChar, 50),
                new SqlParameter("@AccountNum", SqlDbType.NVarChar, 50),
                new SqlParameter("@Pwd", SqlDbType.NVarChar, 255),
                new SqlParameter("@CreateUser", SqlDbType.UniqueIdentifier, 16),
                new SqlParameter("@CreateTime", SqlDbType.DateTime),
                new SqlParameter("@UpdateUser", SqlDbType.UniqueIdentifier, 16),
                new SqlParameter("@UpdateTime", SqlDbType.DateTime),
                new SqlParameter("@IsDelete", SqlDbType.Bit, 1),
                new SqlParameter("@Remark", SqlDbType.NVarChar, 50),
                new SqlParameter("@UserID", SqlDbType.UniqueIdentifier, 16)
            };
            parameters[0].Value = model.UserName;
            parameters[1].Value = model.UserAvatar;
            parameters[2].Value = model.UserSex;
            parameters[3].Value = model.UserPhone;
            parameters[4].Value = model.AccountNum;
            parameters[5].Value = model.Pwd;
            parameters[6].Value = model.CreateUser;
            parameters[7].Value = model.CreateTime;
            parameters[8].Value = model.UpdateUser;
            parameters[9].Value = model.UpdateTime;
            parameters[10].Value = model.IsDelete;
            parameters[11].Value = model.Remark;
            parameters[12].Value = model.UserID;

            int rows = DbHelperSQL.ExecuteSql(strSql.ToString(), parameters);
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
        public bool Delete(Guid UserID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from Info_User ");
            strSql.Append(" where UserID=@UserID ");
            SqlParameter[] parameters =
            {
                new SqlParameter("@UserID", SqlDbType.UniqueIdentifier, 16)
            };
            parameters[0].Value = UserID;

            int rows = DbHelperSQL.ExecuteSql(strSql.ToString(), parameters);
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
        public bool DeleteList(string UserIDlist)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from Info_User ");
            strSql.Append(" where UserID in (" + UserIDlist + ")  ");
            int rows = DbHelperSQL.ExecuteSql(strSql.ToString());
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
        public Info_User_Model GetModel(Guid UserID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append(
                "select  top 1 UserID,UserName,UserAvatar,UserSex,UserPhone,AccountNum,Pwd,CreateUser,CreateTime,UpdateUser,UpdateTime,IsDelete,Remark from Info_User ");
            strSql.Append(" where UserID=@UserID ");
            SqlParameter[] parameters =
            {
                new SqlParameter("@UserID", SqlDbType.UniqueIdentifier, 16)
            };
            parameters[0].Value = UserID;

            Info_User_Model model = new Info_User_Model();
            DataSet ds = DbHelperSQL.Query(strSql.ToString(), parameters);
            if (ds.Tables[0].Rows.Count > 0)
            {
                return DataRowToModel(ds.Tables[0].Rows[0]);
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// 得到登录对象实体	方法重载
        /// </summary>
        /// <param name="AccountNum">用户名</param>
        /// <param name="Pwd">密码</param>
        /// <returns></returns>
        public Info_User_Model GetModel(string AccountNum, string Pwd)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append(
                "select  top 1 UserID,UserName,UserAvatar,UserSex,UserPhone,AccountNum,Pwd,CreateUser,CreateTime,UpdateUser,UpdateTime,IsDelete,Remark from Info_User ");
            strSql.Append(" where AccountNum=@AccountNum and Pwd=@Pwd ");
            SqlParameter[] parameters =
            {
                new SqlParameter("@AccountNum", SqlDbType.NVarChar, 50),
                new SqlParameter("@Pwd", SqlDbType.NVarChar, 255)
            };
            parameters[0].Value = AccountNum;
            parameters[1].Value = Pwd;

            Info_User_Model model = new Info_User_Model();
            DataSet ds = DbHelperSQL.Query(strSql.ToString(), parameters);
            if (ds.Tables[0].Rows.Count > 0)
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
        public Info_User_Model DataRowToModel(DataRow row)
        {
            Info_User_Model model = new Info_User_Model();
            if (row != null)
            {
                if (row["UserID"] != null && row["UserID"].ToString() != "")
                {
                    model.UserID = new Guid(row["UserID"].ToString());
                }

                if (row["UserName"] != null)
                {
                    model.UserName = row["UserName"].ToString();
                }

                if (row["UserAvatar"] != null)
                {
                    model.UserAvatar = row["UserAvatar"].ToString();
                }

                if (row["UserSex"] != null && row["UserSex"].ToString() != "")
                {
                    model.UserSex = int.Parse(row["UserSex"].ToString());
                }

                if (row["UserPhone"] != null)
                {
                    model.UserPhone = row["UserPhone"].ToString();
                }

                if (row["AccountNum"] != null)
                {
                    model.AccountNum = row["AccountNum"].ToString();
                }

                if (row["Pwd"] != null)
                {
                    model.Pwd = row["Pwd"].ToString();
                }

                if (row["CreateUser"] != null && row["CreateUser"].ToString() != "")
                {
                    model.CreateUser = new Guid(row["CreateUser"].ToString());
                }

                if (row["CreateTime"] != null && row["CreateTime"].ToString() != "")
                {
                    model.CreateTime = DateTime.Parse(row["CreateTime"].ToString());
                }

                if (row["UpdateUser"] != null && row["UpdateUser"].ToString() != "")
                {
                    model.UpdateUser = new Guid(row["UpdateUser"].ToString());
                }

                if (row["UpdateTime"] != null && row["UpdateTime"].ToString() != "")
                {
                    model.UpdateTime = DateTime.Parse(row["UpdateTime"].ToString());
                }

                if (row["IsDelete"] != null && row["IsDelete"].ToString() != "")
                {
                    if ((row["IsDelete"].ToString() == "1") || (row["IsDelete"].ToString().ToLower() == "true"))
                    {
                        model.IsDelete = true;
                    }
                    else
                    {
                        model.IsDelete = false;
                    }
                }

                if (row["Remark"] != null)
                {
                    model.Remark = row["Remark"].ToString();
                }
            }

            return model;
        }

        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetList(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append(
                "select UserID,UserName,UserAvatar,UserSex,UserPhone,AccountNum,Pwd,CreateUser,CreateTime,UpdateUser,UpdateTime,IsDelete,Remark ");
            strSql.Append(" FROM Info_User ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }

            return DbHelperSQL.Query(strSql.ToString());
        }

        /// <summary>
        /// 获得前几行数据
        /// </summary>
        public DataSet GetList(int Top, string strWhere, string filedOrder)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select ");
            if (Top > 0)
            {
                strSql.Append(" top " + Top.ToString());
            }

            strSql.Append(
                " UserID,UserName,UserAvatar,UserSex,UserPhone,AccountNum,Pwd,CreateUser,CreateTime,UpdateUser,UpdateTime,IsDelete,Remark ");
            strSql.Append(" FROM Info_User ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }

            strSql.Append(" order by " + filedOrder);
            return DbHelperSQL.Query(strSql.ToString());
        }

        /// <summary>
        /// 获取记录总数
        /// </summary>
        public int GetRecordCount(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) FROM Info_User ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
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
            StringBuilder strSql = new StringBuilder();
            strSql.Append("SELECT * FROM ( ");
            strSql.Append(" SELECT ROW_NUMBER() OVER (");
            if (!string.IsNullOrEmpty(orderby.Trim()))
            {
                strSql.Append("order by T." + orderby);
            }
            else
            {
                strSql.Append("order by T.UserID desc");
            }

            strSql.Append(")AS Row, T.*  from Info_User T ");
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
            parameters[0].Value = "Info_User";
            parameters[1].Value = "UserID";
            parameters[2].Value = PageSize;
            parameters[3].Value = PageIndex;
            parameters[4].Value = 0;
            parameters[5].Value = 0;
            parameters[6].Value = strWhere;	
            return DbHelperSQL.RunProcedure("UP_GetRecordByPage",parameters,"ds");
        }*/

        #endregion BasicMethod

        #region ExtensionMethod

        /// <summary>
        /// 添加一个用户并且加入日志
        /// </summary>
        public bool Add(Info_User_Model model, Sys_ProcessLog_Model sysProcessLogModel)
        {
            bool result = false;
            // 使用数据库链接
            using (SqlConnection conn = new SqlConnection(DbHelperSQL.connectionString))
            {
                conn.Open();
                //使用事务 开始事务
                using (SqlTransaction trans = conn.BeginTransaction())
                {
                    try
                    {
                        StringBuilder strSql = new StringBuilder();
                        strSql.Append("insert into Info_User(");
                        strSql.Append(
                            "UserID,UserName,UserAvatar,UserSex,UserPhone,AccountNum,Pwd,CreateUser,CreateTime,UpdateUser,UpdateTime,IsDelete,Remark)");
                        strSql.Append(" values (");
                        strSql.Append(
                            "@UserID,@UserName,@UserAvatar,@UserSex,@UserPhone,@AccountNum,@Pwd,@CreateUser,@CreateTime,@UpdateUser,@UpdateTime,@IsDelete,@Remark)");
                        SqlParameter[] parameters =
                        {
                            new SqlParameter("@UserID", SqlDbType.UniqueIdentifier, 16),
                            new SqlParameter("@UserName", SqlDbType.NVarChar, 255),
                            new SqlParameter("@UserAvatar", SqlDbType.NVarChar, 255),
                            new SqlParameter("@UserSex", SqlDbType.Int, 4),
                            new SqlParameter("@UserPhone", SqlDbType.NVarChar, 50),
                            new SqlParameter("@AccountNum", SqlDbType.NVarChar, 50),
                            new SqlParameter("@Pwd", SqlDbType.NVarChar, 255),
                            new SqlParameter("@CreateUser", SqlDbType.UniqueIdentifier, 16),
                            new SqlParameter("@CreateTime", SqlDbType.DateTime),
                            new SqlParameter("@UpdateUser", SqlDbType.UniqueIdentifier, 16),
                            new SqlParameter("@UpdateTime", SqlDbType.DateTime),
                            new SqlParameter("@IsDelete", SqlDbType.Bit, 1),
                            new SqlParameter("@Remark", SqlDbType.NVarChar, 50)
                        };
                        parameters[0].Value = Guid.NewGuid();
                        parameters[1].Value = model.UserName;
                        parameters[2].Value = model.UserAvatar;
                        parameters[3].Value = model.UserSex;
                        parameters[4].Value = model.UserPhone;
                        parameters[5].Value = model.AccountNum;
                        parameters[6].Value = model.Pwd;
                        // parameters[7].Value = Guid.NewGuid();
                        parameters[7].Value = model.CreateUser;

                        parameters[8].Value = model.CreateTime;
                        // parameters[9].Value = Guid.NewGuid();
                        parameters[9].Value = model.UpdateUser;

                        parameters[10].Value = model.UpdateTime;
                        parameters[11].Value = model.IsDelete;
                        parameters[12].Value = model.Remark;


                        object obj = DbHelperSQL.GetSingle(conn, trans, strSql.ToString(), parameters);
                        if (obj != null)
                        {
                            model.UserID = new Guid(Convert.ToString(obj));
                            // 判断想不想要加入日志,如果不想加入日志,可以传null
                            bool processLogResult = true;
                            if (sysProcessLogModel != null)
                            {
                                //添加时要告诉另一个语句用的是,哪一个连接，哪一个事务
                             processLogResult= new Sys_ProcessLog_DAL().Add(conn, trans, sysProcessLogModel);
                            }
                            if (processLogResult)
                            {
                                trans.Commit();
                                result = true;
                            }
                            else
                            {
                                trans.Rollback();
                                result = false;
                            }
                        }
                    }
                    catch (Exception e)
                    {
                        trans.Rollback();
                        result = false;
                    }
                }
            }

            return result;
        }

        #endregion ExtensionMethod
    }
}