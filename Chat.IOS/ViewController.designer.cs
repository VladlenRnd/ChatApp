// WARNING
//
// This file has been generated automatically by Visual Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;

namespace Chat.IOS
{
    [Register ("ViewController")]
    partial class ViewController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton _btnSignIn { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton _btnSignUp { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UISwitch _btnSwitch { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField _editLogin { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField _editPass { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel _txtError { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel _txtLang { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel _txtLogin { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel _txtPass { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (_btnSignIn != null) {
                _btnSignIn.Dispose ();
                _btnSignIn = null;
            }

            if (_btnSignUp != null) {
                _btnSignUp.Dispose ();
                _btnSignUp = null;
            }

            if (_btnSwitch != null) {
                _btnSwitch.Dispose ();
                _btnSwitch = null;
            }

            if (_editLogin != null) {
                _editLogin.Dispose ();
                _editLogin = null;
            }

            if (_editPass != null) {
                _editPass.Dispose ();
                _editPass = null;
            }

            if (_txtError != null) {
                _txtError.Dispose ();
                _txtError = null;
            }

            if (_txtLang != null) {
                _txtLang.Dispose ();
                _txtLang = null;
            }

            if (_txtLogin != null) {
                _txtLogin.Dispose ();
                _txtLogin = null;
            }

            if (_txtPass != null) {
                _txtPass.Dispose ();
                _txtPass = null;
            }
        }
    }
}