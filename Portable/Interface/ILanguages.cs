using System;
using System.Collections.Generic;
using System.Text;

namespace Portable.Interface
{
    public interface ILanguages
    {
         string LngLblLogin { get; set; }
         string LngLblPass { get; set; }
         string LngBtnSignIn { get; set; }
         string LngBtnSignUp { get; set; }

         string LngLblLanguage { get; set; }
    }
}
