using System;
using System.Collections.Generic;
using System.Text;
using Veritec_Solution.Repositories;

namespace Veritec_Solution
{
    public class Tier: ITier
    {
        double CutoffLower, CutoffUpper, TaxableThreshold, BaseTaxAmount, LevyPercent;

        public Tier(double cutoffLower, double cutoffUpper, double taxableThreshold = 0, double levyPercent = 0, double baseTaxAmount = 0)
        {
            this.CutoffLower = cutoffLower;
            this.CutoffUpper = cutoffUpper;
            this.TaxableThreshold = taxableThreshold;
            this.BaseTaxAmount = baseTaxAmount;
            this.LevyPercent = levyPercent;
        }

        public double CalculateDeduction(double taxableIncome)
        {
            // Returns levy's (always rounded up to the nearest dollar)
            double percentage = this.LevyPercent / 100.00;
            return (int)Math.Ceiling(this.BaseTaxAmount + ((taxableIncome - this.TaxableThreshold) * percentage));
        }
        public double GetCutoffLower()
        {
            return this.CutoffLower;
        }
        public double GetCutoffUpper()
        {
            return this.CutoffUpper;
        }
        public double GetTaxableThreshold()
        {
            return this.TaxableThreshold;
        }
        public double GetLevyPercent()
        {
            return this.LevyPercent;
        }
        public double GetBaseTaxAmount()
        {
            return this.BaseTaxAmount;
        }
    }
}
