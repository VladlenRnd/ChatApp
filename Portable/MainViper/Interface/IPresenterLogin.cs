using Portable.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Portable.MainViper.Interface
{
    public interface IPresenterLogin : IRouter
    {
        event Action OnSingIn;

        event Action OnSingUp;
        IRouter Router { get; }

        string GetLogin();
        string GetPass();
    }
}
