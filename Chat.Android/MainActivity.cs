using Android.App;
using Android.Widget;
using Android.OS;
using Portable.MainViper.Interface;
using Portable.Enum;
using System;
using Portable.MainViper.Presenter;
using Portable;
using Portable.Interface;
using Chat.Android.Routers;
using Portable.MainViper.Interactor;

namespace Chat.Android
{
    [Activity(Label = "Chat.Android", MainLauncher = true, Icon = "@mipmap/icon")]
    public class MainActivity : Activity, ILoginView
    {
        public event Action<string,string> OnClickSingIn;
        public event Action OnClickSingUp;
        public event Action<bool> ChangeLangAct;

        private IPresenterLogin _presenter;
        private IInteractorLogin _interactor;
        private IRouter _router;
        private ILangHelper _langHelper;
        private IValidater _validater;


        public void SetLocalInBtn(string text)
        {
            var btn = FindViewById<Button>(Resource.Id.btnSignIn);
            btn.Text = text;
        }

        public void SetError(string text)
        {
            var txtV = FindViewById<TextView>(Resource.Id.textError);
            txtV.Text = text;
        }


        public void SetLocalLblLanguage(string text)
        {
            var txtV = FindViewById<TextView>(Resource.Id.txtLng);
            txtV.Text = text;
        }

        public void SetLocalLogin(string text)
        {
            var txtV = FindViewById<TextView>(Resource.Id.txtLogin);
            txtV.Text = text;
        }

        public void SetLocalPass(string text)
        {
            var txtV = FindViewById<TextView>(Resource.Id.txtPass);
            txtV.Text = text;
        }

        public void SetLocalUpBtn(string text)
        {
            var btn = FindViewById<Button>(Resource.Id.btnSignUp);
            btn.Text = text;
        }

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            _langHelper = new LangHelper();
            _validater = new Validater();
            _router = new Router(ApplicationContext);

            _presenter = new PresenterLogin(this, _langHelper, _router);

            _interactor = new InteractorLogin(_validater, _presenter);


            var btnCahngeLanguage = FindViewById<ToggleButton>(Resource.Id.btnCahngeLng);
            var btnSingIn =  FindViewById<ToggleButton>(Resource.Id.btnSignIn);
            var btnSingUp = FindViewById<ToggleButton>(Resource.Id.btnSignUp);

            btnCahngeLanguage.Click += ((s,e) => {

                var btn = (ToggleButton)s;
                ChangeLangAct?.Invoke(btn.Checked);
            });

            btnSingIn.Click += ((s, e) => {
                var LoginEdit = FindViewById<EditText>(Resource.Id.editLogin);
                var PassEdit = FindViewById<EditText>(Resource.Id.editPass);
                OnClickSingIn?.Invoke(LoginEdit.Text,PassEdit.Text);
            });

            btnSingUp.Click += ((s, e) =>
            {
                OnClickSingUp?.Invoke();
            });

            // Get our button from the layout resource,
            // and attach an event to it

        }
    }
}

