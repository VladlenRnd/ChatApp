using Portable.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Portable.MainViper.Interface
{
    public interface IPresenterLogin : IRouter
    {
        event Action<string,string> OnSingIn;

        event Action OnSingUp;
        IRouter Router { set; }

    }
}
