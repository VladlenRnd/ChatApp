using Portable.Enum;
using System;
using System.Collections.Generic;
using System.Text;

namespace Portable.Interface
{
    public interface ILangHelper 
    {

        string GetLngErrorValidateText(string locale, CodeValidate code);
        string GetLngErrorAuthText(string locale, AuthResponse code);

        string GetLngLoginTxt(string locale);
        string GetLngPassTxt(string locale);
        string GetLngBtnInTxt(string locale);
        string GetLngBtnUpTxt(string locale);
        string GetLngLanguageTxt(string locale);
    }
}
