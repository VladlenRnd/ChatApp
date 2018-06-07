using System;
using NUnit.Framework;
using Moq;
using Portable.MainViper.Interface;
using Portable.MainViper.Presenter;
using Portable.Interface;

namespace Tests.MainLogin
{
    [TestFixture]
    public class PresenterTest
    {

        private IPresenterLogin _presenter;
        private Mock<IRouter> _routerMock;
        private Mock<ILoginView> _viewMock;
        private Mock<ILangHelper> _helperMock;

        [SetUp]
        public void Setup()
        {
            _viewMock = new Mock<ILoginView>(MockBehavior.Strict);
            _routerMock = new Mock<IRouter>(MockBehavior.Strict);
            _helperMock = new Mock<ILangHelper>(MockBehavior.Strict);
            _presenter = new PresenterLogin(_viewMock.Object, _helperMock.Object, _routerMock.Object);
        }

        [Test]
        public void TestNotNull()
        {
            _presenter = new PresenterLogin(_viewMock.Object, _helperMock.Object, _routerMock.Object);
            Assert.NotNull(_presenter);
        }


        [Test]
        public void GoToChatAny()
        {
            _routerMock.Setup(f => f.GoToChat(It.IsAny<string>()));
            _presenter = new PresenterLogin(_viewMock.Object, _helperMock.Object, _routerMock.Object);
            _presenter.GoToChat(It.IsAny<string>());
            _routerMock.Verify(f => f.GoToChat(It.IsAny<string>()));
        }



        [TestCase("-1", TestName = "GoToChatNotAny: ID = -1")]
        [TestCase("0",TestName = "GoToChatNotAny:   ID = 0")]
        [TestCase("1", TestName = "GoToChatNotAny: ID = 1")]
        [TestCase("2", TestName = "GoToChatNotAny: ID = 2")]
        [TestCase("3", TestName = "GoToChatNotAny: ID = 3")]
        [TestCase("4", TestName = "GoToChatNotAny: ID = 4")]
        public void GoToChatNotAnyTest(string id)
        {
            _routerMock.Setup(f => f.GoToChat(It.IsAny<string>()));
            _presenter = new PresenterLogin(_viewMock.Object, _helperMock.Object, _routerMock.Object);
            _presenter.GoToChat(id);
            _routerMock.Verify(f => f.GoToChat(id));
        }



    }
}
