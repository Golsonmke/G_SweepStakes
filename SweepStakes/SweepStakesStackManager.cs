using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepStakes
{
    class SweepStakesStackManager : ISweepStakesManager
    {
        //Stack data Structure
        Stack<SweepStakes> stack;

        public SweepStakesStackManager()
        {
            Stack<SweepStakes> stack = new Stack<SweepStakes>();
        }
        public void InsertSweepStakes(SweepStakes sweepStakes)
        {
            stack.Push(sweepStakes);
        }
        public SweepStakes GetSweepStakes()
        {
            return stack.Pop();
        }
    }
}
