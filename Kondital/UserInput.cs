using System;
using System.Collections.Generic;
using System.Text;

namespace Kondital
{
    class UserInput
    {
        /// <summary>
        /// Get double value from user. Retry until a valid value has been entered.
        /// </summary>
        /// <returns>User input as double.</returns>
        static public double GetDouble()
        {
            double input;
            do
            {
                if (Double.TryParse(Console.ReadLine().Replace('.', ','), out input))
                    break;
                else
                    InvalidValue();
            } while (true);

            return input;
        }

        /// <summary>
        /// Get char value from user. Retry until a valid value has been entered.
        /// </summary>
        /// <param name="validChars">User input has to be one of these chars. If null; all chars is valid.</param>
        /// <returns>User input as char.</returns>
        static public char GetChar(List<char> validChars = null)
        {
            char input;
            do
            {
                if (Char.TryParse(Console.ReadLine(), out input) && validChars.Contains(input))
                    break;
                else
                    InvalidValue();
            } while (true);

            return input;
        }

        /// <summary>
        /// Print a message to the console.
        /// </summary>
        static private void InvalidValue()
        {
            Console.Write("Ugyldig værdi, prøv igen (se evt. README): ");
        }
    }
}
