using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsAndObjectsAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee(); //Instantiating the sub-class (creating an object of the class).
            employee.FirstName = "Sample"; //Initialising the first inherited property.
            employee.LastName = "Student"; //Initialising the second inherited property.

            //Calling the super class method on the employee object.
            employee.SayName();
            Console.ReadLine(); //Displaying the method output to the Console.
        }
    }
}
