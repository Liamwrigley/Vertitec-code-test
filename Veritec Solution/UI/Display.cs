using System;
using System.Collections.Generic;
using System.Text;
using static Veritec_Solution.Constants;

namespace Veritec_Solution.UI
{
    public class Display
    {

        static string SalaryPackageQuestion = "Enter your salary package amount: ";
        static string PayFrequenecyQuestion = "Enter your pay frequency (W for weekly, F for fortnightly, M for monthly): ";
        static string CalculatingSalaryDetails = "\nCalculating Salary Details...\n";
        static string Gross = "Gross package:";
        static string Super = "Superannuation:";
        static string TaxableIncome = "\nTaxable income:";
        static string Deductions = "\nDeductions:";
        static string Medicare = "Medicare Levy:";
        static string BudgetRepair = "Budger Repair Levy:";
        static string IncomeTax = "Income Tax:";
        static string NetIncome = "\nNet Income:";
        static string PayPacket = "Pay Packet:";


        public static double GetPackageDetails()
        {
            string input;

            while(true)
            {
                Console.Write(SalaryPackageQuestion);
                input = Console.ReadLine();

                if (InputValidation.IsValidSalary(input)) {
                    return double.Parse(input);
                }
            }
        }

        public static PayInterval GetPayInterval()
        {
            string input;

            while (true)
            {
                Console.Write(PayFrequenecyQuestion);
                input = Console.ReadLine().ToUpper();

                if (InputValidation.IsValidPayFreq(input))
                {
                    return PayIntervals[input];
                }
            }
        }

        public static void Output(string payInterval, double gross, double super, double taxableIncome, List<double> deductions, double netIncome, double payPacket)
        {
            Console.WriteLine(CalculatingSalaryDetails);
            Console.WriteLine($"{Gross} {gross,0:c0}");
            Console.WriteLine($"{Super} {super,2:c}");
            Console.WriteLine($"{TaxableIncome} {taxableIncome,2:c}");
            Console.WriteLine($"{Deductions}");
            Console.WriteLine($"{Medicare} {deductions[0],2:c}");
            Console.WriteLine($"{BudgetRepair} {deductions[1],2:c}");
            Console.WriteLine($"{IncomeTax} {deductions[2],2:c}");
            Console.WriteLine($"{NetIncome} {netIncome,2:c}");
            Console.WriteLine($"{PayPacket} {payPacket,2:c} {payInterval}");
        }
    }
}
