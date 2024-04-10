using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
[assembly: InternalsVisibleTo("Laby2API_Forms")]
[assembly: InternalsVisibleTo("GUI")]
namespace ApiStudent
{
    internal class University : DbContext
    {

        /*public required string Name { get; set; }
        public required float Average { get; set; }
        public string? Specialty { get; set; }*/

        public DbSet<StudentDb> students { get; set; }

        public University()
        {
            Database.EnsureCreated();
        }

        public void addStudent(string name, float average, string specialty)
        {
            StudentDb student = new StudentDb() { Name = name, Average = average, Specialty = specialty };
            students.Add(student);
            SaveChanges();
        }

        public List<StudentDb> searchStudentWhereAverageIsHigerThen(float average)
        {
            List<StudentDb> result = students.Where(s => s.Average > average).ToList<StudentDb>();
            return result;
        }

        public List<StudentDb> orderStudentsByAverage(float average)
        {
            List<StudentDb> result = students.OrderBy(s => s.Average).Reverse().ToList<StudentDb>();
            return result;
        }

        public void removeAllEntities()
        {
            var allEntities = students.ToList();
            students.RemoveRange(allEntities);
            SaveChanges();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlite(@"Data Source=Univ.db");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<StudentDb>().HasData(
            new StudentDb() { Id = 1, Name = "Agnieszka", Average = 5.5f },
            new StudentDb() { Id = 2, Name = "Bartosz", Average = 4.5f },
            new StudentDb() { Id = 3, Name = "Czarek", Average = 5.0f }
            );
        }
    }
}
