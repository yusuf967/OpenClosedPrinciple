using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPenClosedPrinciple
{
    internal class TurkeyAddressVerifier:AddressVerifier
    {
        public override bool isValidZipCode(int zipCode)
        {
            if (zipCode < 5)
            {
                return false;
            }   
                return true;
        }
    }
}
