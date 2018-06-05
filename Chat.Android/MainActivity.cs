using Android.App;
using Android.Widget;
using Android.OS;
using Portable.MainViper.Interface;
using Portable.Enum;
using System;
using Portable.MainViper.Presenter;

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
            var btn = FindViewById<Button>(Resource.Id.btnSignIn);
            btn.Text = text;
        }

        public void SetLocalLblLanguage(string text)
        {
            throw new NotImplementedException();
            var txtV = FindViewById<TextView>(Resource.Id.txtLng);
            txtV.Text = text;
        }

        public void SetLocalLogin(string text)
        {
            throw new NotImplementedException();
            var txtV = FindViewById<TextView>(Resource.Id.txtLogin);
            txtV.Text = text;
        }

        public void SetLocalPass(string text)
        {
            throw new NotImplementedException();
            var txtV = FindViewById<TextView>(Resource.Id.txtPass);
            txtV.Text = text;
        }

        public void SetLocalUpBtn(string text)
        {
            throw new NotImplementedException();
            var btn = FindViewById<Button>(Resource.Id.btnSignUp);
            btn.Text = text;
        }

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            /*
            var btn = FindViewById<ToggleButton>(Resource.Id.btnCahngeLng);

            btn.Click += ((s,e) => {

                var b = (ToggleButton)s;
                if (!b.Checked)
                ChangeLangAct?.Invoke(LanguageApp.ENG);
                else
                    ChangeLangAct?.Invoke(LanguageApp.RUS);

            });

             _f = new PresenterLogin(this);
             */

            // Get our button from the layout resource,
            // and attach an event to it

        }
    }
}

