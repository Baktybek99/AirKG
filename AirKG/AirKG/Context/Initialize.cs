using AirKG.Entity;
using Microsoft.AspNetCore.Identity;
using System.Threading.Tasks;

namespace AirKG.Context
{
    public static class Initialize
    {
        public static string roleAdmin = "Admin";

        public static async Task InitializeAsync(UserManager<User> userManager,
          RoleManager<IdentityRole> roleManager)
        {
            string adminEmail = "admin@gmail.com";
            string password = "123";
            if (await roleManager.FindByNameAsync(roleAdmin) == null)
            {
                await roleManager.CreateAsync(new IdentityRole(roleAdmin));
            }

            if (await userManager.FindByNameAsync(adminEmail) == null)
            {
                User admin = new User
                {
                    Email = adminEmail,
                    UserName = adminEmail,
                    FirstName = "admin",
                    LastName = "admin"
                };

                var result = await userManager.CreateAsync(admin, password);
                if (result.Succeeded)
                {
                    await userManager.AddToRoleAsync(admin, roleAdmin);
                }
            }
        }
    }
}
