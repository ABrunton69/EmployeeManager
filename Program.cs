namespace EmployeeManager
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            Console.Write("Enter a name: ");
            string inputEmployeeName = Console.ReadLine();
            Console.Write("Enter an employee ID: ");
            string inputEmployeeID = Console.ReadLine();

            // Create the employee object
            Employee MyEmployee = new Employee()
            {
                employeeName = inputEmployeeName,
                employeeId = inputEmployeeID,
                hoursWorked = 25,
                hourlyRate = 12.42,
            };

            // Output the employee data using the ToString method
            Console.WriteLine(MyEmployee);
        }
    }
}
