using Portable.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace Portable.NewsViper.Interface
{
    public  interface IViewNews
    {
        event Action<string> ClickFindBtn;

        void UpdateData(News list);
    }
}
