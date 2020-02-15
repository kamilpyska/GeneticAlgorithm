using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneticAlgorithm
{
    class Algorithm
    {
        private double EuclideanMetric(List<int> x, List<int> y)
        {
            double result = 0;

            for (int i = 0; i < x.Count; i++)
            {
                result = Math.Sqrt(Math.Pow(x[i] - y[i], 2));
            }

            return result;
        }

        private double CanberrasMetric(List<int> x, List<int> y)
        {
            double result = 0;
            for (int i = 0; i < x.Count; i++)
            {
                result = Math.Abs((x[i] - y[i]) / (x[i] + y[i]));
            }
            return result;
        }
    }
}
