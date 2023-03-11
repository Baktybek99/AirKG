using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace AirKG.Entity
{
    /// <summary>
    /// Датчики расположенные в городе
    /// </summary>
    public class Sensor : IdIntBase
    {
        /// <summary>
        /// Код районы
        /// Почему nullable? Потомучто мы еще не решили, нужны ли нам районы
        /// </summary>
        [ForeignKey(nameof(District))]
        public int? DistrictId { get; set; }

        /// <summary>
        /// Название местности/улицы на которой расположен датчик
        /// </summary>
        public string PlaceName { get; set; }

        /// <summary>
        /// Находится ли датчик в рабочем состоянии
        /// </summary>
        public bool IsWork { get; set; }

        /// <summary>
        /// Дата замены датчик
        /// </summary>
        public DateTime ReplacementDate { get; set; }

        /// <summary>
        /// Долгота
        /// </summary>
        public int Longitude { get; set; }

        /// <summary>
        /// Широта
        /// </summary>
        public int Latitude { get; set; }

        /// <summary>
        /// Координаты по высоте
        /// </summary>
        public decimal HeightCoordinates { get; set; }

        /// <summary>
        /// Координаты в бок
        /// </summary>
        public decimal СoordinatesInTheSide { get; set; }

        public virtual District District { get; set; }

        public virtual IEnumerable<AirData> AirDatas { get; set; }
    }
}
