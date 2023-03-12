namespace AirKG.Interface
{
    /// <summary>
    /// Интерфейс для entity
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface IEntity<T>
    {
        T Id { get; set; }
    }
}
