using Microsoft.EntityFrameworkCore;
using Sistema_Web.Models;

namespace Sistema_Web.Data
{
    public class DbClienteContext : DbContext
    {
        public DbClienteContext(DbContextOptions<DbClienteContext> options) : base(options)
        {
        }

        public DbSet<Cliente> Clientes { get; set; }
    }
}
