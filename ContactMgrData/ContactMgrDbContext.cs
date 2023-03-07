using ContactMgrWebModels;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace ContactMgrData
{
    public class ContactMgrDbContext:DbContext

    {
        private static IConfigurationRoot _configuration;

        public DbSet<Contact> Contacts { get; set; }
        public DbSet<State> state { get; set; }


        public ContactMgrDbContext() { }


        public ContactMgrDbContext(DbContextOptions options):base(options)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) 
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);

            _configuration= builder.Build();

            var constr= _configuration.GetConnectionString("ContactMgr");
            optionsBuilder.UseSqlServer(constr);
        }
         
    }
}