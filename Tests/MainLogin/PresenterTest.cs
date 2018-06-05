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

    }
}
