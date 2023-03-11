using AirKG.Enum;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace AirKG.Entity
{
    /// <summary>
    /// Данные об атмосфере?
    /// </summary>
    public class AirData : IdIntBase
    {
        /// <summary>
        /// Код датчика
        /// </summary>
        [ForeignKey(nameof(Sensor))]
        public int SensorId { get; set; }

        /// <summary>
        /// Дата создания данных
        /// </summary>
        public DateTime DateCreate { get; set; }

        /// <summary>
        /// Качество воздуха
        /// </summary>
        public double AirQuality { get; set; }

        /// <summary>
        /// Степень Качества воздуха
        /// </summary>
        public AirDegreeOfQuality DegreeOfQuality { get; set; }

        /// <summary>
        /// Температура
        /// </summary>
        public double Temperature { get; set; }

        public virtual Sensor Sensor { get; set; }
    }
}
