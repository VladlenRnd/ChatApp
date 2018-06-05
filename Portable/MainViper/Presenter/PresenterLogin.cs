using I18NPortable;
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
        public IRouter Router { private get; set; }

        public event Action<string,string> OnSingIn;
        public event Action OnSingUp;


       // ILoginView _view;


        public PresenterLogin(ILoginView view)
        {
            throw new NotImplementedException();
           // _view = view;
           // _view.ChangeLangAct += _view_ChangeLangAct;
        }



        /*
        private void _view_ChangeLangAct(LanguageApp obj)
        {
            switch (obj)
            {
                case LanguageApp.ENG:
                    I18N.Current
                    .SetFallbackLocale("en_s")
                    .Init(GetType().GetTypeInfo().Assembly);
                    
                    _view.SetLocalLogin("LblLogin".Translate());
                    _view.SetLocalPass("LblPass".Translate());
                    _view.SetLocalInBtn("btnSignIn".Translate());
                    _view.SetLocalUpBtn("btnSignOut".Translate());
                    _view.SetLocalLblLanguage("lblLanguage".Translate());

                    break;
                case LanguageApp.RUS:

                    I18N.Current
                   .SetFallbackLocale("rus")
                   .Init(GetType().GetTypeInfo().Assembly);
                    
                    _view.SetLocalLogin("LblLogin".Translate());
                    _view.SetLocalPass("LblPass".Translate());
                    _view.SetLocalInBtn("btnSignIn".Translate());
                    _view.SetLocalUpBtn("btnSignOut".Translate());
                    _view.SetLocalLblLanguage("lblLanguage".Translate());

                    break;
                default:
                    break;
            }


        }
        */

        public string GetLogin()
        {
            throw new NotImplementedException();
        }

        public string GetPass()
        {
            throw new NotImplementedException();
        }

        public void GoBack()
        {
            throw new NotImplementedException();
        }

        public void GoToChat()
        {
            throw new NotImplementedException();
        }

        public void GoToChat(int id)
        {
            throw new NotImplementedException();
        }
    }
}
