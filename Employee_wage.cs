using System;

namespace Welcome
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int IsFullTime = 1;
            int EmpRatePerHour = 20;

            int empWage = 0;
            int empHr = 0;

            // Check Attendance

	    Random random = new Random();
            int empCheck = random.Next(0, 2);
            if (empCheck == IsFullTime)
            {
                Console.WriteLine("Employee is Present.");
                empHr = 8;
            }
            else
            {
                Console.WriteLine("Employee is Absent!");
                empHr = 0;
            }
	    
	    // Calculate Employee Daily Wage

            empWage = empHr * EmpRatePerHour;
            Console.WriteLine("Employee Wage = " + empWage);
        }
    }
}
