using System;
using System.Diagnostics;

namespace MasterMind
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
        
        public void WriteLine()
        {
            Message.Result.WriteLine(this._blacks, this._whites);
        }

    }
}
