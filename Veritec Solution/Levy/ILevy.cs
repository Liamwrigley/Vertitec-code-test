using System;
using System.Collections.Generic;
using System.Text;

namespace Veritec_Solution
{
    public interface ILevy
    {
        List<Tier> GetTiers();
        double CalculateTax(double taxableIncome);
    }
}
