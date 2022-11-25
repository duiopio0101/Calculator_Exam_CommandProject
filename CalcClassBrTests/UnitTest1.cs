using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Xml;

namespace CalcClassBr.Tests
{
    [TestClass]
    public class CalcClassTests
    {
        public TestContext TestContext { get; set; }

       
        [TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML", @"C:\Users\38098\Desktop\Test\Calculator1\Calculator1\CalcClassBrTests\TestData.xml", "data", DataAccessMethod.Sequential)]
        public void TestMultiplicateMethodFromCalculator()
        {
            //Arrange
            long a = long.Parse(TestContext.DataRow["a"].ToString());
            long b = long.Parse(TestContext.DataRow["b"].ToString());
            long expected = long.Parse(TestContext.DataRow["expected"].ToString());

            //Act
            var result = CalcClass.Div(a, b);

            //Assert
            Assert.AreEqual(expected, result);
            
        }
    }
}//max 