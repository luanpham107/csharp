using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypingGame
{
    class Stats
    {
        public int Correct;
        public int Miss;
        public int Total;
        public int Accuracy;

        public void Update(bool correctKey)
        {
            Total++;
            if (correctKey)
            {
                Correct++;
            }
            else
            {
                Miss++;
            }
            Accuracy = 100 * Correct / (Correct + Miss);
        }
    }
}
