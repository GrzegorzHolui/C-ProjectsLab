using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
namespace ApiStudent
{
    internal class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public float Average { get; set; }
        public override string ToString()
        {
            return $"Id: {Id},\tName: {Name,-15}\t,Average: {Average:0.00}";
        }
    }
}
