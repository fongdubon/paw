namespace Paw.Web.Data
{
    using Microsoft.EntityFrameworkCore;
    using Entities;

    public class DataContext: DbContext
    {
        //crear las propiedades para poder crear las tablas en la BD
        public DbSet<Product> Products { get; set; }

        public DataContext(DbContextOptions<DataContext> options):base(options)
        {

        }
    }
}
