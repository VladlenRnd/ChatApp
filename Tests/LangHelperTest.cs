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
            _lang = new LangHelper();
        }

        [Test]
        public void NotNullTest()
        {
            _lang = new LangHelper();
            Assert.NotNull(_lang);
        }

        [TestCase("rus",TestName = "Get Lng Pass Txt : NotExeption 1")]
        [TestCase("en_s", TestName = "Get Lng Pass Txt : NotExeption 2")]
        public void GetLngPassTxtTest(string lang)
        {
                Assert.NotNull(_lang.GetLngPassTxt(lang));        
        }

        [TestCase("rus", TestName = "Get Lng Btn In Txt : NotExeption 1")]
        [TestCase("en_s", TestName = "Get Lng Btn In Txt : NotExeption 2")]
        public void GetLngBtnInTxtTest(string lang)
        {
                Assert.NotNull(_lang.GetLngBtnInTxt(lang));
        }

        [TestCase("rus", TestName = "Get Lng Btn Up Txt : NotExeption 1")]
        [TestCase("en_s", TestName = "Get Lng Btn Up Txt : NotExeption 2")]
        public void GetLngBtnUpTxtTest(string lang)
        {
            Assert.NotNull(_lang.GetLngBtnUpTxt(lang));

        }

        [TestCase("rus", TestName = "Get Lng Language Txt : NotExeption 1")]
        [TestCase("en_s", TestName = "Get Lng Language Txt : NotExeption 2")]
        public void GetLngLanguageTxtTest(string lang)
        {
                Assert.NotNull(_lang.GetLngLanguageTxt(lang));
        }

        [TestCase("rus", TestName = "Get Lng Login Txt : NotExeption 1")]
        [TestCase("en_s", TestName = "Get Lng Login Txt : NotExeption 2")]
        public void GetLngLoginTxt(string lang)
        {
                Assert.NotNull(_lang.GetLngLoginTxt(lang));
        }




        [TestCase(null, TestName = "Get Lng Pass Txt Exeption : Exeption 1")]
        public void GetLngPassTxtExeptionTest(string lang)
        {
            Assert.Throws<ArgumentNullException>(() =>
            {
                _lang.GetLngPassTxt(lang);
            });
        }

        [TestCase(null, TestName = "Get Lng Btn In Txt Exeption : Exeption 1")]
        public void GetLngBtnInTxtExeptionTest(string lang)
        {
            Assert.Throws<ArgumentNullException>(() =>
            {
                _lang.GetLngBtnInTxt(lang);
            });
        }


        [TestCase(null, TestName = "Get Lng Btn Up Txt : Exeption 1")]
        public void GetLngBtnUpTxtExeptionTest(string lang)
        {
            Assert.Throws<ArgumentNullException>(() =>
            {
                _lang.GetLngBtnUpTxt(lang);
            });
        }


        [TestCase(null, TestName = "Get Lng Language Txt : Exeption 1")]
        public void GetLngLanguageTxtExeptionTest(string lang)
        {
            Assert.Throws<ArgumentNullException>(() =>
            {
                _lang.GetLngLanguageTxt(lang);
            });
        }


        [TestCase(null, TestName = "Get Lng Login Txt : Exeption 1")]
        public void GetLngLoginTxtExeptionTest(string lang)
        {
            Assert.Throws<ArgumentNullException>(() =>
            {
                _lang.GetLngLoginTxt(lang);
            });
        }





        [TestCase("", TestName = "Get Lng Pass Txt : Null 1")]
        [TestCase(" ", TestName = "Get Lng Pass Txt : Null 2")]
        [TestCase("___", TestName = "Get Lng Pass Txt : Null 3")]
        [TestCase("aaa", TestName = "Get Lng Pass Txt : Null 4")]
        public void GetLngPassTxtNullTest(string lang)
        {
            Assert.Null(_lang.GetLngPassTxt(lang));
        }

        [TestCase("", TestName = "Get Lng Btn In Txt : Null 1")]
        [TestCase(" ", TestName = "Get Lng Btn In Txt : Null 2")]
        [TestCase("___", TestName = "Get Lng Btn In Txt : Null 3")]
        [TestCase("aaa", TestName = "Get Lng Pass Txt : Null 4")]
        public void GetLngBtnInTxtNullTest(string lang)
        {
            Assert.Null(_lang.GetLngBtnInTxt(lang));
        }


        [TestCase("", TestName = "Get Lng Btn Up Txt : Null 1")]
        [TestCase(" ", TestName = "Get Lng Btn Up Txt : Null 2")]
        [TestCase("___", TestName = "Get Lng Btn Up Txt : Null 3")]
        [TestCase("aaa", TestName = "Get Lng Pass Txt : Null 4")]
        public void GetLngBtnUpTxtNullTest(string lang)
        {
                Assert.Null(_lang.GetLngBtnUpTxt(lang));
        }


        [TestCase("", TestName = "Get Lng Language Txt : Null 1")]
        [TestCase(" ", TestName = "Get Lng Language Txt : Null 2")]
        [TestCase("___", TestName = "Get Lng Language Txt : Null 3")]
        [TestCase("aaa", TestName = "Get Lng Pass Txt : Null 4")]
        public void GetLngLanguageTxtNullTest(string lang)
        {
                Assert.Null(_lang.GetLngLanguageTxt(lang));
        }


        [TestCase("", TestName = "Get Lng Login Txt : Null 1")]
        [TestCase(" ", TestName = "Get Lng Login Txt : Null 2")]
        [TestCase("___", TestName = "Get Lng Login Txt : Null 3")]
        [TestCase("aaa", TestName = "Get Lng Pass Txt : Null 4")]
        public void GetLngLoginTxtNullTest(string lang)
        {
                Assert.Null(_lang.GetLngLoginTxt(lang));
        }

    }
}
