using I18NPortable;
using Portable.Interface;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace Portable
{
    public class LangHelper : ILangHelper
    {
        public LangHelper(string locale)
        {
            throw new NotImplementedException();

            I18N.Current
                    .SetFallbackLocale(locale)
                    .Init(GetType().GetTypeInfo().Assembly);
        }


        public string GetLngLoginTxt(string locale)
        {
            throw new NotImplementedException();
            SetLocale(locale);
            return "LblLogin".Translate();
        }

        public string GetLngPassTxt(string locale)
        {
            throw new NotImplementedException();
            SetLocale(locale);
            return "LblPass".Translate();
        }

        public string GetLngBtnInTxt(string locale)
        {
            throw new NotImplementedException();
            SetLocale(locale);
            return "btnSignIn".Translate();
        }

        public string GetLngBtnUpTxt(string locale)
        {
            throw new NotImplementedException();
            SetLocale(locale);
            return "btnSignOut".Translate();
        }

        public string GetLngLanguageTxt(string locale)
        {
            throw new NotImplementedException();
            SetLocale(locale);
            return "lblLanguage".Translate();
        }


        private void SetLocale(string locale)
        {
            throw new NotImplementedException();
            I18N.Current
                   .SetFallbackLocale(locale)
                   .Init(GetType().GetTypeInfo().Assembly);
        }

    }
}
