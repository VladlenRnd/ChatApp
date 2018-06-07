using System;
using System.Collections.Generic;
using System.Text;

namespace Portable.Interface
{
    public interface IRouter
    {
        void GoToChat(string id);

        void GoToReg();
    }
}
