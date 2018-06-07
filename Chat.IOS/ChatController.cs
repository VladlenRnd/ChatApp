using Foundation;
using System;
using UIKit;

namespace Chat.IOS
{
    public partial class ChatController : UIViewController
    {
        public string Id;
        public ChatController (IntPtr handle) : base (handle)
        {
        }
    }
}