
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestesCsharp
{
    public class AnoBissexto
    {
        public bool EhBissexto(int ano)
        {

            if (ano % 400 == 0) return true;

            else if (ano % 100 == 0) return false;

            else if (ano % 4 == 0) return true;

            return false;

        }
    }
}
