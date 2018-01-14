using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestesCsharp
{
    
    public class MaiorMenor
    {
        private double maior = Double.MinValue;
        private double menor = Double.MaxValue;
        private double media = 0;
        private List<double> top3 = new List<double>();

        public double Maior { get { return maior; } }
        public double Menor { get { return menor; } }
        public double Media { get { return media; } }
        public List<double> Top3 { get { return top3; } }

        public void valores(List<double> valores)
        {
            foreach (var valor in valores)
            {
                if (maior < valor)
                {
                    maior = valor;
                }
                if (menor > valor)
                {
                    menor = valor;
                }
            }

        }

        public void mediaValores(List<double> valores)
        {
            media = valores.Average();
        }

        public void TopValoresLista(List<double> valores)
        {
            var lista = new List<double>(valores.OrderByDescending(valor => valor));
            this.top3 = lista.GetRange(0, (valores.Count < 3 ? valores.Count : 3));
        }





    }
}
