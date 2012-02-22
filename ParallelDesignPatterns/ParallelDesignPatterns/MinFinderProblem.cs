using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ParallelDesignPatterns
{
    class MinFinderProblem
    {
        public int a;
        public int b;
        public Func<int, int> f;

        public MinFinderProblem(int a, int b, Func<int, int> f)
        {
            this.a = a;
            this.b = b;
            this.f = f;
        }
    }
}
