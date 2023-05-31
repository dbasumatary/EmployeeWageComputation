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
    }
}
