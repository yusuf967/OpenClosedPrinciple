using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPenClosedPrinciple
{
    internal class StateFinder
    {
        public string GetStateNameForZipCode(int zipCode,AddressVerifier verifier)
        {
            if (!verifier.isValidZipCode(zipCode))
            {
                throw new InvalidOperationException($"Invalid ZipCode: {zipCode}");
            }

            switch (zipCode)
            {
                case 9:
                    return "İstanbul";
                case 10:
                    return "Elazığ";
                case 11:
                    return "California";
                case 12:
                    return "Utah";
                default:
                    throw new InvalidOperationException($"No state is found with {zipCode}");
            }
        }
    }
}
