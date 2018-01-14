using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace TestesCsharp
{
    [TestFixture]
    public class MatematicaMalucaTest
    {
        [Test]
        public void MenorNumero()
        {
            int menorNumero = int.MinValue;

            MatematicaMaluca entidade = new MatematicaMaluca();

            var retorno = entidade.ContaMaluca(menorNumero);
            
            Assert.AreEqual(menorNumero * 2, retorno);
        }

        [Test]
        public void MaiorNumero()
        {
            int maiorNumero = int.MaxValue;

            MatematicaMaluca entidade = new MatematicaMaluca();

            var retorno = entidade.ContaMaluca(maiorNumero);
            
            Assert.AreEqual(maiorNumero * 4, retorno);

        }
        
        [Test]
        public void numeroQuinze()
        {
            
            MatematicaMaluca entidade = new MatematicaMaluca();

            var retorno = entidade.ContaMaluca(15);

            Assert.AreEqual(45, retorno);

        }

        [Test]
        public void numeroDez()
        {
            MatematicaMaluca entidade = new MatematicaMaluca();

            var retorno = entidade.ContaMaluca(10);

            Assert.AreEqual(20, retorno);
        }

        [Test]
        public void numeroTrinta()
        {
            MatematicaMaluca entidade = new MatematicaMaluca();

            var retorno = entidade.ContaMaluca(30);

            Assert.AreEqual(90, retorno);
        }

    }
}
