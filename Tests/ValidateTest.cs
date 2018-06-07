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
        [TestCase("admin123", CodeValidate.UnresolvedСharacters, TestName = "ValidateLogin 3 Result UnresolvedСharacters")]

        [TestCase("aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa", CodeValidate.OverflowMaxLogin, TestName = "ValidateLogin 2 Result Overflow")]

        [TestCase("Admin", CodeValidate.OK, TestName = "ValidateLogin 1 Result Ok")]    
        [TestCase("admin", CodeValidate.OK, TestName = "ValidateLogin 2 Result Ok")]
        [TestCase(" admin", CodeValidate.OK, TestName = "ValidateLogin 3 Result Ok")]
        [TestCase("admin ", CodeValidate.OK, TestName = "ValidateLogin 4 Result Ok")]
        [TestCase("ADMIN", CodeValidate.OK, TestName = "ValidateLogin 5 Result Ok")]
        [TestCase("123admin", CodeValidate.OK, TestName = "ValidateLogin 6 Result Ok")]
        [TestCase("admin`s", CodeValidate.OK, TestName = "ValidateLogin 7 Result Ok")]
        [TestCase("admin`s-admin", CodeValidate.OK, TestName = "ValidateLogin 8 Result Ok")]
        [TestCase("a", CodeValidate.OK, TestName = "ValidateLogin 9 Result Ok")]
        [TestCase("aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa", CodeValidate.OK, TestName = "ValidateLogin 10 Result Ok")]
        [TestCase("admin−admin", CodeValidate.OK, TestName = "ValidateLogin 11 Result Ok")]
        [TestCase("admin-admin", CodeValidate.OK, TestName = "ValidateLogin 12 Result Ok")]
        [TestCase("admin admin", CodeValidate.OK, TestName = "ValidateLogin 13 Result Ok")]
        [TestCase("админ", CodeValidate.OK, TestName = "ValidateLogin 14 Result Ok")]
        public void ValidateLoginTest(string login, CodeValidate exp)
        {
            var act = _validater.ValidateLogin(login);
            Assert.AreEqual(exp, act);
        }


        [TestCase("", CodeValidate.EmptyField, TestName = "ValidatePass 1 Result EmptyField")]


        [TestCase("a", CodeValidate.OverflowMinPass, TestName = "ValidatePass 1 Result OverflowMinPass")]
        [TestCase("aa", CodeValidate.OverflowMinPass, TestName = "ValidatePass 2 Result OverflowMinPass")]
        [TestCase(" ", CodeValidate.OverflowMinPass, TestName = "ValidatePass 3 Result OverflowMinPass")]

        [TestCase("aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa" +
                  "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa",
        CodeValidate.OverflowMaxPass, TestName = "ValidatePass 1 Result OverflowMax")]

        [TestCase("12345678", CodeValidate.NoLetter, TestName = "ValidatePass 1 Result NoLetter")]
        [TestCase("qwertyuiopasd", CodeValidate.NoNumbers, TestName = "ValidatePass 1 Result NoNumbers")]

        [TestCase("12345678a", CodeValidate.OK, TestName = "ValidatePass 1 Result Ok")]
        [TestCase("admin12345", CodeValidate.OK, TestName = "ValidatePass 2 Result Ok")]
        [TestCase(" admin12345", CodeValidate.OK, TestName = "ValidatePass 3 Result Ok")]
        [TestCase(" admin12345 ", CodeValidate.OK, TestName = "ValidatePass 4 Result Ok")]
        [TestCase("admin12345 ", CodeValidate.OK, TestName = "ValidatePass 5 Result Ok")]
        [TestCase("admin1ϩϪ √ ∫ ∂ ∑ ∏ & ♔♕♖♗♘♙ ♠ ♣ ♥ ♦ æ ɐ ɶ ɑ ɒ", CodeValidate.OK, TestName = "ValidatePass 6 Result Ok")]
        public void ValidatePassTest(string pass, CodeValidate exp)
        {
            var act = _validater.ValidatePassword(pass);
            Assert.AreEqual(exp, act);
        }

    }
}
