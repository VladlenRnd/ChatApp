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

        private NewsList _user;
        private IViewNews _mainView;

        public RecuclerViewAdapter(IViewNews view)
        {
            _user = new NewsList();
            _mainView = view;

        }


        public override int ItemCount => _user.GetCountNews() + 1;

        public override void OnBindViewHolder(RecyclerView.ViewHolder holder, int position)
        {
            if (holder is ISetDataToView vh)
            {
                vh.SetData(position);
            }
        }

        public override RecyclerView.ViewHolder OnCreateViewHolder(ViewGroup parent, int viewType)
        {
            View itemView = null;
            RecyclerView.ViewHolder vh;


                    itemView = LayoutInflater.From(parent.Context).Inflate(Resource.Layout.NewsCard, parent, false);
                    vh = new ViewHolder(itemView, _mainView, parent.Context);



            return vh;
        }
    }
}