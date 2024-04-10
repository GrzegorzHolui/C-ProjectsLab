using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
namespace ApiStudent
{
    internal class ApiStudentFetcher
    {
        private HttpClient client;

        private string call = "http://radoslaw.idzikowski.staff.iiar.pwr.wroc.pl/instruction/students.json";

        public string resultOfFetch = "";

        public ApiStudentFetcher() {
            this.client = new HttpClient();
        }

        public string getData() {
            makeResponse().Wait();
            return resultOfFetch;
        }

        private async Task makeResponse()
        {
            string response = await client.GetStringAsync(call);
            resultOfFetch = response;
        }

    }

}