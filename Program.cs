namespace EmployeeManager
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Check the validation of the employee name 
            Boolean validName = false;
            string inputEmployeeName = "";
            string inputEmployeeID = "";
            do
            {
                Console.Write("Enter a name: ");
                inputEmployeeName = Console.ReadLine();

                // Check if the name is valid using the 
                // IsValidName method from the employee class
                if (Employee.IsValidName(inputEmployeeName))
                {
                    // If the name is valid set the validName variable to true
                    validName = true;
                    Console.Write("Enter an employee ID: ");
                    inputEmployeeID = Console.ReadLine();
                }
                
            } while (validName == false);

            

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
