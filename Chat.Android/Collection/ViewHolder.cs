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
using Chat.Android.Routers;
using Portable.Data;
using Portable.Interface;
using Portable.NewsViper.Interactor;
using Portable.NewsViper.Interface;
using Portable.NewsViper.Presenter;

namespace Chat.Android.Collection
{
    public class ViewHolder : RecyclerView.ViewHolder , ISetDataToView
    {

        private IViewNewsCard cardViewControl;

        private IInteractorNews _interactor;
        private IPresenterNews _presenter;
        private IRouterNews _router;

        public ViewHolder(View itemView,IViewNews mainViews, Context ct) : base(itemView)
        {
            cardViewControl = itemView as IViewNewsCard;
            _router = new RouterNews(ct);

            _presenter = new PresenterNews(cardViewControl, mainViews, _router);
 
            _interactor = new InteractorNews(_presenter);
        }

        public void SetData(int position)
        {
            _interactor.SetData(position);
        }
    }
}