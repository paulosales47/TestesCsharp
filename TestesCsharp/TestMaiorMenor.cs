using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace TestesCsharp
{
    [TestFixture]
    public class TestMaiorMenor
    {
        //TimeOut para o teste após passado o tempo limite configurado
        [Test, Timeout(25)]
        public void TesteMaiorMenorRandom()
        {
            var listaDouble = new List<double>();
            Random rd = new Random();

            for (int i = 0; i < 500000; i++)
            {
                listaDouble.Add(rd.NextDouble());
            }

            MaiorMenor entidade = new MaiorMenor();
            entidade.valores(listaDouble);

            Assert.AreEqual(listaDouble.Min(), entidade.Menor);
            Assert.AreEqual(listaDouble.Max(), entidade.Maior);

        }

        //MaxTime não cancela o teste apenas compara o tempo decorrido do teste com o tempo estabelecido, caso ultrapasse reporta erro
        [Test, MaxTime(30)]
        public void TesteMaiorMenorCrescente()
        {
            var listaDouble = new List<double>();
            Random rd = new Random();

            for (int i = 0; i < 500000; i++)
            {
                listaDouble.Add(rd.NextDouble() + i);
            }

            MaiorMenor entidade = new MaiorMenor();
            entidade.valores(listaDouble);

            Assert.AreEqual(listaDouble.Min(), entidade.Menor);
            Assert.AreEqual(listaDouble.Max(), entidade.Maior);

        }

        [Test]
        public void TesteMaiorMenorDecrescente()
        {
            var listaDouble = new List<double>();
            Random rd = new Random();

            for (int i = 0; i < 500000; i++)
            {
                listaDouble.Add(rd.NextDouble() - i);
            }

            MaiorMenor entidade = new MaiorMenor();
            entidade.valores(listaDouble);

            Assert.AreEqual(listaDouble.Min(), entidade.Menor);
            Assert.AreEqual(listaDouble.Max(), entidade.Maior);

        }
        
        [Test]
        public void TesteUnicoElemento()
        {
            var listaDouble = new List<double>() { 0 };
            
            MaiorMenor entidade = new MaiorMenor();
            entidade.valores(listaDouble);

            Assert.AreEqual(listaDouble.Min(), entidade.Menor);
            Assert.AreEqual(listaDouble.Max(), entidade.Maior);
        }

        [Test]
        public void TesteTop3()
        {
            var listaDouble = new List<double>() { 123.45, 456.32, 785.12, 658.45 };

            MaiorMenor entidade = new MaiorMenor();

            entidade.TopValoresLista(listaDouble);
            
            Assert.AreEqual(3, entidade.Top3.Count);
            Assert.AreEqual(listaDouble[2], entidade.Top3[0]);
            Assert.AreEqual(listaDouble[3], entidade.Top3[1]);
            Assert.AreEqual(listaDouble[1], entidade.Top3[2]);
            
        }

        [Test]
        public void TesteTop3UnicoElemento()
        {
            var listaDouble = new List<double>() { 123.45};

            MaiorMenor entidade = new MaiorMenor();

            entidade.TopValoresLista(listaDouble);
            
            Assert.AreEqual(1, entidade.Top3.Count);
            Assert.AreEqual(listaDouble[0], entidade.Top3[0]);


        }


    }
}
