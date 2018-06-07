using Portable.Enum;
using Portable.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Portable.MainViper.Interface
{
    public interface IPresenterLogin
    {
        event Action<string,string> OnSingIn;

        void ValidateError(CodeValidate codeError);
        void AuthError(AuthResponse codeError);


        void GoToChat(string id);

    }
}
