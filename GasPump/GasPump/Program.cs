using System;

namespace GasPump
{
    public class Program
    {
        public enum GasType
        {
            None,
            RegularGas,
            MidgradeGas,
            PremiumGas,
            DieselFuel
        }

        static void Main(string[] args)
        {
        program:
            // your implementation here
            Console.WriteLine("Please Enter Purchased Gas Type, Q/q to quit:");
            String a = Console.ReadLine();
            if (UserEnteredSentinelValue(a) == true)
            {
                Environment.Exit(0);
            }
            else if (UserEnteredValidGasType(a))
            {
                Console.WriteLine("Please Enter Purchased Gas Amount, Q/q to quit:");

            }
            String b = Console.ReadLine();
            if (UserEnteredSentinelValue(b))
            {
                Console.WriteLine("Application Terminated");
            }
            else if (UserEnteredValidAmount(b))
            {
                GasType gType = GasTypeMapper(a.ToCharArray()[0]);
                Console.WriteLine("You bought " + b +  "gallons of " + gType + " at " + GasPriceMapper(gType));

            }
            Console.ReadLine();
            goto program;
        }

        // use this method to check and see if sentinel value is entered
        public static bool UserEnteredSentinelValue(string userInput)
        {
            var result = false;
            if (userInput != null)
            {
                if (userInput.Equals("q") || userInput.Equals("Q"))
                {
                    result = true;
                }
            }

            // your implementation here

            return result;
        }

        // use this method to parse and check the characters entered
        // this does not conform 
        public static bool UserEnteredValidGasType(string userInput)
        {
            var result = false;
            if (char.ToString('R').Equals(userInput, StringComparison.InvariantCultureIgnoreCase))
            {
                result = true;
            }
            else if (char.ToString('M').Equals(userInput, StringComparison.InvariantCultureIgnoreCase))
            {
                result = true;
            }
            else if ((char.ToString('P').Equals(userInput, StringComparison.InvariantCultureIgnoreCase)))
            {
                result = true;
            }
            else if ((char.ToString('D').Equals(userInput, StringComparison.InvariantCultureIgnoreCase)))
            {
                result = true;
            }
            else
            {
                result = false;
            }
            // your implementation here

            return result;
        }

        // use this method to parse and check the double type entered
        // please use Double.TryParse() method 
        public static bool UserEnteredValidAmount(string userInput)
        {
            var result = false;
            double r;
            if (Double.TryParse(userInput, out r))
            {
                result = true;
            }
            // your implementation here

            return result;
        }

        // use this method to map a valid char entry to its enum representation
        // e.g. User enters 'R' or 'r' --> this should be mapped to GasType.RegularGas
        // this mapping "must" be used within CalculateTotalCost() method later on
        public static GasType GasTypeMapper(char c)
        {
            GasType gasType = GasType.None;

            if (char.ToUpperInvariant(c) == char.ToUpperInvariant('R'))

            {
                gasType = GasType.RegularGas;

            }
            else if (char.ToUpperInvariant(c) == char.ToUpperInvariant('M'))
            {
                gasType = GasType.MidgradeGas;

            }
            else if (char.ToUpperInvariant(c) == char.ToUpperInvariant('P'))
            {
                gasType = GasType.PremiumGas;
            }
            else if (char.ToUpperInvariant(c) == char.ToUpperInvariant('D'))
            {
                gasType = GasType.DieselFuel;
            }
            else
            {
                gasType = GasType.None;
            }


            // your implementation here

            return gasType;
        }

        public static double GasPriceMapper(GasType gasType)
        {
            var result = 0.0;
            if (gasType.Equals(GasType.RegularGas))
            {

                result = 1.94;

            }
            else if (gasType.Equals(GasType.MidgradeGas))
            {
                result = 2.00;
            }
            else if (gasType.Equals(GasType.PremiumGas))
            {
                result = 2.24;
            }
            else if (gasType.Equals(GasType.DieselFuel))
            {
                result = 2.17;
            }
            else
            {
                result = 0.0;
            }

            // your implementation here

            return result;
        }

        public static void CalculateTotalCost(GasType gasType, int gasAmount, ref double totalCost)
        {
            // your implementation here
            if (gasType.Equals(GasType.RegularGas))
            {
                totalCost = gasAmount * 1.94;
            }
            else if (gasType.Equals(GasType.MidgradeGas))
            {
                totalCost = gasAmount * 2.00;
            }
            else if (gasType.Equals(GasType.PremiumGas))
            {

                totalCost = gasAmount * 2.24;
            }
            else if (gasType.Equals(GasType.DieselFuel))
            {
                totalCost = gasAmount * 2.17;

            }

        }
    }
}
