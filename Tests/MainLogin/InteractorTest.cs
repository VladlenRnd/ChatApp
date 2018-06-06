using System;
using System.Reflection;
using NUnit.Framework;
using Portable.Enum;
using Portable.MainViper.Interactor;
using Portable.MainViper.Interface;
using Moq;
using Portable.Interface;

namespace Tests.MainLogin
{
    [TestFixture]
    public class InteractorTest
    {

        private IInteractorLogin _interactor;
        private Mock<IValidater> _validaterMock;

        [SetUp]
       public void Setup()
       {
            _validaterMock = new Mock<IValidater>(MockBehavior.Strict);
            _interactor = new InteractorLogin(_validaterMock.Object);
       }


        
        [TestCase("","",AuthResponse.InvelidData,TestName = "GetAccess Result:InvelidData 0")]
        [TestCase("Admin", "", AuthResponse.InvelidData, TestName = "GetAccess Result:InvelidData 1")]
        [TestCase("", "Admin", AuthResponse.InvelidData, TestName = "GetAccess Result:InvelidData 2")]
        [TestCase(null, null, AuthResponse.InvelidData, TestName = "GetAccess Result:InvelidData 3")]
        [TestCase("Admin", "Admin", AuthResponse.Success, TestName = "GetAccess Result:Success")]
        [TestCase("Admin123", "Admin", AuthResponse.AccessError, TestName = "GetAccess Result:AccessError 1")]
        [TestCase("Admin", "Admin123", AuthResponse.AccessError, TestName = "GetAccess Result:AccessError 2")]
        public void GetAccessTest(string login,string pass, AuthResponse response)
        {
            MethodInfo methodInfo = typeof(InteractorLogin).GetMethod("GetAccess", BindingFlags.NonPublic | BindingFlags.Instance);
            var act = methodInfo.Invoke(_interactor,new object[] { login, pass });
            Assert.AreEqual(response, act);      
        }


    }
}
