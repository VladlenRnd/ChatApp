using Portable.MainViper.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Portable.MainViper.Entity
{
    public class EntityLoginData : IEntityLoginData
    {
        public string Login { get; }
        public string Pass { get; }

        public EntityLoginData(string login,string pass)
        {
            Login = login;
            Pass = pass;
        }

        public override bool Equals(object obj)
        {
            var data = obj as EntityLoginData;
            return data != null &&
                   Login == data.Login &&
                   Pass == data.Pass;
        }

        public override int GetHashCode()
        {
            var hashCode = 1266490330;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Login);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Pass);
            return hashCode;
        }
    }
}
