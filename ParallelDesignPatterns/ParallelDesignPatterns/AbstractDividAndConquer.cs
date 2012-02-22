using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParallelDesignPatterns
{
    abstract class AbstractDividAndConquer<Problem,Solution>
    {
        protected abstract Problem[] split(Problem p);
        protected abstract Boolean isBaseCase(Problem p);
        protected abstract Solution baseCaseSolve(Problem p);
        protected abstract Solution merge(Solution[] subSolutions);

        protected Solution solve(Problem p)
        {
            if (isBaseCase(p))
            {
                return baseCaseSolve(p);
            }
            Problem[] subProblems = split(p);
            Solution[] subSolutions = new Solution[subProblems.Length];
            int i = 0;
            Parallel.ForEach<Problem>(subProblems, subProblem =>
            {
                subSolutions[i++] = solve(subProblem);
            });

            return merge(subSolutions);
        }
    }
}
