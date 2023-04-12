using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Proj1
{
    public class Fatorial
    {
        public Fatorial()
        {

        }
        public static int calculaFatorial(int n)
        {
            int result = 1;
            for (int i = 2; i <= n; i++)
            {
                result = result * i;
            }
            return result;
        }

    }
}