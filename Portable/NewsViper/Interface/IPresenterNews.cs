using System;
using System.Collections.Generic;
using System.Text;

namespace Portable.NewsViper.Interface
{
     public interface IPresenterNews
    {
        event Action<string> ClickFindBtn;
        void SetData(INewsEntity entity);
    }
}
