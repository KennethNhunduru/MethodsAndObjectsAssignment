using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsAndObjectsAssignment
{
    //This is the super class which is inherited from.
    class Person
    {
        public string FirstName { get; set; } //declaring the first-name string property.
        public string LastName { get; set; } //declaring the last-name string property.
        
        //Defining the super class method.       
        public void SayName()
        {
            Console.WriteLine("Name: " + this.FirstName + " " + this.LastName);
        }
    }
}
