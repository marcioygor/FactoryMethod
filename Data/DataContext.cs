using Microsoft.EntityFrameworkCore;
using ApiWithFactoryMethod.Product;

namespace ApiWithFactoryMethod.Data
{
    public class DataContext : DbContext
    {

        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }

        public DbSet<ContaBancaria> ContasBancarias { get; set; }
    }
}