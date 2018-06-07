using Portable.Enum;
using Portable.Interface;
using Portable.MainViper.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Portable.MainViper.Interactor
{
    public class InteractorLogin : IInteractorLogin
    {
        public IPresenterLogin Presenter { private set;  get; }

        private IValidater _validater;

        public InteractorLogin(IValidater valid, IPresenterLogin presenter)
        {
            _validater = valid;
            Presenter = presenter;
            Presenter.OnSingIn += Presenter_OnSingIn;
        }


        private void Presenter_OnSingIn(string login, string pass)
        {
            var validateCodeLogin = _validater.ValidateLogin(login);

            switch (validateCodeLogin)
            {
                case CodeValidate.OK:  break;
                case CodeValidate.EmptyField: Presenter.ValidateError(validateCodeLogin); break;
                case CodeValidate.OverflowMaxLogin: Presenter.ValidateError(validateCodeLogin); break;
                case CodeValidate.OverflowMinLogin: Presenter.ValidateError(validateCodeLogin); break;
                case CodeValidate.UnresolvedСharacters: Presenter.ValidateError(validateCodeLogin); break;
                case CodeValidate.None: Presenter.ValidateError(validateCodeLogin); break;
                default: break;
            }

            if (validateCodeLogin != CodeValidate.OK) return;

            var validateCodePass = _validater.ValidatePassword(pass);


            switch (validateCodePass)
            {
                case CodeValidate.OK: break;
                case CodeValidate.EmptyField: Presenter.ValidateError(validateCodePass); break;
                case CodeValidate.OverflowMaxPass: Presenter.ValidateError(validateCodePass); break;
                case CodeValidate.OverflowMinPass: Presenter.ValidateError(validateCodePass); break;
                case CodeValidate.UnresolvedСharacters: Presenter.ValidateError(validateCodePass); break;
                case CodeValidate.None: break;
                default: break;
            }

            if (validateCodePass != CodeValidate.OK) return;

            var authCode = GetAccess(login, pass);

            switch (authCode)
            {
                case AuthResponse.None: break;
                case AuthResponse.AccessError: Presenter.AuthError(authCode); break;
                case AuthResponse.Success: Presenter.GoToChat("0"); break;
                default: break;
            }

        }

        private AuthResponse GetAccess(string login, string pass)
        {
            if (login == "admin" && pass == "admin12345")
                return AuthResponse.Success;
            else
                return AuthResponse.AccessError;
        }
    }
}
