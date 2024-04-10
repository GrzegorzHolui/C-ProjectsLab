using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Laby2API
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

        private async void bDownload_ClickAsync(object sender, EventArgs e)
        {

        }
    }
}
