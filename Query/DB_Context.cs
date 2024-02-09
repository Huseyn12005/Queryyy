using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Protocols;

namespace Query
{
    public class DB_Context:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var ConStr = new ConfigurationManager()
                .AddJsonFile("appsettings.json")
                .Build()
                .GetConnectionString("DefaultConnection");


            optionsBuilder.UseSqlServer(ConStr);
            base.OnConfiguring(optionsBuilder);
        }


        public virtual DbSet<Debtor> Debtors { get; set; }
    }
}
