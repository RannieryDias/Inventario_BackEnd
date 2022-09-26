using Microsoft.EntityFrameworkCore;
using System;


namespace Inventario.Db
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
    }
}
