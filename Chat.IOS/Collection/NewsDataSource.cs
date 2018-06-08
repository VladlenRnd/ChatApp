using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Foundation;
using Portable.Data;
using Portable.NewsViper.Interface;
using UIKit;

namespace Chat.IOS.Collection
{
    public class NewsDataSource : UICollectionViewDataSource
    {

        private NewsList _data;
        private UINavigationController _nav;
        private IViewNews _view;


        public NewsDataSource(NewsList data, IViewNews view, UINavigationController nav)
        {
            _data = data;
            _nav = nav;
            _view = view;
        }


        public override UICollectionViewCell GetCell(UICollectionView collectionView, NSIndexPath indexPath)
        {
            var cell = (NewsCell)collectionView.DequeueReusableCell(NewsCell.Key, indexPath);
            cell.InitViper(_data, _view, _nav);
            cell.SetData((int)indexPath.Item);
            return cell;
        }

        public override nint GetItemsCount(UICollectionView collectionView, nint section)
        {
            return _data.GetCountNews();
        }
    }
}