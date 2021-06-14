using System;
using System.Collections.Generic;
using System.Text;

namespace RD_XT_NET_WEB_CI.Classes
{
    public class Painter : IPainter
    {
        public string GetCornerTriangle(int height)
        {
            if (height < 1)
            {
                return "Height can't be less than 1";
            }

            var sb = new StringBuilder();
            for (int i = 0; i < height; i++)
            {
                FillLine(i + 3, x => true, sb, i);
                sb.Append('\n');
            }

            return sb.ToString();
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
            if (height < 1)
            {
                return "Height can't be less than 1";
            }

            var sb = new StringBuilder(GetNumberOfStarsInStandardTriangle(height));
            var countOfSpaces = height + 1;
            var countOfStars = 5;

            for (int i = 0; i < height; i++)
            {
                FillLine(countOfSpaces, x => false, sb, i);

                if (i == 0)
                {
                    sb.Append('*');
                    sb.Append('\n');
                }
                else
                {
                    FillLine(countOfStars, x => true, sb, i);
                    sb.Append('\n');

                    countOfStars += 2;
                }

                countOfSpaces--;
            }

            return sb.ToString();
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

                FillLine(width, (x => x == 0 || x == length - 1), sb, i);

                sb.Append('*');
                sb.Append('\n');
            }
        }

        private void FillLine(int width, Predicate<int> fillerPredicate, StringBuilder sb, int i)
        {
            var point = ' ';
            if (fillerPredicate(i))
            {
                point = '*';
            }

            for (int j = 1; j < width - 1; j++)
            {
                sb.Append(point);
            }
        }

        private int GetNumberOfStarsInStandardTriangle(int height)
        {
            var res = 1;

            for (int i = 1; i < height; i++)
            {
                res += 2;
            }

            return res;
        }
    }
}
