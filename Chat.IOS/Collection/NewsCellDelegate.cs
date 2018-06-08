using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CoreGraphics;
using Foundation;
using UIKit;

namespace Chat.IOS.Collection
{
    public class NewsCellDelegate : UICollectionViewDelegateFlowLayout
    {
        public NewsCellDelegate()
        {
        }

        public override CGSize GetSizeForItem(UICollectionView collectionView, UICollectionViewLayout layout, NSIndexPath indexPath)
        {
            return new CGSize(collectionView.Frame.Width, 75);
        }

        protected NewsCellDelegate(NSObjectFlag t) : base(t)
        {
        }
    }
}