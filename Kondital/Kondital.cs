﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Kondital
{
    class Kondital
    {
        Dictionary<Tuple<int, int>, List<Tuple<int, int>>> femaleHealthCondition = new Dictionary<Tuple<int, int>, List<Tuple<int, int>>>()
        {
            { new Tuple<int, int>(20, 29), new List<Tuple<int, int>>() { new Tuple<int, int>(Int32.MinValue, 28), new Tuple<int, int>(29, 34), new Tuple<int, int>(35, 43), new Tuple<int, int>(44, 48), new Tuple<int, int>(49, Int32.MaxValue) } },
            { new Tuple<int, int>(30, 39), new List<Tuple<int, int>>() { new Tuple<int, int>(Int32.MinValue, 27), new Tuple<int, int>(28, 33), new Tuple<int, int>(34, 41), new Tuple<int, int>(42, 47), new Tuple<int, int>(48, Int32.MaxValue) } },
            { new Tuple<int, int>(40, 49), new List<Tuple<int, int>>() { new Tuple<int, int>(Int32.MinValue, 25), new Tuple<int, int>(26, 31), new Tuple<int, int>(32, 40), new Tuple<int, int>(41, 45), new Tuple<int, int>(46, Int32.MaxValue) } },
            { new Tuple<int, int>(50, 65), new List<Tuple<int, int>>() { new Tuple<int, int>(Int32.MinValue, 21), new Tuple<int, int>(22, 28), new Tuple<int, int>(29, 36), new Tuple<int, int>(37, 41), new Tuple<int, int>(42, Int32.MaxValue) } }
        };
        
        Dictionary<Tuple<int, int>, List<Tuple<int, int>>> maleHealthCondition = new Dictionary<Tuple<int, int>, List<Tuple<int, int>>>()
        {
            { new Tuple<int, int>(20, 29), new List<Tuple<int, int>>() { new Tuple<int, int>(Int32.MinValue, 38), new Tuple<int, int>(39, 43), new Tuple<int, int>(44, 51), new Tuple<int, int>(52, 56), new Tuple<int, int>(57, Int32.MaxValue) } },
            { new Tuple<int, int>(30, 39), new List<Tuple<int, int>>() { new Tuple<int, int>(Int32.MinValue, 34), new Tuple<int, int>(35, 39), new Tuple<int, int>(40, 47), new Tuple<int, int>(48, 51), new Tuple<int, int>(52, Int32.MaxValue) } },
            { new Tuple<int, int>(40, 49), new List<Tuple<int, int>>() { new Tuple<int, int>(Int32.MinValue, 30), new Tuple<int, int>(31, 35), new Tuple<int, int>(36, 43), new Tuple<int, int>(44, 47), new Tuple<int, int>(48, Int32.MaxValue) } },
            { new Tuple<int, int>(50, 59), new List<Tuple<int, int>>() { new Tuple<int, int>(Int32.MinValue, 25), new Tuple<int, int>(26, 31), new Tuple<int, int>(32, 39), new Tuple<int, int>(40, 43), new Tuple<int, int>(44, Int32.MaxValue) } },
            { new Tuple<int, int>(60, 69), new List<Tuple<int, int>>() { new Tuple<int, int>(Int32.MinValue, 21), new Tuple<int, int>(22, 26), new Tuple<int, int>(27, 35), new Tuple<int, int>(36, 39), new Tuple<int, int>(40, Int32.MaxValue) } }
        };

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
