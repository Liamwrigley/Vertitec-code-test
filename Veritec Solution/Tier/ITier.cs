using System;
using System.Collections.Generic;
using System.Text;

namespace Veritec_Solution.Repositories
{
    public interface ITier
    {
        double CalculateDeduction(double TaxableIncome);
        double GetCutoffLower();
        double GetCutoffUpper();
        double GetTaxableThreshold();
        double GetLevyPercent();
        double GetBaseTaxAmount();
    }
}
