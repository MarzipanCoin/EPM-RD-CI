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
            if (length < 1 || width < 1)
            {
                return "One or all sides can't be less than 1";
            }

            var sb = new StringBuilder((length + 1) * (width + 1));
            FillFigure(length, width, sb);

            return sb.ToString();
        }

        public string GetSquare(int size)
        {
            if (size < 1)
            {
                return "Size can't be less than 1";
            }

            var sb = new StringBuilder((int)Math.Pow((size + 1), 2));
            FillFigure(size, size, sb);

            return sb.ToString();
        }

        public string GetStandardTriangle(int height)
        {
            throw new NotImplementedException();
        }

        private void FillFigure(int length, int width, StringBuilder sb)
        {
            if (length == 1 && width == 1)
            {
                sb.Append('*');

                return;
            }

            for (int i = 0; i < length; i++)
            {
                sb.Append('*');
                var point = ' ';
                FillLine(width, length, sb, i, point);

                sb.Append('*');
                sb.Append('\n');
            }
        }

        private void FillLine(int width, int length, StringBuilder sb, int i, char point)
        {
            if (i == 0 || i == length - 1)
            {
                point = '*';
            }

            for (int j = 1; j < width - 1; j++)
            {
                sb.Append(point);
            }
        }
    }
}
