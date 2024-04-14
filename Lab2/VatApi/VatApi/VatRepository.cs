using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

[assembly: InternalsVisibleTo("VatApi")]
[assembly: InternalsVisibleTo("VatForms")]
namespace VatApi
{
    internal class VatRepository : DbContext
    {

        public DbSet<VatDb> vats { get; set; }
        public VatRepository()
        {
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlite(@" Data Source = Univ.db");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<VatDb>().HasData(
             new VatDb() { Id = 1, isValid = true, vatNumber = "123456789" },
             new VatDb() { Id = 2, isValid = false, vatNumber = "123" },
             new VatDb() { Id = 3, isValid = true, vatNumber = "4455" }
            );
        }

        public List<VatDb> searchVatsWhereConditionIsFulfilled(bool validation)
        {
            List<VatDb> result = vats.Where(s => s.isValid == validation).ToList<VatDb>();
            return result;
        }
            
        public List<VatDb> orderByName(string givenName)
        {
            List<VatDb> result = vats.OrderBy(s => s.name).Reverse().ToList<VatDb>();
            return result;
        }

        public void removeAllVats()
        {
            vats.RemoveRange(vats);
            SaveChanges();
        }

        public void add(bool isValid, string number)
        {
            VatDb vatDb = new VatDb() { isValid = isValid, vatNumber = number };
            vats.Add(vatDb);
            SaveChanges();
        }
    }

}
