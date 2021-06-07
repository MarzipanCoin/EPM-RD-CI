using System;
using System.Collections.Generic;
using System.Text;

namespace RD_XT_NET_WEB_CI.Classes
{
    public interface ICalculater<T>
    {
        T Summ(T firstElem, T secondElem);
        T Difference(T firstElem, T secondElem);
    }
}
