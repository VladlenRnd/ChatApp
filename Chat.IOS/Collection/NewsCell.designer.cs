// WARNING
//
// This file has been generated automatically by Visual Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;

namespace Chat.IOS.Collection
{
    [Register ("NewsCell")]
    partial class NewsCell
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIImageView _img { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel _txtName { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (_img != null) {
                _img.Dispose ();
                _img = null;
            }

            if (_txtName != null) {
                _txtName.Dispose ();
                _txtName = null;
            }
        }
    }
}