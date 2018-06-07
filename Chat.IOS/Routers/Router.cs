using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Foundation;
using Portable.Interface;
using UIKit;

namespace Chat.IOS.Routers
{
    public class Router : IRouter
    {
        UINavigationController _nav;
        public Router(UINavigationController nav)
        {
            _nav = nav;
        }

        public void GoToChat(string id)
        {
            var dest = UIStoryboard.FromName("Main", NSBundle.MainBundle).InstantiateViewController("ChatController") as ChatController;
            //  var cell = _userColectionView.CellForItem(obj) as UserCell;
            dest.Id = id;
            _nav.PushViewController(dest, true);
        }

        public void GoToReg()
        {
            var dest = UIStoryboard.FromName("Main", NSBundle.MainBundle).InstantiateViewController("RegistrationController") as RegistrationController;
            //  var cell = _userColectionView.CellForItem(obj) as UserCell;
            _nav.PushViewController(dest, true);
        }
    }
}