using System;
using System.Collections.Generic;
using System.Text;

namespace Portable.NewsViper.Interface
{
    public interface IRouterNews
    {
        void GoToDetailNews(INewsEntity entity);
    }
}
