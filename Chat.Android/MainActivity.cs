using Android.App;
using Android.Widget;
using Android.OS;
using Portable.MainViper.Interface;
using Portable.Enum;
using System;

namespace Chat.Android
{
    [Activity(Label = "Chat.Android", MainLauncher = true, Icon = "@mipmap/icon")]
    public class MainActivity : Activity, ILoginView
    {
        public event Action OnClickSingIn;
        public event Action OnClickSingUp;
        public event Action<LanguageApp> ChangeLangAct;

        public string GetLogin()
        {
            throw new NotImplementedException();
        }

        public string GetPass()
        {
            throw new NotImplementedException();
        }

        public void SetLocalInBtn(string text)
        {
            throw new NotImplementedException();
        }

        public void SetLocalLogin(string text)
        {
            throw new NotImplementedException();
        }

        public void SetLocalPass(string text)
        {
            throw new NotImplementedException();
        }

        public void SetLocalUpBtn(string text)
        {
            throw new NotImplementedException();
        }

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            // Get our button from the layout resource,
            // and attach an event to it
        
        }
    }
}

