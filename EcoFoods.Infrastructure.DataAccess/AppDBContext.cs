using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using EcoFoods.DomainEntities;


namespace EcoFoods.Infrastructure.DataAccess
{
    public class AppDBContext : IdentityDbContext<ApplicationUser>
    {

        public AppDBContext(DbContextOptions<AppDBContext> options) : base(options)
        { }


    }
    
}
