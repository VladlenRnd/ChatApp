using Portable.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Portable.MainViper.Interface
{
    public interface IPresenterLogin
    {
        event Action<string,string> OnSingIn;

        event Action OnSingUp;
        IRouter Router { set; }

        ILangHelper _locales { set; }

        void GoToChat(int id);

    }
}
