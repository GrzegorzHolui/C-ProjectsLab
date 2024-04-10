using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiStudent
{
    internal class StudentDb
    {

        public int Id { get; set; }
        public required string Name { get; set; }
        public required float Average { get; set; }
        public string? Specialty { get; set; }
        public StudentDb() { }

        public override string ToString()
        {
            return $"Id: {Id},\tName: {Name,-15}\t,Average: {Average:0.00}, Specialty: {Specialty,-3}";
        }

    }
}
