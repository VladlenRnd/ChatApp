using System;
using System.Collections.Generic;
using System.Text;

namespace Portable.Interface
{
    public interface ILangHelper 
    {
        string GetLngLoginTxt(string locale);
        string GetLngPassTxt(string locale);
        string GetLngBtnInTxt(string locale);
        string GetLngBtnUpTxt(string locale);
        string GetLngLanguageTxt(string locale);
    }
}
