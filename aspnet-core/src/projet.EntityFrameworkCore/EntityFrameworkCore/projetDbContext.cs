using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using projet.Authorization.Roles;
using projet.Authorization.Users;
using projet.MultiTenancy;

namespace projet.EntityFrameworkCore
{
    public class projetDbContext : AbpZeroDbContext<Tenant, Role, User, projetDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public projetDbContext(DbContextOptions<projetDbContext> options)
            : base(options)
        {
        }
    }
}
