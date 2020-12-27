using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace MasterMind
{
    public class Color
    {
        public static readonly Color RED = new Color('r');
        public static readonly Color BLUE = new Color('b');
        public static readonly Color YELLOW = new Color('y');
        public static readonly Color GREEN = new Color('g');
        public static readonly Color ORANGE = new Color('o');
        public static readonly Color PURPLE = new Color('p');
        public static readonly Color NULLCOLOR = new Color(' ');

        private char _initial;

        private static IEnumerable<Color> Values
        {
            get
            {
                yield return RED;
                yield return BLUE;
                yield return YELLOW;
                yield return GREEN;
                yield return ORANGE;
                yield return PURPLE;
                yield return NULLCOLOR;
            }
        }

        Color(char initial)
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
            return Color.NULLCOLOR;
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
            Debug.Assert(this != Color.NULLCOLOR);
            Consola.GetInstance().Write(_initial);
        }

        public Boolean IsNull()
        {
            return this == Color.NULLCOLOR;
        }
    }
}
