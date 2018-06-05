﻿using System;
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
        private Mock<IRouter> _router;
        private Mock<ILoginView> _view;

        [SetUp]
        public void Setup()
        {
            _view = new Mock<ILoginView>(MockBehavior.Strict);
            _router = new Mock<IRouter>(MockBehavior.Strict);
            _presenter = new PresenterLogin(_view.Object);
        }

        [Test]
        public void TestNotNull()
        {
            _presenter = new PresenterLogin(_view.Object);
            Assert.NotNull(_presenter);
        }


        [Test]
        public void GoToChatAny()
        {
            _router.Setup(f => f.GoToChat(It.IsAny<int>()));
            _presenter = new PresenterLogin(_view.Object);
            _presenter.Router = _router.Object;
            _presenter.GoToChat(It.IsAny<int>());
            _router.Verify(f => f.GoToChat(It.IsAny<int>()));
        }



        [TestCase(-1, TestName = "GoToChatNotAny: ID = -1")]
        [TestCase(0,TestName = "GoToChatNotAny:   ID = 0")]
        [TestCase(1, TestName = "GoToChatNotAny: ID = 1")]
        [TestCase(2, TestName = "GoToChatNotAny: ID = 2")]
        [TestCase(3, TestName = "GoToChatNotAny: ID = 3")]
        [TestCase(4, TestName = "GoToChatNotAny: ID = 4")]
        public void GoToChatNotAnyTest(int id)
        {
            _router.Setup(f => f.GoToChat(It.IsAny<int>()));
            _presenter = new PresenterLogin(_view.Object);
            _presenter.Router = _router.Object;
            _presenter.GoToChat(id);
            _router.Verify(f => f.GoToChat(id));
        }



    }
}
