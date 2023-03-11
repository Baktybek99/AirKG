using AirKG.Extension;
using System.ComponentModel;

namespace AirKG.Enum
{
    public enum AirDegreeOfQuality
    {
        /// <summary>
        /// Хорошо,междуи 0 и 15
        /// </summary>
        [Description("Хорошо")]
        Good = 1,

        /// <summary>
        /// Умеренный,междуи 16 и 35
        /// </summary>
        [Description("Умеренный")]
        Moderate = 2,

        /// <summary>
        /// Нездоровый,междуи 36 и 75
        /// </summary>, 
        [Description("Нездоровый")]
        Unhealthy = 3,

        /// <summary>
        /// Очень вредно для здоровья, междуи 76 и 100
        /// </summary>
        [Description("Очень вредно для здоровья")]
        VeryUnhealthy = 4,

        /// <summary>
        /// Смертельно, больше 100
        /// </summary>
        [Description("Смертельно")]
        Died = 5
    }

    public static class AirDegreeOfQualityExtension
    {
        public static string GetName(this AirDegreeOfQuality x)
        {
            return x.Description();
        }
    }

}
