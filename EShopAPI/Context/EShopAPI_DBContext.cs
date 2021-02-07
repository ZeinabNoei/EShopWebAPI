using Microsoft.EntityFrameworkCore;
using EShopAPI.Models;

namespace EShopAPI.Context
{
    public class EShopAPI_DBContext : DbContext
    {
        public EShopAPI_DBContext(DbContextOptions<EShopAPI_DBContext> options)
            : base(options)
        {
        }
        public virtual DbSet<Users> Users { get; set; }
        public virtual DbSet<OrderItems> OrderItems { get; set; }
        public virtual DbSet<Orders> Orders { get; set; }
        public virtual DbSet<Product> Product { get; set; }
        public virtual DbSet<SalesPerson> SalesPerson { get; set; }
        public virtual DbSet<Province> Province { get; set; }
        public virtual DbSet<City> City { get; set; }
        
    }
}
