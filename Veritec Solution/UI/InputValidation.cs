using System;
using System.Collections.Generic;
using System.Text;

namespace Veritec_Solution.UI
{
    public class InputValidation
    {
        static string InputError = "Please enter a valid value.";
        public static bool IsValidSalary(string salary)
        {
            if (Double.TryParse(salary, out _) && Double.Parse(salary) > 0)
            {
                return true;
            } else
            {
                Console.Clear();
                Console.WriteLine(InputError);
                return false;
            }
        }
        public static bool IsValidPayFreq(string freq)
        {
            if (Constants.PayIntervals.ContainsKey(freq))
            {
                return true;
            }
            else
            {
                Console.Clear();
                Console.WriteLine(InputError);
                return false;
            }
        }
    }
}
