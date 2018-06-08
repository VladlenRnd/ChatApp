using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;

using Android.App;
using Android.Content;
using Android.Graphics;
using Android.OS;
using Android.Runtime;
using Android.Util;
using Android.Views;
using Android.Widget;
using blocke.circleimageview;
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
            //throw new NotImplementedException();
        }

        public void SetImageNews(string url)
        {
            CircleImageView imageCircleImageView = FindViewById<CircleImageView>(Resource.Id.imageCard);
            imageCircleImageView.SetImageBitmap(GetImgByUrl(url));
        }

        public void SetTitleNews(string title)
        {
            var txt = FindViewById<TextView>(Resource.Id.textCard);
            txt.Text = title;
        }


        private Bitmap GetImgByUrl(string url)
        {
            Bitmap imageBitmap = null;
            using (var webClient = new WebClient())
            {
                var imageBytes = webClient.DownloadData(url);
                if (imageBytes != null && imageBytes.Length > 0)
                {
                    imageBitmap = BitmapFactory.DecodeByteArray(imageBytes, 0, imageBytes.Length);
                }
            }
            return imageBitmap;
        }

    }
}