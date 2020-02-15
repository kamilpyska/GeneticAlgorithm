using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneticAlgorithm
{
    class Algorithm
    {
        private double EuclideanMtric(List<int> x,List<int>y)
        {
            double result =0;

            for (int i = 0; i < x.Count; i++)
            {
                result = Math.Sqrt(Math.Pow(x[i] - y[i],2));
            }

            return result;
        }
    }
}
