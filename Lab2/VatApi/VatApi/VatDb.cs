using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VatApi
{
    internal class VatDb
    {

        public int Id { get; set; }
        public bool isValid { get; set; }

        public DateTime? requestDate { get; set; }

        public string? userError { get; set; }

        public string? name { get; set; }

        public string? address { get; set; }

        public string? requestIdentifier { get; set; }

        public string? originalVatNumber { get; set; }

        public string vatNumber { get; set; }

        public ViesApproximateDb? viesApproximate { get; set; }


        public override string ToString()
        {
            return "Id " + Id + " " + $"IsValid: {isValid}, RequestDate: {requestDate}, UserError: {userError}, " +
            $"Name: {name}, Address: {address}, RequestIdentifier: {requestIdentifier}, " +
                   $"OriginalVatNumber: {originalVatNumber}, VatNumber: {vatNumber}, " +
            $"ViesApproximate: {viesApproximate}";
        }
    }
}
