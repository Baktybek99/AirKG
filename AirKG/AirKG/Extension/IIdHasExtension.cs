using AirKG.Interface;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace AirKG.Extension
{
    public static class IIdHasExtension
    {
        /// <summary>
        /// Получение сущности по ID
        /// </summary>
        /// <typeparam name="T">Entity</typeparam>
        /// <param name="entities">Entity</param>
        /// <param name="id">Код ентити</param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public static async Task<T> ById<T>(this IQueryable<T> entities, int id) where T : class, IEntity<int>
        {
            return await entities.FirstOrDefaultAsync(x => x.Id.Equals(id))
                    ?? throw new Exception($"2550. Сущность '{typeof(T).Name}' с кодом = '{id}' не найдена.");
        }
    }
}
