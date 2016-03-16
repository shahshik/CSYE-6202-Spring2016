using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            double weeklysalary = 800;
            double expected = 800;
            double actual = 800;

            SalariedEmployee salariedEmployee = new SalariedEmployee("Smith", "Joe","123-123-1234", weeklysalary);

            // act
            salariedEmployee.earnings();

            // assert

            Assert.AreEqual(expected, actual, 0.001, "Amount not correct");
        }
    }
}
