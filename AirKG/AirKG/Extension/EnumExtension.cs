using System.ComponentModel;

namespace AirKG.Extension
{
    public static class EnumExtension
    {
        public static string Description<T>(this T enumerationValue) where T : System.Enum
        {
            var defaultDescription = enumerationValue.ToString();
            var memberInfo = enumerationValue.GetType().GetMember(defaultDescription);
            if (memberInfo.Length > 0)
            {
                var attrs = memberInfo[0].GetCustomAttributes(typeof(DescriptionAttribute), false);

                if (attrs.Length > 0)
                    return ((DescriptionAttribute)attrs[0]).Description;
            }

            return defaultDescription;
        }
    }
}
