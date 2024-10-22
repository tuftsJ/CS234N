using MMABooksBusinessClasses;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MMABooksTests
{
    internal class ProductClassTests1
    {

        [TestFixture]
        public class ProductTests
        {
            [Test]
            public void Test_Product_Initialization()
            {
                var product = new Product();
                Assert.IsNotNull(product);
            }

            [Test]
            public void Test_Product_ToString()
            {
                var product = new Product { ProductId = 1, Name = "Book", Price = 19.99M };
                Assert.AreEqual("ProductId: 1, Name: Book, Price: 19.99", product.ToString());
            }

            // Add tests for the database methods
        }

    }
}
