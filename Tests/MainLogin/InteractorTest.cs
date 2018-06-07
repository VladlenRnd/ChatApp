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
            _interactor = new InteractorLogin(_validaterMock.Object);
            _interactor.Presenter = _presenterMock.Object;
       }


        

        [TestCase("Admin", "Admin12345", AuthResponse.Success, TestName = "GetAccess Result:Success")]
        [TestCase("aaaa", "Admin12345", AuthResponse.AccessError, TestName = "GetAccess Result:AccessError 1")]
        public void GetAccessTest(string login,string pass, AuthResponse response)
        {
            MethodInfo methodInfo = typeof(InteractorLogin).GetMethod("GetAccess", BindingFlags.NonPublic | BindingFlags.Instance);
            var act = methodInfo.Invoke(_interactor,new object[] { login, pass });
            Assert.AreEqual(response, act);      
        }

        [Test]
        public void ValidateTestEvent()
        {
            _presenterMock.Raise(a => a.OnSingIn += null, It.IsAny<string>(), It.IsAny<string>());
            _presenterMock.Verify(f => f.GoToChat(It.IsAny<string>()), Times.Once);
        }


        



    }
}
