namespace OPenClosedPrinciple
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var stateFinder = new StateFinder();

            //for the United States

            try
            {
                var addressVerifier = new AddressVerifier();
                Console.WriteLine(stateFinder.GetStateNameForZipCode(11, addressVerifier));
                Console.WriteLine(stateFinder.GetStateNameForZipCode(9, addressVerifier));
            }
            catch (InvalidOperationException exception)
            {
                Console.WriteLine(exception.Message);
            }

            // For the Turkey
            try
            {
                var addressVerifier = new TurkeyAddressVerifier();
                Console.WriteLine(stateFinder.GetStateNameForZipCode(10, addressVerifier));
            }
            catch (InvalidOperationException exception)
            {
                Console.WriteLine(exception.Message);
            }
        }
    }
}