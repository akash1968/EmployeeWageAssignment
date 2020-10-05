using System;

namespace UC1
{
    class Program
    {
        static void Main(string[] args)
        {
            const int PART_TIME = 2;
            const int FULL_TIME = 1;
            const int empWagePerHour = 20;
            int numberOfWorkingDaysInMonth = 20;
            int empHours = 0;
            int totalWagePerDay = 0;
            int totalWagePerMonth = 0;
            for (int day = 0; day < numberOfWorkingDaysInMonth; day++)
            {
                Random random = new Random();
                int empCheck = random.Next(0, 3);
                switch (empCheck)
                {
                    case FULL_TIME:
                        empHours = 8;
                        break;
                    case PART_TIME:
                        empHours = 4;
                        break;
                    default:
                        empHours = 0;
                        break;
                }
                totalWagePerDay = empHours * empWagePerHour;
                totalWagePerMonth += totalWagePerDay;
                Console.WriteLine("Total Wage.. " + totalWagePerDay);
            }
            Console.WriteLine("Total Wage per month: " + totalWagePerMonth);
            Console.ReadKey();
        }
    }
}