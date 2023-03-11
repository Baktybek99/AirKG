using AirKG.Enum;
using System;

namespace AirKG.ViewModels
{
    public class SensorVM
    {
        /// <summary>
        ///  Id Сенсера
        /// </summary>
        public int Id { get ; set; }  

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
        /// Качество воздуха
        /// </summary>
        public double? AirQuality { get; set; }
    }
}
