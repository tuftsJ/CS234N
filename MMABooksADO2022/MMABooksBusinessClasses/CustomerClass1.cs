using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MMABooksBusinessClasses
{
    public class Customer
    {
        public int CustomerId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        // Add other properties as per the table structure

        public override string ToString()
        {
            return $"CustomerId: {CustomerId}, Name: {Name}, Email: {Email}";
        }

        // Validation logic for properties can be added in setters
    }

}
