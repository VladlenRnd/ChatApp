using Portable.Enum;
using Portable.Interface;
using Portable.MainViper.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Portable.MainViper.Interactor
{
    public class InteractorLogin : IInteractorLogin
    {
        public IPresenterLogin _presenter { private get; set; }

        private IValidater _validater;

        public InteractorLogin(IValidater valid)
        {
            throw new NotImplementedException();
            //_validater = valid;
        }

        private AuthResponse GetAccess(string login, string pass)
        {
            throw new NotImplementedException();
        }
    }
}
