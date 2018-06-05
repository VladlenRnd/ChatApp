using System;
using NUnit.Framework;
using Portable.MainViper.Interface;
using Portable.MainViper.Presenter;

namespace Tests.MainLogin
{
    [TestFixture]
    public class PresenterTest
    {

        private IPresenterLogin _presenter;

        [SetUp]
        public void Setup()
        {
            _presenter = new PresenterLogin();
        }

        [Test]
        public void RouterNotNull()
        {
            Assert.IsNotNull(_presenter.Router);
        }


        [Test]
        public void GetLoginTest()
        {
            Assert.IsNotNull(_presenter.GetLogin());
        }

        [Test]
        public void GetPassTest()
        {
            Assert.IsNotNull(_presenter.GetPass());
        }

    }
}
