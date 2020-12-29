using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace MasterMind
{
    public class Color
    {
        public static readonly Color Red = new Color('r');
        public static readonly Color Blue = new Color('b');
        public static readonly Color Yellow = new Color('y');
        public static readonly Color Green = new Color('g');
        public static readonly Color Orange = new Color('o');
        public static readonly Color Purple = new Color('p');
        public static readonly Color Nullcolor = new Color(' ');

        private char _initial;

        private static IEnumerable<Color> Values
        {
            get
            {
                yield return Red;
                yield return Blue;
                yield return Yellow;
                yield return Green;
                yield return Orange;
                yield return Purple;
                yield return Nullcolor;
            }
        }

        private Color(char initial)
        {
            this._initial = initial;
        }

        public static String GetInitials()
        {
            String result = "";
            for (int i = 0; i < Values.Count(); i++)
            {
                result += Color.Get(i)._initial;
            }
            return result;
        }

        public static Color GetInstance(char character)
        {
            for (int i = 0; i < Color.Length(); i++)
            {
                if (Color.Get(i)._initial == character)
                {
                    return Color.Get(i);
                }
            }
            return Color.Nullcolor;
        }

        public static int Length()
        {
            return Values.Count() - 1;
        }

        public static Color Get(int index)
        {
            return Values.ToList()[index];
        }

        public void Write()
        {
            Debug.Assert(this != Color.Nullcolor);
            Consola.GetInstance().Write(_initial);
        }

        public Boolean IsNull()
        {
            return this == Color.Nullcolor;
        }
    }
}
