using System;
using System.Collections.Generic;
using System.Text;

namespace RD_XT_NET_WEB_CI.Classes
{
    public class Painter : IPainter
    {
        public string GetCornerTriangle(int height)
        {

            throw new NotImplementedException();
        }

        public string GetRectangle(int length, int width)
        {
            throw new NotImplementedException();
        }

        public string GetSquare(int size)
        {
            var sb = new StringBuilder((int)Math.Pow((size+1), 2));


            for (int i = 0; i < size; i++)
            {
                sb.Append('*');
                var point = ' ';

                if (i == 0 || i == size - 1)
                {
                    point = '*';
                }

                for (int j = 1; j < size-1; j++)
                {
                    sb.Append(point);
                }

                sb.Append('*');
                sb.Append('\n');

            }
            
            return sb.ToString();
        }

        public string GetStandardTriangle(int height)
        {
            throw new NotImplementedException();
        }
    }
}
