using Portable.Enum;
using System;
using System.Collections.Generic;
using System.Text;

namespace Portable.MainViper.Interface
{
    public interface ILoginView
    {
        event Action OnSingIn;

        event Action OnSingUp;

        event Action<LanguageApp> ChangeLang;

        string GetLogin();
        string GetPass();
    }
}
