using System;

namespace Welcome
{
    class Program
    {
        static void Main(string[] args)
        {
            int IsFullTime = 1;
            int IsPartTime = 0;
            int EmpRatePerHour = 20;

            int empWage = 0;
            int empHr = 8;
            empWage = empHr * EmpRatePerHour;
            int empFTWageMonth = 0;
            int empPTWageMonth = 0;

            // Calculate Monthly wage for Full Time and Part Time

            for (int emphrrate = 1; emphrrate <= 20; emphrrate++)
            {
                Random random = new Random();
                int empCheck = random.Next(0, 3);

                if (empCheck == IsPartTime)
                {
                    empPTWageMonth = empPTWageMonth + empWage;
                }
                else if (empCheck == IsFullTime)
                {
                    empFTWageMonth = empFTWageMonth + empWage;
                }
            }
            Console.WriteLine("Part time Employee Monthly Wage = " + empPTWageMonth);
            Console.WriteLine("Full time Employee Monthly Wage = " + empFTWageMonth);
        }
    }
}
