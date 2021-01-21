using System;

namespace Kondital
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("### Beregn dit kondital ###\n");

            // Get user inputs.
            Console.Write("Din vægt (kg): ");
            var weight = GetUserInputDouble();
            Console.Write("Din hvilepuls (bpm): ");
            var minPulse = GetUserInputDouble();
            Console.Write("Din maks. puls (bpm): ");
            var maxPulse = GetUserInputDouble();

            // Calculate and print values representing user's physical health.
            var kondital = Kondital.GetKondital(minPulse, maxPulse);
            var vO2Max = Kondital.GetVO2Max(kondital, weight);

            Console.WriteLine("\nDINE VÆRDIER:");
            Console.WriteLine("Kondital: " + kondital);
            Console.WriteLine("VO2 Maks. (maksimal iltoptagelse): " + vO2Max);
        }

        /// <summary>
        /// Get double value from user. Retry until a valid value has been entered.
        /// </summary>
        /// <returns>User input as double.</returns>
        static double GetUserInputDouble()
        {
            double input;
            do
            {
                if (Double.TryParse(Console.ReadLine().Replace('.', ','), out input))
                    break;
                else
                    Console.Write("Ugyldig værdi, prøv igen (se evt. README): ");
            } while (true);

            return input;
        }
    }
}
