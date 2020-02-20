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
                result += Math.Pow(x[i] - y[i], 2);
            }

            return Math.Sqrt(result);
        }

        private double CanberrasMetric(List<int> x, List<int> y)
        {
            double result = 0;
            for (int i = 0; i < x.Count; i++)
            {
                result += Math.Abs((x[i] - y[i]) / (x[i] + y[i]));
            }
            return result;
        }

        private double ChebyshevMetric(List<int> x, List<int> y)
        {
            double result = 0;
            List<double> helper = new List<double>();

            for (int i = 0; i < x.Count; i++)
            {
                helper.Add(result = Math.Abs(x[i] - y[i]));
            }

            return helper.Max();
        }

        private double ManhattanMetric(List<int> x, List<int> y)
        {
            double result = 0;
            for (int i = 0; i < x.Count; i++)
            {
                result += Math.Abs((x[i] - y[i]));
            }
            return result;
        }
        private double PearsonCorrelationCoefficientList(List<int> x, List<int> y)
        {
            double result = 0;
            double averageX = 0;
            double averageY = 0;
            double holder1 = 0;
            double holder2 = 0;

            for (int i = 0; i < x.Count; i++) //x.Count() = y.Count()
            {
                averageX = +x[i];
                averageY = +y[i];
            }
            averageX =averageX / x.Count();
            averageY = averageY / y.Count();

            for (int i = 0; i < x.Count(); i++)
            {
                holder1 += Math.Pow(x[i] - averageX,2);
            }
            holder1 /= x.Count();

            return result/x.Count();
        }
    }
}
