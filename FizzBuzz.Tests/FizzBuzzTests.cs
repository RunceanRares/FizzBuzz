using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FizzBuzz.Tests
{
    [TestClass]
    public class FizzBuzzTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            //Arrange
            FizzBuzzTDD fizzbuz = new FizzBuzzTDD();

            //Act
            string rezultat = fizzbuz.Convert(7);
            
            //Assert

            Assert.AreEqual("7", rezultat);
            
        }
        [TestMethod]
        public void TestMethod2_ShouldFizz3()
        {
            //Arrange
            FizzBuzzTDD fizzbuz = new FizzBuzzTDD();

            //Act
            string rezultat = fizzbuz.Convert(12);

            //Assert
            Assert.AreEqual("Fizz", rezultat);

        }
        [TestMethod]
        public void TestMethod2_ShouldFizz5()
        {
            //Arrange
            FizzBuzzTDD fizzbuz = new FizzBuzzTDD();

            //Act
            string rezultat = fizzbuz.Convert(20);

            //Assert
            Assert.AreEqual("Buzz", rezultat);

        }
        [TestMethod]
        public void TestMethod2_ShouldFizzFull()
        {
            //Arrange
            FizzBuzzTDD fizzbuz = new FizzBuzzTDD();

            //Act
            string rezultat = fizzbuz.Convert(30);

            //Assert
            Assert.AreEqual("FizzBuzz", rezultat);

        }
    }
}
