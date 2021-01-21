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
            Console.Write("Dit køn (m/k): ");
            var gender = UserInput.GetChar(new List<char>() { 'm', 'k' });
            Console.Write("Din alder (år): ");
            var age = UserInput.GetDouble();
            Console.Write("Din vægt (kg): ");
            var weight = UserInput.GetDouble();
            Console.Write("Din hvilepuls (bpm): ");
            var minPulse = UserInput.GetDouble();
            Console.Write("Din maks. puls (bpm): ");
            var maxPulse = UserInput.GetDouble();

            // Calculate and print values representing user's physical health.
            var kondital = Kondital.GetKondital(minPulse, maxPulse);
            var oxygenMax = Kondital.GetOxygenMax(kondital, weight);
            var healthCondition = Kondital.GetPhysicalHealthCondition((int)Math.Round(kondital), gender != 'm', (int)age);

            Console.WriteLine("\nDINE VÆRDIER:");
            Console.WriteLine("Kondital: " + Math.Round(kondital) + " ml/kg/min");
            Console.WriteLine("Maksimal iltoptagelse: " + Math.Round(oxygenMax, 1) + " l/ml");
            Console.WriteLine("Kondition: " + Kondital.healthConditionString[healthCondition]);
        }
    }
}
