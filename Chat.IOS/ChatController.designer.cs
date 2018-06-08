// WARNING
//
// This file has been generated automatically by Visual Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;

namespace Chat.IOS
{
    [Register ("ChatController")]
    partial class ChatController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UICollectionView _collectionView { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField _editFind { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton _findBtn { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (_collectionView != null) {
                _collectionView.Dispose ();
                _collectionView = null;
            }

            if (_editFind != null) {
                _editFind.Dispose ();
                _editFind = null;
            }

            if (_findBtn != null) {
                _findBtn.Dispose ();
                _findBtn = null;
            }
        }
    }
}