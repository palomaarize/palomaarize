using System;
using System.Runtime.Serialization.Json;
using System.Text;

namespace Calculo
{
    public class Login
    {
        public string NickName;
        public string Senha;
 
        public Login(string nickname, string senha)
        {
            Senha = senha;
            NickName = nickname;

            nickname = String.Empty;
            if (!string.IsNullOrEmpty(nickname))
            {

            }

        }

    }

        
   
}
