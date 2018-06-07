using Chat.IOS.Routers;
using Portable;
using Portable.Interface;
using Portable.MainViper.Interactor;
using Portable.MainViper.Interface;
using Portable.MainViper.Presenter;
using System;

using UIKit;

namespace Chat.IOS
{
    public partial class ViewController : UIViewController,ILoginView
    {
        public ViewController(IntPtr handle) : base(handle)
        {
        }

        public event Action<string, string> OnClickSingIn;
        public event Action OnClickSingUp;
        public event Action<bool> ChangeLangAct;


        private IPresenterLogin _presenter;
        private IInteractorLogin _interactor;
        private IRouter _router;
        private ILangHelper _langHelper;
        private IValidater _validater;


        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            _langHelper = new LangHelper();
            _validater = new Validater();
            _router = new Router(NavigationController);

            _presenter = new PresenterLogin(this, _langHelper, _router, "en_s");

            _interactor = new InteractorLogin(_validater, _presenter);



            _btnSignIn.TouchUpInside += _btnSignIn_TouchUpInside;
            _btnSignUp.TouchUpInside += _btnSignUp_TouchUpInside;
            _btnSwitch.TouchUpInside += _btnSwitch_TouchUpInside;

        }

        private void _btnSwitch_TouchUpInside(object sender, EventArgs e)
        {
            var btn = (UISwitch)sender;

            ChangeLangAct?.Invoke(btn.On);
        }

        private void _btnSignUp_TouchUpInside(object sender, EventArgs e)
        {
            OnClickSingUp?.Invoke();
        }

        private void _btnSignIn_TouchUpInside(object sender, EventArgs e)
        {
            OnClickSingIn?.Invoke(_editLogin.Text,_editPass.Text);
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }

        public void SetError(string text)
        {
            _txtError.Text = text;
        }

        public void SetLocalLogin(string text)
        {
            _txtLogin.Text = text;
        }

        public void SetLocalPass(string text)
        {
            _txtPass.Text = text;
        }

        public void SetLocalInBtn(string text)
        {
            _btnSignIn.SetTitle(text, UIControlState.Normal);
        }

        public void SetLocalUpBtn(string text)
        {
            _btnSignUp.SetTitle(text, UIControlState.Normal);
        }

        public void SetLocalLblLanguage(string text)
        {
            _txtLang.Text = text;
        }
    }
}