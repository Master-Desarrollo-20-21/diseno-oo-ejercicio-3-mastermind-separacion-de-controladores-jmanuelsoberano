using System;
using System.Diagnostics;

namespace MasterMind.Models
{
    public class Result
    {
        public const int WIDTH = 4;
        private int _blacks;
        private int _whites;

        public Result(int blacks, int whites)
        {
            Debug.Assert(blacks >= 0);
            Debug.Assert(whites >= 0);

            this._blacks = blacks;
            this._whites = whites;
        }

        public Boolean IsWinner()
        {
            return this._blacks == Result.WIDTH;
        }

        public int GetWhites()
        {
            return this._whites;
        }

        public int GetBlacks()
        {
            return this._blacks;
        }
    }
}
