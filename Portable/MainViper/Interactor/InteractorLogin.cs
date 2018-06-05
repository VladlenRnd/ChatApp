using Portable.Enum;
using Portable.MainViper.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Portable.MainViper.Interactor
{
    public class InteractorLogin : IInteractorLogin
    {
        public IPresenterLogin _presenter => throw new NotImplementedException();

        public AuthResponse SetLoginData(string login, string pass)
        {
            throw new NotImplementedException();
        }
    }
}
