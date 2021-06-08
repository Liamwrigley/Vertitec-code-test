using System;
using System.Collections.Generic;
using System.Text;

namespace Veritec_Solution
{
    public static class Constants
    {
        // This class will contain all publicly accessable constants for the projects
        public static double SuperAnnuationPercent = 9.5;
        public enum PayInterval {
            WEEKLY = 52,
            FORTNIGHTLY = 26,
            MONTHLY = 12
        }
        public static Dictionary<string, PayInterval> PayIntervals = new Dictionary<string, PayInterval> {
            {"W", PayInterval.WEEKLY },
            {"F", PayInterval.FORTNIGHTLY },
            {"M", PayInterval.MONTHLY }
        };
        public static Dictionary<PayInterval, string> PayIntervalOutput = new Dictionary<PayInterval, string> {
            {PayInterval.WEEKLY, "per week" },
            {PayInterval.FORTNIGHTLY, "per fortnight" },
            {PayInterval.MONTHLY, "per month" }
        };
    }
}
