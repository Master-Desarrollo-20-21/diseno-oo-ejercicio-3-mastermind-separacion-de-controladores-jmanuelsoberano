using System;
using System.Diagnostics;

namespace MasterMind.Models
{
    public class Result
    {
        public const int WIDTH = 4;
        private int blacks;
        private int whites;

        public Result(int blacks, int whites)
        {
            Debug.Assert(blacks >= 0);
            Debug.Assert(whites >= 0);

            this.blacks = blacks;
            this.whites = whites;
        }

        public Boolean IsWinner()
        {
            return this.blacks == Result.WIDTH;
        }

        public int GetWhites()
        {
            return this.whites;
        }

        public int GetBlacks()
        {
            return this.blacks;
        }
    }
}