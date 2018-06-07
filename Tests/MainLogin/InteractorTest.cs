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
        private Mock<IPresenterLogin> _presenterMock;
        private Mock<IValidater> _validaterMock;

        [SetUp]
       public void Setup()
       {
            _validaterMock = new Mock<IValidater>(MockBehavior.Strict);
            _presenterMock = new Mock<IPresenterLogin>(MockBehavior.Strict);
            _interactor = new InteractorLogin(_validaterMock.Object, _presenterMock.Object);
       }


        

        [TestCase("admin", "admin12345", AuthResponse.Success, TestName = "GetAccess Result:Success")]
        [TestCase("aaaa", "admin12345", AuthResponse.AccessError, TestName = "GetAccess Result:AccessError 1")]
        public void GetAccessTest(string login,string pass, AuthResponse response)
        {
            MethodInfo methodInfo = typeof(InteractorLogin).GetMethod("GetAccess", BindingFlags.NonPublic | BindingFlags.Instance);
            var act = methodInfo.Invoke(_interactor,new object[] { login, pass });
            Assert.AreEqual(response, act);      
        }

    }
}
