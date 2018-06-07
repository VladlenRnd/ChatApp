using System;
using System.Collections.Generic;
using System.Text;

namespace Portable.Enum
{
    public enum CodeValidate
    {
        None = -1,
        OK = 1,
        EmptyField,
        UnresolvedСharacters,
        NoNumbers,
        NoLetter,
        OverflowMaxLogin,
        OverflowMinLogin,
        OverflowMaxPass,
        OverflowMinPass,
    }
}
