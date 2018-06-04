using System;
using System.Collections.Generic;
using System.Text;

namespace Portable.MainViper.Interface
{
   public interface IInteractorLogin
    {
        IPresenterLogin _presenter { get; }

        string GetLogin();
        string GetPass();

    }
}
