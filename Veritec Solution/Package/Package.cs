using System;
using System.Collections.Generic;
using System.Text;
using Veritec_Solution.Taxations;
using Veritec_Solution.UI;

namespace Veritec_Solution
{
    public class Package : IPackage
    {
        private Constants.PayInterval PayInterval;
        private double GrossPackage, SuperannuationContribution, TaxableIncome, NetIncome, PayPacket;
        private List<double> LevyDeductions;
        private Deductions deductions;
        public void SalaryDetails()
        {
            this.GrossPackage = Display.GetPackageDetails();
            this.PayInterval = Display.GetPayInterval();
            this.SuperannuationContribution = 0;
            this.TaxableIncome = 0;
            this.NetIncome = 0;
            this.PayPacket = 0;

            // Create Deductions object & calculations
            this.deductions = new Deductions();
            this.CalculateDeductions();

            // Print package details
            this.PrintPackage();
        }

        private void CalculateSuper()
        {
            double super = this.deductions.CalculateSuperAnnuation(this.GrossPackage);
            this.TaxableIncome = this.GrossPackage - super;
            this.SuperannuationContribution = super;
        }
        private void CalculateLevyDeductions()
        {
            this.LevyDeductions = this.deductions.CalculateDeductions(this.TaxableIncome);
            this.NetIncome = this.TaxableIncome;
            foreach (double d in LevyDeductions)
            {
                this.NetIncome = this.NetIncome - d;
            }
        }

        private void CalculatePayPacket()
        {
            this.PayPacket = this.NetIncome / (double)PayInterval;
        }

        private void CalculateDeductions()
        {
            // Start with Super
            this.CalculateSuper();

            // Levy deductions
            this.CalculateLevyDeductions();

            // Pay packets
            this.CalculatePayPacket();
        }

        private void PrintPackage()
        {
            Display.Output(
                payInterval: Constants.PayIntervalOutput[this.PayInterval],
                gross: this.GrossPackage,
                super: this.SuperannuationContribution,
                taxableIncome: this.TaxableIncome,
                deductions: this.LevyDeductions,
                netIncome: this.NetIncome,
                payPacket: this.PayPacket);
        }
    }
}
