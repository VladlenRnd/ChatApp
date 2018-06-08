using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Portable.NewsViper.Interface;

namespace Chat.Android.Routers
{
    public class RouterNews : IRouterNews
    {
        Context _ct;

        public RouterNews(Context ct)
        {
            _ct = ct;
        }

        public void GoToDetailNews(INewsEntity entity)
        {
            throw new NotImplementedException();
        }
    }
}