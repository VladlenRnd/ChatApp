using Portable.Interface;
using Portable.MainViper.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Portable.MainViper.Presenter
{
    public class PresenterLogin : IPresenterLogin
    {
        public IRouter Router => throw new NotImplementedException();

        public event Action<string,string> OnSingIn;
        public event Action OnSingUp;

        public string GetLogin()
        {
            throw new NotImplementedException();
        }

        public string GetPass()
        {
            throw new NotImplementedException();
        }

        public void GoBack()
        {
            throw new NotImplementedException();
        }

        public void GoToChat()
        {
            throw new NotImplementedException();
        }
    }
}
