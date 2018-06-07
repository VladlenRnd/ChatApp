using Portable.Enum;
using Portable.Interface;
using Portable.MainViper.Interface;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace Portable.MainViper.Presenter
{
    public class PresenterLogin : IPresenterLogin
    {

        public event Action<string,string> OnSingIn;

        private ILoginView _view;
        private IRouter _router;
        private ILangHelper _locales;
        private string language;


        public PresenterLogin(ILoginView view,ILangHelper helper, IRouter router,string localeDefault)
        {
            _view = view;
            _router = router;
            _locales = helper;
             language = localeDefault;

            _view.ChangeLangAct += _view_ChangeLangAct;
            _view.OnClickSingIn += _view_OnClickSingIn;
            _view.OnClickSingUp += _view_OnClickSingUp;
        }

        private void _view_OnClickSingUp()
        {
            _router.GoToReg();
        }

        private void _view_OnClickSingIn(string login, string pass)
        {
            OnSingIn?.Invoke(login, pass);
        }

        private void _view_ChangeLangAct(bool lng)
        {
           
            if (lng)
            {
                 language = "rus";
                _view.SetLocalLogin(_locales.GetLngLoginTxt(language));
                _view.SetLocalPass(_locales.GetLngPassTxt(language));
                _view.SetLocalInBtn(_locales.GetLngBtnInTxt(language));
                _view.SetLocalUpBtn(_locales.GetLngBtnUpTxt(language));
                _view.SetLocalLblLanguage(_locales.GetLngLanguageTxt(language));
            }
            else
            {
                 language = "en_s";
                _view.SetLocalLogin(_locales.GetLngLoginTxt(language));
                _view.SetLocalPass(_locales.GetLngPassTxt(language));
                _view.SetLocalInBtn(_locales.GetLngBtnInTxt(language));
                _view.SetLocalUpBtn(_locales.GetLngBtnUpTxt(language));
                _view.SetLocalLblLanguage(_locales.GetLngLanguageTxt(language));
            }
        }
        



        public void GoToChat(string id)
        {
            _view.SetError("");
            _router.GoToChat(id);
        }

        public void ValidateError(CodeValidate codeError)
        {
            _view.SetError(_locales.GetLngErrorValidateText(language, codeError));

        }

        public void AuthError(AuthResponse codeError)
        {
            _view.SetError(_locales.GetLngErrorAuthText(language, codeError));
        }
    }
    

}
