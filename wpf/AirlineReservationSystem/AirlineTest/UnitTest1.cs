using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;

namespace AirlineTest
{
    [TestFixture]
    public class UnitTest1
    {
        [Test]
        public void WhenLoggingIn()
        {
            var sender = class.send();
            Assert.IsInstanceOf(String,sender);
        }
    }
}
