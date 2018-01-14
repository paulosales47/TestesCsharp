using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace TestesCsharp
{
    [TestFixture]
    public class PalindromoTest
    {
        [Test]
        public void testaFrasePalimdromo()
        {
            var listaString = new List<string>();
            bool fraseValida = false;

            listaString.Add("socorram me subi no onibus em marrocos");
            listaString.Add("anotaram a data da maratona");
            listaString.Add("arara");
            listaString.Add("a");

            Palindromo palindromo = new Palindromo();

            listaString.ForEach(item =>
            {
                fraseValida =  palindromo.EhPalindromo(item);
            });

            Assert.IsTrue(fraseValida);
        }

    }
}
