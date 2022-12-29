using System;
using Xunit;

namespace UnitTestingExercise.Tests
{
    public class UnitTests
    {
        [Theory]
        [InlineData(2, 3, 5, 10)] //Add test data <-------
        [InlineData(2, 2, 2, 6)] //Add test data <-------
        public void AddTest(int num1, int num2, int num3, int expected)
        {
            //Start Step 3 here:

            //Arrange
            // create a Calculator object -- make an instance
            Calculator instance= new Calculator();
            

            //Act
                // call the Add method that is located in the Calculator class
                // and store its result in a variable named actual

            var actual = instance.Add(num1, num2, num3);
            //Assert
                //Assert.Equal(expected, actual);
                Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(10, 5, 6)]//Add test data <-------
        [InlineData(10, 6, 3)]
        public void SubtractTest(int minuend, int subtrhend, int expected)
        {
            //Start Step 5 here:

            //Arrange
            var instance = new Calculator();
            //Act
            var actual = instance.Subtract(minuend, subtrhend);
            //Assert

        }

        [Theory]
        [InlineData(5, 5, 25)]//Add test data <-------
        public void MultiplyTest(int firstnumber, int secondnumber, int expected)
        {
            //Start Step 7 here:

            //Arrange
            var instance =new Calculator();
            //Act
            var actual = instance.Multiply(firstnumber, secondnumber);
            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(5, 5, 1)]//Add test data <-------
        [InlineData(5, 5, 1)]
        [InlineData(5, 5, 1)]
        public void DivideTest(int num1, int num2, int expected)
        {
            //Arrange
            var instance = new Calculator();    
            //Act
            var actual = instance.Divide(num1, num2);
            //Assert
            Assert.Equal(expected, actual);
        }

    }
}
