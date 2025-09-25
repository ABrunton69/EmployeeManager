namespace EmployeeManager
{
    internal class Program
    {
        // Initiate a list of employees 
        public static List<Employee> employees = new List<Employee>();

        static void Main(string[] args)
        {
            // A variable for storing navigation input from
            // the user
            string userInput = null;

            

            // Run the main part of the program
            do
            {
                // Display the menu to the user
                DisplayEmployeeMenu();

                // Display an input field for the user
                Console.Write("Option: ");
                userInput = Console.ReadLine();

                if (userInput == "1")
                {
                    AddEmployee();
                } else if (userInput == "2")
                {
                    ListEmployees();
                } else if (userInput == "3")
                {
                    Console.Write("Enter employee position to remove: ");
                    int position = Convert.ToInt32(Console.ReadLine());
                    RemoveEmployee(position);
                }

            } while (userInput != "q");

           
        }
        
        // Method to display a menu that the user interacts with
        public static void DisplayEmployeeMenu()
        {
            Console.WriteLine();
            Console.WriteLine("**************************");
            Console.WriteLine("Enter an option from below! \n\n");
            Console.WriteLine("[1] Add Employee");
            Console.WriteLine("[2] List Employees");
            Console.WriteLine("[3] Remove Employee");
            Console.WriteLine("**************************");
            Console.WriteLine();
        }

        // Method for adding an employee to the list
        public static void AddEmployee()
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
            employees.Add(new Employee()
            {
                employeeName = inputEmployeeName,
                employeeId = inputEmployeeID,
                hoursWorked = 25,
                hourlyRate = 12.42,
            });


            // Add the employee to the list of employees 
        }
    
        // Method for listing employees
        public static void ListEmployees()
        {
            Console.WriteLine("\n\nEmployees List");
            
            // Counter to show the index of the emploee in the list
            int index = 0;

            // Loop through each employee and display their data
            foreach (var employee in employees)
            {
                // Write their data along with their position in the 
                // employee list to the display
                Console.WriteLine($"Employee Number: {index}{employee}");

                // Increment the list position value
                index++;
            }
        }

        // Method for removing an employee based on their list position
        public static void RemoveEmployee(int employeePosition)
        {
            employees.RemoveAt(employeePosition);
            Console.WriteLine("Employee removed successfully!");
        }

        

    }
}
