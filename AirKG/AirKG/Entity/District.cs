using System.Collections.Generic;

namespace AirKG.Entity
{
    /// <summary>
    /// Районы
    /// </summary>
    public class District : IdIntBase
    {
        /// <summary>
        /// Название района
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Кол-во сенсоров
        /// </summary>
        public int SensorQuantity { get; set; }

        public virtual IEnumerable<Sensor> Sensors { get; set; }
    }
}
