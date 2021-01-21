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
    }
}
