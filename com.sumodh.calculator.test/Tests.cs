using com.sumodh.calculator.Addition;
using com.sumodh.calculator.Common;
using com.sumodh.calculator.Division;
using com.sumodh.calculator.Subtraction;
using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace com.sumodh.calculator.test
{
    [TestClass]
    public class Tests
    {
        [TestMethod]
        public void AddTwoNumber_Success()
        {
            ValuesDTO valuesDTO = new ValuesDTO()
            {
                Value1 = 1,
                Value2 = 2,
            };

            AddController controller = new AddController();
            var result = (controller.Add(valuesDTO) as OkObjectResult).Value;

            Assert.AreEqual(3M,result);
        }

        [TestMethod]
        public void SubtractNumbers_Success()
        {
            ValuesDTO valuesDTO = new ValuesDTO()
            {
                Value1 = 5,
                Value2 = 2,
            };

            SubtractController subtractController = new SubtractController();
       
            var result = (subtractController.Subtract(valuesDTO) as OkObjectResult).Value;

            Assert.AreEqual(3M, result);
        }

        [TestMethod]
        public void SubtractNumbers_Success_SecondValueBiggerThanFirst()
        {
            ValuesDTO valuesDTO = new ValuesDTO()
            {
                Value1 = 2,
                Value2 = 5,
            };

            SubtractController subtractController = new SubtractController();
            var result = (subtractController.Subtract(valuesDTO) as OkObjectResult).Value;

            Assert.AreEqual(-3M, result);
        }

        [TestMethod]
        public void MultiplyNumbers_Success()
        {
            ValuesDTO valuesDTO = new ValuesDTO()
            {
                Value1 = 2,
                Value2 = 5,
            };

            Multiplication.MultiplicationController subtractController = new Multiplication.MultiplicationController();
            var result = (subtractController.Multiply(valuesDTO) as OkObjectResult).Value;

            Assert.AreEqual(10M, result);
        }

        [TestMethod]
        public void DivideNumbers_Success()
        {
            ValuesDTO valuesDTO = new ValuesDTO()
            {
                Value1 = 15,
                Value2 = 5,
            };

            DivisionController subtractController = new DivisionController();
            var result = (subtractController.Divide(valuesDTO) as OkObjectResult).Value;

            Assert.AreEqual(3M, result);
        }

        [TestMethod]
        public void DivideNumbers_DivideByZero()
        {
            ValuesDTO valuesDTO = new ValuesDTO()
            {
                Value1 = 15,
                Value2 = 0,
            };

            DivisionController subtractController = new DivisionController();
            Assert.IsInstanceOfType(subtractController.Divide(valuesDTO), typeof(BadRequestObjectResult));
        }


    }
}