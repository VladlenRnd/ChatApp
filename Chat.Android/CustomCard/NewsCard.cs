using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Util;
using Android.Views;
using Android.Widget;
using Portable.NewsViper.Interface;

namespace Chat.Android.CustomCard
{
    [Register("CustomCard.CardViewControl")]
    public class NewsCard : RelativeLayout, IViewNewsCard
    {
        public NewsCard(Context context) : base(context)
        {
        }

        public NewsCard(Context context, IAttributeSet attrs) : base(context, attrs)
        {
        }

        public NewsCard(Context context, IAttributeSet attrs, int defStyleAttr) : base(context, attrs, defStyleAttr)
        {
        }

        public NewsCard(Context context, IAttributeSet attrs, int defStyleAttr, int defStyleRes) : base(context, attrs, defStyleAttr, defStyleRes)
        {
        }

        protected NewsCard(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
        {
        }

        public void SetTimeNews(string data)
        {
            throw new NotImplementedException();
        }

        public void SetImageNews(string url)
        {
            throw new NotImplementedException();
        }

        public void SetTitleNews(string title)
        {
            throw new NotImplementedException();
        }
    }
}