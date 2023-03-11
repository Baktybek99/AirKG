using AirKG.Interface;

namespace AirKG.Entity
{
    /// <summary>
    /// Базовый класс для Id
    /// </summary>
    public class IdIntBase : IEntity<int>
    {
        public int Id { get; set; }
    }
}
