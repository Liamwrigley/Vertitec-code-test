using System;
using System.Collections.Generic;
using System.Text;

namespace Veritec_Solution.Taxations
{
    interface IDeductions
    {
        List<double> CalculateDeductions(double taxableIncome);
        double CalculateSuperAnnuation(double grossPackage);
    }
}
