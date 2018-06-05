using Portable.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Portable.Language
{
    public class Languages : ILanguages
    {
        public string LngLblLogin { get; set; }
        public string LngLblPass { get; set; }
        public string LngBtnSignIn { get; set; }
        public string LngBtnSignUp { get; set; }

        public string LngLblLanguage { get; set; }
    }
}
