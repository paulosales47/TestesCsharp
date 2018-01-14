using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace TestesCsharp
{
    [TestFixture]
    public class AnoBissextoTest
    {
        [Test]
        public void VerificaAnoBissexto()
        {
            AnoBissexto anoBissexto = new AnoBissexto();

            for (int i = 0; i < 4000; i += 4)
            {
                if ((i % 100 == 0) && (i % 400 != 0))
                    Assert.AreEqual(false, anoBissexto.EhBissexto(i));
                else
                    Assert.AreEqual(true, anoBissexto.EhBissexto(i));
            }

            for (int i = 0; i < 100000; i += 100)
            {
                if(i % 400 != 0)
                    Assert.AreEqual(false, anoBissexto.EhBissexto(i));
            }

            for (int i = 0; i < 400000; i += 400)
            {
                 Assert.AreEqual(true, anoBissexto.EhBissexto(i));
            }
            
        }


    }
}
