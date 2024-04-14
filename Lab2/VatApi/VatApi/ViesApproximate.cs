﻿using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace VatApi
{
    internal class ViesApproximate
    {
        public string name { get; set; }

        public string street { get; set; }

        public string postalCode { get; set; }

        public string city { get; set; }

        public string companyType { get; set; }

        public int matchName { get; set; }

        public int matchStreet { get; set; }

        public int matchPostalCode { get; set; }

        public int matchCity { get; set; }

        public int matchCompanyType { get; set; }

        public override string ToString()
        {
            return $"Name: {name}, Street: {street}, PostalCode: {postalCode}, City: {city}, " +
                   $"CompanyType: {companyType}, MatchName: {matchName}, MatchStreet: {matchStreet}, " +
                   $"MatchPostalCode: {matchPostalCode}, MatchCity: {matchCity}, MatchCompanyType: {matchCompanyType}";
        }
    }
}
