using Portable.NewsViper.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Portable.NewsViper.Entity
{
    public class NewsEntity : INewsEntity
    {

        public string Title { get; }
        public string UrlImg { get; }
        public string Time { get; }


        public NewsEntity(string title, string image,string time)
        {
            Title = title;
            UrlImg = image;
            Time = time;
        }

    }
}
