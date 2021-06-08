using System;
using System.Collections.Generic;
using System.Text;

namespace Veritec_Solution
{
    public class LevyTiers
    {
        private double andOver = double.PositiveInfinity;
        private double previousUpperAndOne(Tier t)
        {
            return t.GetCutoffUpper() + 1;
        }
        public List<Tier> GetMedicareTiers()
        {
            Tier t1 = new Tier(
                cutoffLower: 0,
                cutoffUpper: 21335
                );

            Tier t2 = new Tier(
                cutoffLower: previousUpperAndOne(t1),
                cutoffUpper: 26668,
                taxableThreshold: t1.GetCutoffUpper(),
                levyPercent: 10
                );

            Tier t3 = new Tier(
                cutoffLower: previousUpperAndOne(t2),
                cutoffUpper: andOver,
                levyPercent: 2
                );

            return new List<Tier>() { t1, t2, t3 };
        }
        public List<Tier> GetBudgetRepairTiers()
        {
            Tier t1 = new Tier(
                cutoffLower: 0,
                cutoffUpper: 180000
                );

            Tier t2 = new Tier(
                cutoffLower: previousUpperAndOne(t1),
                cutoffUpper: andOver,
                taxableThreshold: t1.GetCutoffUpper(),
                levyPercent: 2
                );

            return new List<Tier>() { t1, t2 };
        }
        public List<Tier> GetTaxTiers()
        {
            Tier t1 = new Tier(
                cutoffLower: 0,
                cutoffUpper: 18200
                );

            Tier t2 = new Tier(
                cutoffLower: previousUpperAndOne(t1),
                cutoffUpper: 37000,
                taxableThreshold: t1.GetCutoffUpper(),
                levyPercent: 19
                );

            Tier t3 = new Tier(
                cutoffLower: previousUpperAndOne(t2),
                cutoffUpper: 87000,
                taxableThreshold: t2.GetCutoffUpper(),
                levyPercent: 32.5,
                baseTaxAmount: 3572
                );

            Tier t4 = new Tier(
                cutoffLower: previousUpperAndOne(t3),
                cutoffUpper: 180000,
                taxableThreshold: t3.GetCutoffUpper(),
                levyPercent: 37,
                baseTaxAmount: 19822
                );

            Tier t5 = new Tier(
                cutoffLower: previousUpperAndOne(t4),
                cutoffUpper: andOver,
                taxableThreshold: t4.GetCutoffUpper(),
                levyPercent: 47,
                baseTaxAmount: 54232
                );

            return new List<Tier>() { t1, t2, t3, t4, t5 };
        }
    }
}
