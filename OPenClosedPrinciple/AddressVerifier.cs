using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPenClosedPrinciple
{
    internal class AddressVerifier
    {
        public virtual bool IsAddressValid(Address address)
        {
            return true;
        }

        public virtual bool isValidZipCode(int zipCode)
        {
            if (zipCode < 10)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
