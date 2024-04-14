using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;



namespace VatApi
{
    internal class ApiVatFetcher
    {

        private HttpClient client;

        private string call = "https://ec.europa.eu/taxation_customs/vies/rest-api/ms/PL/vat/";

        public string resultOfFetch = "";

        public ApiVatFetcher()
        {
            this.client = new HttpClient();
        }

        public string getDataFromGivenNip(string numberVat)
        {
            makeResponse(numberVat).Wait();
            return resultOfFetch;
        }

        public void addVat()
        {

        }

        private async Task makeResponse(string numberVat)
        {
            string response = await client.GetStringAsync(call + numberVat);
            resultOfFetch = response;
        }

    }
}

