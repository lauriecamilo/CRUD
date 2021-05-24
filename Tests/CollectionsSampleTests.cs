using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using UnitTestingMsTestIntro;

namespace Tests
{
    [TestClass]
    public class CollectionsSampleTests
    {
        [TestMethod]
        public void GetCustomer_ShouldGetSameCustomer()
        {
            //Arrange
            Customer[] customers = new Customer[2] {new Customer { FirstName = "Laurie", LastName = "Camilo"},
                                                    new Customer {FirstName = "Carol", LastName = "Garcia"}};

            int index = 1;
            Customer expected = customers[1];

            //Act
            Customer actual = ColletionsSample.GetCustomer(customers, index);


            //Assert
            Assert.IsInstanceOfType(actual, typeof(Customer));
            Assert.AreEqual(expected, actual);
        }

        // Da error
        [TestMethod]
        [ExpectedException(typeof(IndexOutOfRangeException))]
        public void GetCustomer_ShouldThrowIndexOutofRangeException()
        {
            //Arrange
            Customer[] customers = new Customer[2] {new Customer { FirstName = "Laurie", LastName = "Camilo"},
                                                    new Customer {FirstName = "Carol", LastName = "Garcia"}};

            int index = 3;

            //Act
            ColletionsSample.GetCustomer(customers, index);

            //Assert

        }
    }
}
