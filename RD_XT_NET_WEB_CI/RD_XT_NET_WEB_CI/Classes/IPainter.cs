using System;
using System.Collections.Generic;
using System.Text;

namespace RD_XT_NET_WEB_CI.Classes
{
    public interface IPainter
    {
        string GetSquare(int size);
        string GetRectangle(int length, int width);
        string GetStandardTriangle(int height);
        string GetCornerTriangle(int height);
    }
}
