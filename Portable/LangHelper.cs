using I18NPortable;
using Portable.Enum;
using Portable.Interface;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace Portable
{
    public class LangHelper : ILangHelper
    {
      
        public string GetLngLoginTxt(string locale)
        {
            SetLocale(locale);
            return "LblLogin".Translate();
        }

        public string GetLngPassTxt(string locale)
        {
            SetLocale(locale);
            return "LblPass".Translate();
        }

        public string GetLngBtnInTxt(string locale)
        {
            SetLocale(locale);
            return "btnSignIn".Translate();
        }

        public string GetLngBtnUpTxt(string locale)
        {
            SetLocale(locale);
            return "btnSignOut".Translate();
        }

        public string GetLngLanguageTxt(string locale)
        {
            SetLocale(locale);
            return "lblLanguage".Translate();
        }


        private void SetLocale(string locale)
        {
            I18N.Current
                   .SetFallbackLocale(locale)
                   .Init(GetType().GetTypeInfo().Assembly);

        }

        public string GetLngErrorValidateText(string locale, CodeValidate code)
        {
            string res = null;
            SetLocale(locale);

            switch (code)
            {
                case CodeValidate.None:
                    break;
                case CodeValidate.OK:
                    break;
                case CodeValidate.EmptyField:
                    res = "EmptyFieldTxt".Translate();
                    break;
                case CodeValidate.UnresolvedСharacters:
                    res = "UnresolvedСharacters".Translate();
                    break;
                case CodeValidate.NoNumbers:
                    res = "NoNumberPass".Translate();
                    break;
                case CodeValidate.NoLetter:
                    res = "NoLetterPass".Translate();
                    break;
                case CodeValidate.OverflowMinPass:
                    res = "OverflowMinPass".Translate();
                    break;
                case CodeValidate.OverflowMaxPass:
                    res = "OverflowMaxPass".Translate();
                    break;
                case CodeValidate.OverflowMinLogin:
                    res = "OverflowMinLogin".Translate();
                    break;
                case CodeValidate.OverflowMaxLogin:
                    res = "OverflowMaxLogin".Translate();
                    break;

                default:
                    break;
            }


            return res;
        }

        public string GetLngErrorAuthText(string locale, AuthResponse code)
        {
            string res = null;
            SetLocale(locale);


            switch (code)
            {
                case AuthResponse.None:
                    break;
                case AuthResponse.AccessError:
                    res = "AccessError".Translate();
                    break;
                case AuthResponse.Success:
                    break;
                default:
                    break;
            }

            return res; 
        }
    }
}
