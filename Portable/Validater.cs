using Portable.Enum;
using Portable.Interface;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Portable
{
    public class Validater : IValidater
    {
        public CodeValidate ValidateLogin(string login)
        {
            login = login.Trim();

            if (string.IsNullOrEmpty(login)) return CodeValidate.EmptyField;
            if (login.Length > 50) return CodeValidate.OverflowMaxLogin;

            var regex = @"^([\p{L}]{0,}[\p{L}0-9|`|'|−| |-]{0,}[\p{L}])$";

            var match = Regex.Match(login, regex, RegexOptions.IgnoreCase|RegexOptions.CultureInvariant);

            if (!match.Success)
            {
                return CodeValidate.UnresolvedСharacters;
            }
            else
            {
                return CodeValidate.OK;
            }

           

        }

        public CodeValidate ValidatePassword(string pass)
        {

            if (string.IsNullOrEmpty(pass)) return CodeValidate.EmptyField;
            if(pass.Length < 6) return CodeValidate.OverflowMinPass;
            if (pass.Length > 50) return CodeValidate.OverflowMaxPass;

            var regNumber = "\\D";
            var regLater = "\\d";

            if (Regex.Match(pass, regNumber, RegexOptions.IgnoreCase | RegexOptions.CultureInvariant).Success)
            {
                if (Regex.Match(pass, regLater, RegexOptions.IgnoreCase | RegexOptions.CultureInvariant).Success)
                {
                    return CodeValidate.OK;
                }
                else
                {
                    return CodeValidate.NoNumbers;
                }
            }
            else
            {
                return CodeValidate.NoLetter;
            }



        }
    }
}
