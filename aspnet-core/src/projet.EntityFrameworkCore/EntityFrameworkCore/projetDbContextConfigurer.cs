using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace projet.EntityFrameworkCore
{
    public static class projetDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<projetDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<projetDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
