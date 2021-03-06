using System;
using System.Collections.Generic;
using System.Text;

namespace DemooLibrary
{
    public class PersonModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public bool IsActive { get; set; }

        public List<AdressModel> Adresses { get; set; }
    }
}
