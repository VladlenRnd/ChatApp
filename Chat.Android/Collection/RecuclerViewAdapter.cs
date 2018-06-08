using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Support.V7.Widget;
using Android.Views;
using Android.Widget;
using Portable.Data;
using Portable.Interface;
using Portable.NewsViper.Interface;

namespace Chat.Android.Collection
{
    public class RecuclerViewAdapter : RecyclerView.Adapter
    {

        private NewsList _news;
        private IViewNews _mainView;

        public RecuclerViewAdapter(IViewNews view, NewsList data)
        {
            _news = data;
            _mainView = view;
        }


        public void UpdateList(NewsList data)
        {
            _news = data;
            NotifyDataSetChanged();
        }


        public override int ItemCount => _news.GetCountNews();

        public override void OnBindViewHolder(RecyclerView.ViewHolder holder, int position)
        {
            if (holder is ISetDataToView vh)
            {
                vh.SetData(position);
            }
        }

        public override int GetItemViewType(int position)
        {
            int res = -1;

            if (position % 2 == 0)
                res = 0;
            else
                res = 1;

            return res;
        }
        public override RecyclerView.ViewHolder OnCreateViewHolder(ViewGroup parent, int viewType)
        {
            View itemView = null;
            RecyclerView.ViewHolder vh;

                switch (viewType)
                {
                    case 0:
                        itemView = LayoutInflater.From(parent.Context).Inflate(Resource.Layout.NewsCard, parent, false);
                        vh = new ViewHolder(itemView, _mainView, _news, parent.Context);
                        break;
                    case 1:
                        itemView = LayoutInflater.From(parent.Context).Inflate(Resource.Layout.NewsCardRevers, parent, false);
                        vh = new ViewHolder(itemView, _mainView, _news, parent.Context);
                        break;
                    default:
                        throw new ArgumentException("viewType wrong");
                }
            
            return vh;
        }
    }
}