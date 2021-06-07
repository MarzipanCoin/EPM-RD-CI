using System;
using System.Collections.Generic;
using System.Text;

namespace RD_XT_NET_WEB_CI.Classes
{
    public class Calculater : ICalculater<int>
    {
        public int Difference(int firstElem, int secondElem)
        {
            return firstElem - secondElem;
        }

        public int Summ(int firstElem, int secondElem)
        {
            return firstElem + secondElem;
        }
    }
}
