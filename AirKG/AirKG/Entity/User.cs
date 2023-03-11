using Microsoft.AspNetCore.Identity;

namespace AirKG.Entity
{
    public class User : IdentityUser
    {
        /// <summary>
        /// Имя 
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// Фамилие
        /// </summary>
        public string LastName { get; set; }
    }
}
