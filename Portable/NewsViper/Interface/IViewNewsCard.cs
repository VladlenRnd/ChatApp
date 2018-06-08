using System;
using System.Collections.Generic;
using System.Text;

namespace Portable.NewsViper.Interface
{
    public interface IViewNewsCard
    {
        void SetTitleNews(string title);
        void SetImageNews(string url);
        void SetTimeNews(string data);
    }
}
