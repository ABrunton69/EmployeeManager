using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManager
{
    internal class Employee
    {
        // A class to handle employee functionality

        // Field for the employees name
        public string employeeName { get; set; }
        
        // Field for the ID of the employee that is returned
        // Currently contains a place holder value for an 
        // incorrect ID format
        public string _employeeId = "A12";
        
        // A public method for updating the employee ID
        // Checks to ensure that the ID is in the correct format.
        public string employeeId
        {
            get { return _employeeId; }
            set
            {
                if (Convert.ToInt32(value[0]) >= 65 && Convert.ToInt32(value[0]) <= 90)
                {
                    _employeeId = value;
                }
                else
                {
                    Console.WriteLine("Setting ID as default value (A12), ID must be a LETTER followed by a 2 digit number");
                }
            }
        }
        
        // More attributes for the employee object
        public double hoursWorked { get; set; }
        public double hourlyRate { get; set; }
        public double weeklyWage { get { return hoursWorked * hourlyRate; } }


        // Sets default values in a constructor for the employees
        // hourly rate and hours worked
        public Employee()
        {
            this.hourlyRate = 9.5;
            this.hoursWorked = 5;
        }

        // A static method for validating the employee name
        public static Boolean IsValidName(string employeeNameInput)
        {
            // Check the length of the inputted name is between 1 and 50 
            // characters long inclusive.
            if (employeeNameInput.Length >= 1 && employeeNameInput.Length <= 50)
            {
                // Return true if the name is between 1 and 50 characters inclusive
                return true;
            }
            // Return false if the name is not between 1 and 50 characters inslusive
            return false;
        }

        // Returns attributes from the employee object in a string format 
        // that is readable by the user
        public override string ToString()
        {
            return $"Employee Name: {employeeName}\nEmployee ID: {employeeId}\nHours Worked: {hoursWorked}\n\nThe weekly wage is: {weeklyWage}";
        }
    }
}
