using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ParallelDesignPatterns
{
    class MinValueFinder
    {
        private Func<int, int> f;

        public MinValueFinder(Func<int, int> f)
        {
            this.f = f;
        }

        internal int findMinimum(int a, int b)
        {
            throw new NotImplementedException();
        }
    }
}
