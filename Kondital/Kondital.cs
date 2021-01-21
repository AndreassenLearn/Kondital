using System;
using System.Collections.Generic;
using System.Text;

namespace Kondital
{
    class Kondital
    {
        /// <summary>
        /// Calculate "kondital" based on heart rate.
        /// </summary>
        /// <param name="minPulse">Resting heart rate.</param>
        /// <param name="maxPulse">Maximum heart rate.</param>
        /// <returns>"Kondital".</returns>
        static public double GetKondital(double minPulse, double maxPulse)
        {
            return (maxPulse / minPulse) * 15.3;
        }

        /// <summary>
        /// Calculate VO2 Max. based on "kondital" and weight.
        /// </summary>
        /// <param name="kondital">A number calculated from min. and max. heart rate.</param>
        /// <param name="weight">Weight in kilograms.</param>
        /// <returns>VO2 Max. value.</returns>
        static public double GetVO2Max(double kondital, double weight)
        {
            return (kondital * weight) * 0.001;
        }
    }
}
