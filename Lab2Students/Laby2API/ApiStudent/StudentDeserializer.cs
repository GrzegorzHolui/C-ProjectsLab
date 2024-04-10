using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace ApiStudent
{
    internal class StudentDeserializer
    {
        public List<Student> deseralizeStudents(string students) {
            List<Student> result = new List<Student>();
            result = JsonSerializer.Deserialize<List<Student>>(students);
            return result;
        }

    }
}
