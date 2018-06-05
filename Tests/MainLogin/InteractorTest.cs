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

        [TestCase("", CodeValidate.EmptyField, TestName = "ValidateLogin 1 Result EmptyField")]
        [TestCase(" ", CodeValidate.EmptyField, TestName = "ValidateLogin 2 Result EmptyField")]

        [TestCase("`", CodeValidate.UnresolvedСharacters, TestName = "ValidateLogin 1 Result UnresolvedСharacters")]
        [TestCase("`admin`", CodeValidate.UnresolvedСharacters, TestName = "ValidateLogin 2 Result UnresolvedСharacters")]

        [TestCase("Admin", CodeValidate.OK, TestName = "ValidateLogin 1 Result Ok")]
        [TestCase("admin", CodeValidate.OK, TestName = "ValidateLogin 2 Result Ok")]
        [TestCase(" admin", CodeValidate.OK, TestName = "ValidateLogin 3 Result Ok")]
        [TestCase("admin ", CodeValidate.OK, TestName = "ValidateLogin 4 Result Ok")]
        public void ValidateLoginTest(string login, CodeValidate exp)
        {
            MethodInfo methodInfo = typeof(InteractorLogin).GetMethod("ValidateLogin", BindingFlags.NonPublic | BindingFlags.Instance);
            var act = methodInfo.Invoke(_interactor, new object[] { login});
            Assert.AreEqual(exp, act);
        }





    }
}
