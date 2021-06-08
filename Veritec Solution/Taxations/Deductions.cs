using System;
using System.Collections.Generic;
using System.Text;

namespace Veritec_Solution.Taxations
{
    class Deductions : IDeductions
    {
        Levy medicare, budgetRepair, tax;
        public Deductions()
        {
            // Get the levy tier information
            LevyTiers presetTiers = new LevyTiers();

            // Build each levy type
            this.medicare = new Levy(presetTiers.GetMedicareTiers());
            this.budgetRepair = new Levy(presetTiers.GetBudgetRepairTiers());
            this.tax = new Levy(presetTiers.GetTaxTiers());
        }

        public List<double> CalculateDeductions(double taxableIncome)
        {
            // Taxable income is rounded down to the nearest dollar when calculating reductions

            double TIRoundedDown = Math.Floor(taxableIncome);
            List<double> deductionList = new List<double>();
            deductionList.Add(medicare.CalculateTax(TIRoundedDown));
            deductionList.Add(budgetRepair.CalculateTax(TIRoundedDown));
            deductionList.Add(tax.CalculateTax(TIRoundedDown));
            return deductionList;
        }

        public double CalculateSuperAnnuation(double grossPackage)
        {
            double percentage = Constants.SuperAnnuationPercent / 100.00;
            double super = grossPackage * percentage;
            return super;
        }
    }
}
