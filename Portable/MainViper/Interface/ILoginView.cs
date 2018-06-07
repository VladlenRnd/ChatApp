using Portable.Enum;
using System;
using System.Collections.Generic;
using System.Text;

namespace Portable.MainViper.Interface
{
    public interface ILoginView
    {
        event Action<string,string> OnClickSingIn;

        event Action OnClickSingUp;

        event Action<bool> ChangeLangAct;


        void SetError(string text);


        void SetLocalLogin(string text);
        void SetLocalPass(string text);
        void SetLocalInBtn(string text);
        void SetLocalUpBtn(string text);
        void SetLocalLblLanguage(string text);
    }
}
