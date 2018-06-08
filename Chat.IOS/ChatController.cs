using Chat.IOS.Collection;
using Foundation;
using Portable.Data;
using Portable.NewsViper.Interface;
using Portable.Repository;
using System;
using UIKit;

namespace Chat.IOS
{
    public partial class ChatController : UIViewController,IViewNews
    {
        public string Id;

        private RepositoryData _rep;
        public ChatController (IntPtr handle) : base (handle)
        {
        }

        public event Action<string> ClickFindBtn;

        public void LoadSpiner()
        {
            //throw new NotImplementedException();
        }

        public void UpdateData(News list)
        {
            _collectionView.DataSource = new NewsDataSource(new NewsList(list), this, NavigationController);
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            _rep = new RepositoryData(this);
            _collectionView.RegisterNibForCell(NewsCell.Nib, NewsCell.Key);
            _collectionView.Delegate = new NewsCellDelegate();
            _collectionView.DataSource = new NewsDataSource(new NewsList(new News()),this,NavigationController);

            _findBtn.TouchUpInside += _findBtn_TouchUpInside;


        }

        private void _findBtn_TouchUpInside(object sender, EventArgs e)
        {
            ClickFindBtn?.Invoke(_editFind.Text);
        }
    }
}