using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ParallelDesignPatterns
{
    class MinimumFinder
    {
        private Func<int, int> sqr;

        public MinimumFinder(Func<int, int> sqr)
        {
            this.sqr = sqr;
        }

        internal object findMinimum(int p, int p_2)
        {
            throw new NotImplementedException();
        }
    }
}
