using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;

namespace AirlineTest
{
    [TestFixture]
    public class UnitTest1
    {
        [Test]
       
        public void When_UserEnterName_NullValueEnter_ResultShouldBeFalse()
        {
            //prepare
            var expected = false;
            //action
            var actual = CustomerRegistration.userEnteredNameValid("");
            //assert
            NUnit.Framework.Assert.That(expected, Is.EqualTo(actual));
        }

        public void When_UserEnterPhoneNo_ProperFormat_ResultShouldBeFalse()
        {
            //prepare
            var expected = false;
            //action
            var actual = CustomerRegistration.userEnteredPhoneNoValid("");
            //assert
            NUnit.Framework.Assert.That(expected, Is.EqualTo(actual));
        }
    }
}
