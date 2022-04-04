using System;
using System.Collections.Generic;
using System.Text;

namespace DemooLibrary
{
    public class AdressModel
    {
        public string StreetAdress { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string ZipCode { get; set; }

        public string FullAddress => $"{StreetAdress}, {ZipCode}  {City}, {State} ";
    }
}
