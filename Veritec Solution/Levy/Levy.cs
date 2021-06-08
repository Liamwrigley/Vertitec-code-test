using System;
using System.Collections.Generic;
using System.Text;

namespace Veritec_Solution
{
    public class Levy : ILevy
    {
        List<Tier> tiers = new List<Tier>();
        public Levy(List<Tier> tiers)
        {
            this.tiers = tiers;
        }

        public double CalculateTax(double taxableIncome)
        {
            // Find the tier that the TI belongs in
            foreach (Tier tier in this.tiers)
            {
                if (taxableIncome <= tier.GetCutoffUpper() && taxableIncome >= tier.GetCutoffLower())
                {
                    return tier.CalculateDeduction(taxableIncome);
                }
            }
            // return 0 as no deduction otherwise.
            return 0;
        }

        public List<Tier> GetTiers()
        {
            return this.tiers;
        }
    }
}
