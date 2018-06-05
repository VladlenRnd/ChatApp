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
        public IRouter Router { private get; set; }
        public ILangHelper _locales { private get; set; }

        public event Action<string,string> OnSingIn;
        public event Action OnSingUp;

        private ILoginView _view;


        public PresenterLogin(ILoginView view,ILangHelper helper)
        {
           // throw new NotImplementedException();
            _view = view;
            _view.ChangeLangAct += _view_ChangeLangAct;
            _locales = helper;
        }

        
        private void _view_ChangeLangAct(bool lng)
        {
            string ln;
            if (lng)
            {
                ln = "rus";
                _view.SetLocalLogin(_locales.GetLngLoginTxt(ln));
                _view.SetLocalPass(_locales.GetLngPassTxt(ln));
                _view.SetLocalInBtn(_locales.GetLngBtnInTxt(ln));
                _view.SetLocalUpBtn(_locales.GetLngBtnUpTxt(ln));
                _view.SetLocalLblLanguage(_locales.GetLngLanguageTxt(ln));
            }
            else
            {
                ln = "en_s";
                _view.SetLocalLogin(_locales.GetLngLoginTxt(ln));
                _view.SetLocalPass(_locales.GetLngPassTxt(ln));
                _view.SetLocalInBtn(_locales.GetLngBtnInTxt(ln));
                _view.SetLocalUpBtn(_locales.GetLngBtnUpTxt(ln));
                _view.SetLocalLblLanguage(_locales.GetLngLanguageTxt(ln));
            }
        }

        public void GoToChat(int id)
        {
            throw new NotImplementedException();
        }
    }
    

}
