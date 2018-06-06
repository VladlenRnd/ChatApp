using System;
using NUnit.Framework;
using Portable;
using Portable.Interface;

namespace Tests
{

    [TestFixture]
    public class LangHelperTest
    {
        private ILangHelper _lang;

        [SetUp]
        public void Setup()
        {
            _lang = new LangHelper("rus");
        }

        [Test]
        public void NotNullTest()
        {
            _lang = new LangHelper("rus");
            Assert.NotNull(_lang);
        }

        [TestCase("rus",TestName = "Get Lng Pass Txt : NotExeption 1")]
        [TestCase("en_s", TestName = "Get Lng Pass Txt : NotExeption 2")]
        public void GetLngPassTxtTest(string lang)
        {
            Assert.DoesNotThrow(() =>
            {
                _lang.GetLngPassTxt(lang);
            });
           
        }

        [TestCase("rus", TestName = "Get Lng Btn In Txt : NotExeption 1")]
        [TestCase("en_s", TestName = "Get Lng Btn In Txt : NotExeption 2")]
        public void GetLngBtnInTxtTest(string lang)
        {
            Assert.DoesNotThrow(() =>
            {
                _lang.GetLngBtnInTxt(lang);
            });

        }

        [TestCase("rus", TestName = "Get Lng Btn Up Txt : NotExeption 1")]
        [TestCase("en_s", TestName = "Get Lng Btn Up Txt : NotExeption 2")]
        public void GetLngBtnUpTxtTest(string lang)
        {
            Assert.DoesNotThrow(() =>
            {
                _lang.GetLngBtnUpTxt(lang);
            });

        }

        [TestCase("rus", TestName = "Get Lng Language Txt : NotExeption 1")]
        [TestCase("en_s", TestName = "Get Lng Language Txt : NotExeption 2")]
        public void GetLngLanguageTxtTest(string lang)
        {
            Assert.DoesNotThrow(() =>
            {
                _lang.GetLngLanguageTxt(lang);
            });

        }

        [TestCase("rus", TestName = "Get Lng Login Txt : NotExeption 1")]
        [TestCase("en_s", TestName = "Get Lng Login Txt : NotExeption 2")]
        public void GetLngLoginTxt(string lang)
        {
            Assert.DoesNotThrow(() =>
            {
                _lang.GetLngLoginTxt(lang);
            });

        }






        [TestCase("", TestName = "Get Lng Pass Txt : Exeption 1")]
        [TestCase(" ", TestName = "Get Lng Pass Txt : Exeption 2")]
        [TestCase(null, TestName = "Get Lng Pass Txt : Exeption 3")]
        [TestCase("___", TestName = "Get Lng Pass Txt : Exeption 4")]
        [TestCase("aaa", TestName = "Get Lng Pass Txt : Exeption 5")]
        public void GetLngPassTxtExeptionTest(string lang)
        {
            Assert.Throws<ArgumentException>(() =>
            {
                _lang.GetLngPassTxt(lang);
            });
        }

        [TestCase("", TestName = "Get Lng Btn In Txt : Exeption 1")]
        [TestCase(" ", TestName = "Get Lng Btn In Txt : Exeption 2")]
        [TestCase(null, TestName = "Get Lng Btn In Txt : Exeption 3")]
        [TestCase("___", TestName = "Get Lng Btn In Txt : Exeption 4")]
        [TestCase("aaa", TestName = "Get Lng Pass Txt : Exeption 5")]
        public void GetLngBtnInTxtExeptionTest(string lang)
        {
            Assert.Throws<ArgumentException>(() =>
            {
                _lang.GetLngBtnInTxt(lang);
            });
        }


        [TestCase("", TestName = "Get Lng Btn Up Txt : Exeption 1")]
        [TestCase(" ", TestName = "Get Lng Btn Up Txt : Exeption 2")]
        [TestCase(null, TestName = "Get Lng Btn Up Txt : Exeption 3")]
        [TestCase("___", TestName = "Get Lng Btn Up Txt : Exeption 4")]
        [TestCase("aaa", TestName = "Get Lng Pass Txt : Exeption 5")]
        public void GetLngBtnUpTxtExeptionTest(string lang)
        {
            Assert.Throws<ArgumentException>(() =>
            {
                _lang.GetLngBtnUpTxt(lang);
            });
        }


        [TestCase("", TestName = "Get Lng Language Txt : Exeption 1")]
        [TestCase(" ", TestName = "Get Lng Language Txt : Exeption 2")]
        [TestCase(null, TestName = "Get Lng Language Txt : Exeption 3")]
        [TestCase("___", TestName = "Get Lng Language Txt : Exeption 4")]
        [TestCase("aaa", TestName = "Get Lng Pass Txt : Exeption 5")]
        public void GetLngLanguageTxtExeptionTest(string lang)
        {
            Assert.Throws<ArgumentException>(() =>
            {
                _lang.GetLngLanguageTxt(lang);
            });
        }


        [TestCase("", TestName = "Get Lng Login Txt : Exeption 1")]
        [TestCase(" ", TestName = "Get Lng Login Txt : Exeption 2")]
        [TestCase(null, TestName = "Get Lng Login Txt : Exeption 3")]
        [TestCase("___", TestName = "Get Lng Login Txt : Exeption 4")]
        [TestCase("aaa", TestName = "Get Lng Pass Txt : Exeption 5")]
        public void GetLngLoginTxtExeptionTest(string lang)
        {
            Assert.Throws<ArgumentException>(() =>
            {
                _lang.GetLngLoginTxt(lang);
            });
        }







    }
}
