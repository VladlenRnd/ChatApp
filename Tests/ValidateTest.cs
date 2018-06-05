using System;
using System.Reflection;
using NUnit.Framework;
using Portable;
using Portable.Enum;
using Portable.Interface;

namespace Tests
{
    [TestFixture]
    public class ValidateTest
    {
        private IValidater _validater;

        [SetUp]
        public void Setup()
        {
            _validater = new Validater();
        }


        [TestCase("", CodeValidate.EmptyField, TestName = "ValidateLogin 1 Result EmptyField")]
        [TestCase(" ", CodeValidate.EmptyField, TestName = "ValidateLogin 2 Result EmptyField")]

        [TestCase("`", CodeValidate.UnresolvedСharacters, TestName = "ValidateLogin 1 Result UnresolvedСharacters")]
        [TestCase("`admin`", CodeValidate.UnresolvedСharacters, TestName = "ValidateLogin 2 Result UnresolvedСharacters")]

        [TestCase("Admin", CodeValidate.OK, TestName = "ValidateLogin 1 Result Ok")]
        [TestCase("admin", CodeValidate.OK, TestName = "ValidateLogin 2 Result Ok")]
        [TestCase(" admin", CodeValidate.OK, TestName = "ValidateLogin 3 Result Ok")]
        [TestCase("admin ", CodeValidate.OK, TestName = "ValidateLogin 4 Result Ok")]
        public void ValidateLoginTest(string login, CodeValidate exp)
        {
            var act = _validater.ValidateLogin(login);
            Assert.AreEqual(exp, act);
        }


        [TestCase("", CodeValidate.EmptyField, TestName = "ValidatePass 1 Result EmptyField")]
        [TestCase(" ", CodeValidate.EmptyField, TestName = "ValidatePass 2 Result EmptyField")]

        [TestCase("`", CodeValidate.UnresolvedСharacters, TestName = "ValidatePass 1 Result UnresolvedСharacters")]
        [TestCase("`admin`", CodeValidate.UnresolvedСharacters, TestName = "ValidatePass 2 Result UnresolvedСharacters")]

        [TestCase("Admin", CodeValidate.OK, TestName = "ValidatePass 1 Result Ok")]
        [TestCase("admin", CodeValidate.OK, TestName = "ValidatePass 2 Result Ok")]
        [TestCase(" admin", CodeValidate.OK, TestName = "ValidatePass 3 Result Ok")]
        [TestCase("admin ", CodeValidate.OK, TestName = "ValidatePass 4 Result Ok")]
        public void ValidatePassTest(string pass, CodeValidate exp)
        {
            var act = _validater.ValidateLogin(pass);
            Assert.AreEqual(exp, act);
        }

    }
}
