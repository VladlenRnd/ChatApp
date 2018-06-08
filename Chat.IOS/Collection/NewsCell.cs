using System;
using System.Diagnostics.Contracts;
using Chat.IOS.Routers;
using Foundation;
using Portable.Data;
using Portable.Interface;
using Portable.MainViper.Interactor;
using Portable.NewsViper.Interactor;
using Portable.NewsViper.Interface;
using Portable.NewsViper.Presenter;
using UIKit;

namespace Chat.IOS.Collection
{
    public partial class NewsCell : UICollectionViewCell, ISetDataToView,IViewNewsCard
    {
        public static readonly NSString Key = new NSString("NewsCell");
        public static readonly UINib Nib;


        private IInteractorNews _interactor;
        private IPresenterNews _presenter;
        private IRouterNews _router;

        static NewsCell()
        {
            Nib = UINib.FromName("NewsCell", NSBundle.MainBundle);
        }

        protected NewsCell(IntPtr handle) : base(handle)
        {
            // Note: this .ctor should not contain any initialization logic.
        }

        public void InitViper(NewsList _data,IViewNews view, UINavigationController nav)
        {
            _router = new RouterNews(nav);
            _presenter = new PresenterNews(this, view, _router);
            _interactor = new InteractorNews(_presenter, _data);

        }


        public void SetData(int position)
        {
            _interactor.SetData(position);
        }

        public void SetImageNews(string url)
        {
            UIImage img = GetImgFromFromUrl(url);
            _img.Image = img;
        }

        public void SetTimeNews(string data)
        {

        }

        public void SetTitleNews(string title)
        {
            _txtName.Text = title;
        }
        public static UIImage GetImgFromFromUrl(string uri)
        {
            Contract.Ensures(Contract.Result<UIImage>() != null);
            try
            {
                using (var url = new NSUrl(uri))
                using (var data = NSData.FromUrl(url))
                    return UIImage.LoadFromData(data);
            }
            catch (Exception e)
            {
                return new UIImage();
            }

        }

    }
}
