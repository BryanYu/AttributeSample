using System;
using AttributeSample.Enums;
using AttributeSample.Extensions;
using NUnit.Framework;

namespace AttributeSample.Test
{
    [TestFixture]
    public class AttributeSampleTest
    {
        [TestCase(MessageType.Mail, "電子郵件")]
        [TestCase(MessageType.Sms, "簡訊")]
        [TestCase(MessageType.Line, "Line訊息")]
        public void AliasAttribute_Extension_Test(MessageType type, string expected)
        {
            var actual = type.GetAlias();
            Assert.AreEqual(actual, expected);
        }
    }
}