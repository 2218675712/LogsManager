using System.ComponentModel;

namespace LogsManager.Model.Enum
{
    public enum SystemLogType
    {
        [Description("用户添加")] UserAdd = 0,
        [Description("用户更新")] UserEdit = 1,
        [Description("用户删除")] UserDelete = 2,
        [Description("用户注册")] UserRegister = 3,
        [Description("日志添加")] LogsAdd = 4,
        [Description("日志更新")] LogsEdit = 5,
        [Description("日志删除")] LogsDelete = 6
    }
}