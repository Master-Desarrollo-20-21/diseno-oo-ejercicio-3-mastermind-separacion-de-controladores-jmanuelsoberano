using System;
using System.Linq;

namespace MasterMind
{
    public class SecretCombination : Combination
    {
        public SecretCombination()
        {
            for (int i = 0; i < Color.Length(); i++)
            {
                this.Colors.Add(Color.Get(i));
            }
            Random random = new Random(DateTime.Now.Millisecond);
            for (int i = 0; i < Color.Length() - Result.WIDTH; i++)
            {
                Color colorRemove = this.Colors[random.Next(this.Colors.Count)];
                this.Colors.Remove(colorRemove);
            }
            this.Colors = this.Colors.OrderBy(x => Guid.NewGuid()).ToList();
        }

        public Result GetResult(ProposedCombination proposedCombination)
        {
            int blacks = 0;
            int whites = 0;
            for (int i = 0; i < this.Colors.Count; i++)
            {
                if (proposedCombination.Contains(this.Colors[i], i))
                {
                    blacks++;
                } else if (proposedCombination.Contains(this.Colors[i]))
                {
                    whites++;
                }
            }
            return new Result(blacks, whites);
        }

        public void WriteLine()
        {
            Message.SecretCombination.Write();
            Consola.GetInstance().WriteLine();
        }
    }
}
