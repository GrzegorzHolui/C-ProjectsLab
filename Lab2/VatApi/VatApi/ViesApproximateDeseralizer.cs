using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace VatApi
{
    internal class ViesApproximateDeseralizer
    {

        public Vat deseralizeStudents(string students)
        {
            Vat result = JsonSerializer.Deserialize<Vat>(students);
            return result;
        }

    }
}
