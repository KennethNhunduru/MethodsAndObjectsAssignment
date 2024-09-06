using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsAndObjectsAssignment
{
    //This is the sub-class inheriting properties and methods from the super class Person.
    class Employee : Person
    {
        public int Id { get; set; } //Property of the sub-class (Sub class can have its own properties)
    }
}
