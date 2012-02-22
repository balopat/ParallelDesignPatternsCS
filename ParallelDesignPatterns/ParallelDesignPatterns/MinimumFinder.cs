using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ParallelDesignPatterns
{
    class MinimumFinder : AbstractDividAndConquer<MinFinderProblem, int>
    {
        private Func<int, int> f;

        public MinimumFinder(Func<int, int> f)
        {
            this.f = f;
        }

        internal int findMinimum(int a, int b)
        {
            return solve(new MinFinderProblem(a, b, f));
        }

        internal int findMinimumSeq(int a, int b)
        {
            int minVal = f(a);
            for (int i = a; i <= b; i++)
            {
                int val = f(i);
                if (val < minVal)
                {
                    minVal = val;
                }
            }
            return minVal;
        }

        protected override int merge(int[] subSolutions)
        {
            int minVal = subSolutions[0];
            foreach(int subSolution in subSolutions){
                if (subSolution < minVal) minVal = subSolution;
            }
            return minVal;
        }

        protected override int baseCaseSolve(MinFinderProblem p)
        {
            return p.f(p.a);
        }

        protected override bool isBaseCase(MinFinderProblem p)
        {
            return p.a == p.b;
        }

        protected override MinFinderProblem[] split(MinFinderProblem p)
        {
            return new MinFinderProblem[]{
                new MinFinderProblem(p.a, p.a + (p.b-p.a)/2, p.f),
                new MinFinderProblem(p.a + (p.b-p.a)/2 + 1, p.b, p.f),
            };
        }
    }
}