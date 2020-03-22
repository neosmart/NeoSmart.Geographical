using System;
using System.Collections.Generic;
using System.Text;

namespace NeoSmart.Data.Geographical
{
    public class CountryAttribute : Attribute
    {
        public string FullName { get; set; }
        public string Name { get; set; }
        public string ISOAbbreviation { get; set; }
        public string UNAbbrevation { get; set; }
        public int UNCode { get; set; }
    }
}
