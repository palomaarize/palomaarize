using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using Calculo;

namespace Aliquota.Domain.Test
{
    public class Testes
    {
        [Fact]
        public void Validacao()
        {

            Login user = new Login()
            {
                Nome = "paloma",
                Senha = 1234,
            };

            Assert.Contains("paloma", user.Nome);
            Assert.Equal(1234, user.Senha);




            //if ((user.Nome == "paloma") & (user.Senha == 1234))
            //{
            //    var validado = true;
            //}




        }

    }
}
