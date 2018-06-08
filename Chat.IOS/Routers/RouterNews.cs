using Portable.NewsViper.Interface;
using System;
using System.Collections.Generic;
using System.Text;
using UIKit;

namespace Chat.IOS.Routers
{
    public class RouterNews : IRouterNews
    {
        private UINavigationController _nav;

        public RouterNews(UINavigationController nav)
        {
            _nav = nav;
        }
        public void GoToDetailNews(INewsEntity entity)
        {
            throw new NotImplementedException();
        }
    }
}
