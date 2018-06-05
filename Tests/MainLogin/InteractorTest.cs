using System;
using System.Reflection;
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
