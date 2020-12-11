using System.ComponentModel;
using System.Reflection;

namespace LogsManager.Common
{
    public class EnumHelper
    {
        /**
         * 获取枚举描述信息
         */
        public static string GetEnumDes(System.Enum enumValue)
        {
            string value = enumValue.ToString();
            FieldInfo fieldInfo = enumValue.GetType().GetField(value);
            // 获取描述属性
            object[] objects = fieldInfo.GetCustomAttributes(typeof(DescriptionAttribute), false);
            if (objects==null||objects.Length==0)
            {
                return null;
            }
            DescriptionAttribute descriptionAttribute = (DescriptionAttribute) objects[0];
            return descriptionAttribute.Description;
        }
    }
}