# Veritec Takehome Assignment

##### _Completed by Liam Wrigley_
---

Most likely areas to need changing / expanding:
- Levy conditions (income ranges, cutoffs and percentages)
    - Income ranges
    - Cutoffs
    - percentages
- Amount of tiers in each levy
- superannuation percentages

To attempt to make the system easy to expand, each deduction type can easily have tiers added and removed, as well as modified. This is done by seperation into the concepts; Levy & Tiers. Each Levy can then easily have deductions calculated based on tiers & the configured percentages and rules.

There is basic input validation ensuring that the user will enter a salary package that is both; of type `Double` and greater than 0. There is also validation to ensure that the user enters a valid pay rate, case insensitive.
