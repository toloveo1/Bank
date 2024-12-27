using Microsoft.EntityFrameworkCore;
namespace Bank.Models{

public class BankDbContext : DbContext
{
    public BankDbContext(DbContextOptions<BankDbContext> options) : base(options)
    {
    }

    public DbSet<Cliente> Clientes { get; set; }
    public DbSet<Cuenta> Cuentas { get; set; }
    public DbSet<Transaccion> Transacciones { get; set; }
}
}