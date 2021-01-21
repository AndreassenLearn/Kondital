using System;
using System.Collections.Generic;

namespace Kondital
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("### Beregn dit kondital ###\n");

            // Get user inputs.
            Console.Write("Din vægt (kg): ");
            var weight = UserInput.GetDouble();
            Console.Write("Din hvilepuls (bpm): ");
            var minPulse = UserInput.GetDouble();
            Console.Write("Din maks. puls (bpm): ");
            var maxPulse = UserInput.GetDouble();

            // Calculate and print values representing user's physical health.
            var kondital = Kondital.GetKondital(minPulse, maxPulse);
            var vO2Max = Kondital.GetVO2Max(kondital, weight);

            Console.WriteLine("\nDINE VÆRDIER:");
            Console.WriteLine("Kondital: " + kondital);
            Console.WriteLine("VO2 Maks. (maksimal iltoptagelse): " + vO2Max);
        }
    }
}
