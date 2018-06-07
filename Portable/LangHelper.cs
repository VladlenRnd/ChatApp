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
            if (SetLocale(locale))
            {
                return "LblLogin".Translate();
            }
            return null;
        }

        public string GetLngPassTxt(string locale)
        {
            if (SetLocale(locale))
            {
                return "LblPass".Translate();
            }
            return null;
        }

        public string GetLngBtnInTxt(string locale)
        {
            if (SetLocale(locale))
            {
                return "btnSignIn".Translate();
            }
            return null;
        }

        public string GetLngBtnUpTxt(string locale)
        {
            if (SetLocale(locale))
            {
                return "btnSignOut".Translate();
            }
            return null;
        }

        public string GetLngLanguageTxt(string locale)
        {
            if (SetLocale(locale))
            {
                return "lblLanguage".Translate();
            }
            return null;
        }


        private bool SetLocale(string locale)
        {
            bool res = false;

            if (locale == null)
                throw new ArgumentNullException("Локаль не может быть null");


            if (locale == "rus" || locale == "en_s")
            {
                I18N.Current
                       .SetFallbackLocale(locale)
                       .Init(GetType().GetTypeInfo().Assembly);
                res = true;
            }
            return res;

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
