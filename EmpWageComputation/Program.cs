namespace EmpWageComputation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            EmployeeWage employeeWage = new EmployeeWage();
            //employeeWage.PresentOrAbsent();
            //employeeWage.DailyEmployeeWage();
            employeeWage.PartTimeWage();
        }
    }
}