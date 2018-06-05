using Portable.Enum;
using System;
using System.Collections.Generic;
using System.Text;

namespace Portable.Interface
{
    public interface IValidater
    {
        CodeValidate ValidateLogin(string login);

        CodeValidate ValidatePassword(string pass);

    }
}
