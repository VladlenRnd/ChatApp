using System;
using NUnit.Framework;
using Portable.Enum;
using Portable.MainViper.Interactor;
using Portable.MainViper.Interface;

namespace Tests.MainLogin
{
    [TestFixture]
    public class InteractorTest
    {

        IInteractorLogin _interactor;

        [SetUp]
       public void Setup()
       {
            _interactor = new InteractorLogin();
        }


        [TestCase("","",AuthResponse.InvelidData,TestName = "Set data login Result:InvelidData 0")]
        [TestCase("Admin", "", AuthResponse.InvelidData, TestName = "Set data login Result:InvelidData 1")]
        [TestCase("", "Admin", AuthResponse.InvelidData, TestName = "Set data login Result:InvelidData 2")]
        [TestCase(null, null, AuthResponse.InvelidData, TestName = "Set data login Result:InvelidData 3")]
        [TestCase("Admin", "Admin", AuthResponse.Success, TestName = "Set data login Result:Success")]
        [TestCase("Admin123", "Admin", AuthResponse.AccessError, TestName = "Set data login Result:AccessError 1")]
        [TestCase("Admin", "Admin123", AuthResponse.AccessError, TestName = "Set data login Result:AccessError 2")]
        public void SetDataLoginTest(string login,string pass, AuthResponse response)
        {
            var act = _interactor.SetLoginData(login, pass);
            Assert.AreEqual(response, act);      
        }

        [Test]
        public void SetPresenter()
        {
            Assert.NotNull(_interactor._presenter);
        }

        

    }
}
