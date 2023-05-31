using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpWageComputation
{
    public class EmployeeWage
    {
        public const byte FULL_TIME = 1;
        public const byte PART_TIME = 2;
        public const byte FULL_WORKING_HOURS = 8;
        public const byte PART_WORKING_HOURS = 4;
        public const int WAGE_PER_HOUR = 20;
        public const byte WORKING_DAYS_PER_MONTH = 20;

        //Random number generation to check attendance
        public int CheckAttendance(int lower, int upper)
        {
            Random random = new Random();
            int value = random.Next(lower, upper);
            return value;
        }

        //UC1-Check employee is present or absent
        public int PresentOrAbsent()
        {
            int attendance = CheckAttendance(0, 3);

            if (attendance == FULL_TIME)
            {
                Console.WriteLine("The employee is Present");
                return FULL_TIME;
            }
            else if (attendance == PART_TIME)
            {
                Console.WriteLine("The employee is PartTime Present");
                return PART_TIME;
            }
            else
            {
                Console.WriteLine("Employee is Absent");
                return 0;
            }
        }

        //UC2-Calculate Daily Employee Wage
        public int DailyEmployeeWage()
        {
            int value = PresentOrAbsent();
            int employeeHours;
            if (value == FULL_TIME)
                employeeHours = FULL_WORKING_HOURS;
            else if (value == PART_TIME)
                employeeHours = PART_WORKING_HOURS;
            else
                employeeHours = 0;

            int dailyEmpWage = employeeHours * WAGE_PER_HOUR;

            Console.WriteLine("Daily Wage : " + dailyEmpWage);
            return dailyEmpWage;
        }

        //UC3-Calculating part time employee wages (assuming part time - 4hrs)
        public void PartTimeWage()
        {
            int value = DailyEmployeeWage();
        }

        //UC4-Calculating part time employee wages using switch case(assuming part time - 4hrs)
        public int UsingSwitchCase()
        {
            int value = PresentOrAbsent();
            int employeeHours;
            switch (value)
            {
                case 1:
                    employeeHours = FULL_WORKING_HOURS;
                    break;
                case 2:
                    employeeHours = PART_WORKING_HOURS;
                    break;

                default:
                    employeeHours = 0;
                    break;
            }

            int dailyEmpWage = employeeHours * WAGE_PER_HOUR;

            Console.WriteLine("Daily Wage : " + dailyEmpWage);
            return dailyEmpWage;
        }

        //UC5-Calculating wages for a month(assume 20 working days per month)
        public int MonthlyWages()
        {
            int monthlyEmpWage = 0;

            for (int i = 1; i <= WORKING_DAYS_PER_MONTH; i++)
            {
                int dailyEmpWage = DailyEmployeeWage();
                monthlyEmpWage += dailyEmpWage;
            }
            Console.WriteLine("\nThe total wages for the whole month is " + monthlyEmpWage);
            return monthlyEmpWage;
        }
    }
}
