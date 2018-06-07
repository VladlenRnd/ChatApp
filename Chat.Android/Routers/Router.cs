using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Portable.Interface;

namespace Chat.Android.Routers
{
    public class Router : IRouter
    {
        private Context _context;

        public Router(Context ct)
        {
            _context = ct;
        }

        public void GoToChat(string id)
        {
            Intent intent = new Intent(_context, typeof(ChatActivity));
            intent.PutExtra("PersonId", id);
            intent.AddFlags(ActivityFlags.NewTask);
            _context.StartActivity(intent);
        }

        public void GoToReg()
        {
            Intent intent = new Intent(_context, typeof(RegistrationActivity));
            intent.AddFlags(ActivityFlags.NewTask);
            _context.StartActivity(intent);
        }
    }
}