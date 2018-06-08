using Portable.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace Portable.NewsViper.Interface
{
     public interface IPresenterNews
    {
        void SetData(INewsEntity entity);

        void UpdateData(News data);
    }
}
