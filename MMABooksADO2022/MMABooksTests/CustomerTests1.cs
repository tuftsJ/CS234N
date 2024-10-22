using MMABooksBusinessClasses;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MMABooksTests
{
    internal class CustomerTests1
    {
        [TestFixture]
        public class CustomerTests
        {
            [Test]
            public void Test_Customer_Initialization()
            {
                var customer = new Customer();
                Assert.IsNotNull(customer);
            }

            [Test]
            public void Test_Customer_ToString()
            {
                var customer = new Customer { CustomerId = 1, Name = "John", Email = "john@example.com" };
                Assert.AreEqual("CustomerId: 1, Name: John, Email: john@example.com", customer.ToString());
            }

            // Add tests for the database methods
        }

    }
}
