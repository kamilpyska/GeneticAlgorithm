using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneticAlgorithm
{
    class Algorithm
    {
        public delegate double Metric(List<int> x, List<int> y);

        public double EuclideanMetric(List<int> x, List<int> y)
        {
            double result = 0;

            for (int i = 0; i < x.Count; i++)
            {
                result += Math.Pow(x[i] - y[i], 2);
            }

            return Math.Sqrt(result);
        }

        public double CanberrasMetric(List<int> x, List<int> y)
        {
            double result = 0;
            for (int i = 0; i < x.Count; i++)
            {
                result += Math.Abs((x[i] - y[i]) / (x[i] + y[i]));
            }
            return result;
        }

        public double ChebyshevMetric(List<int> x, List<int> y)
        {
            double result = 0;
            List<double> helper = new List<double>();

            for (int i = 0; i < x.Count; i++)
            {
                helper.Add(result = Math.Abs(x[i] - y[i]));
            }

            return helper.Max();
        }

        public double ManhattanMetric(List<int> x, List<int> y)
        {
            double result = 0;
            for (int i = 0; i < x.Count; i++)
            {
                result += Math.Abs((x[i] - y[i]));
            }
            return result;
        }
        public double PearsonCorrelationCoefficientList(List<int> x, List<int> y)
        {
            double result;
            double averageX = 0;
            double averageY = 0;
            double holder1;
            double holder2 = 0;
            double holder3;
            double holder4 = 0;
            double holder5 = 0;

            for (int i = 0; i < x.Count; i++) //x.Count() = y.Count()
            {
                averageX = +x[i];
                averageY = +y[i];
            }
            averageX /= x.Count();
            averageY /= y.Count();

            
            for (int i = 0; i < x.Count; i++)
            {
                //licznik 1 rownanie
                holder1 = x[i] - averageX;

                //mianownik 1 rownanie
                for (int j = 0; i < x.Count; i++)
                {
                    holder2 += Math.Pow(x[j] - averageX, 2);
                }

                holder2 /= x.Count();
                holder2 = Math.Sqrt(holder2);

                //licznik 2 rownanie
                holder3 = y[i] - averageY;

                //mianownik 2 rownanie
                for (int j = 0; i < y.Count; i++)
                {
                    holder4 += Math.Pow(y[j] - averageY, 2);
                }

                holder4 /= y.Count();
                holder4 = Math.Sqrt(holder4);

                holder5 += (holder1 / holder2) * (holder3 / holder4);
            }
            holder5 /= x.Count;

            result = 1 - Math.Abs(holder5);

            return result;
        }
    
        public void beginComputing(string metricName)
        {
            Metric metric;

            if (metricName == "CanberrasMetric")
            {
                metric = new Metric(CanberrasMetric);
            }
            else if (metricName == "ChebyshevMetric")
            {
                metric = new Metric(ChebyshevMetric);
            }
            else if (metricName == "ManhattanMetric") 
            {
                metric = new Metric(ManhattanMetric);
            }
            else if (metricName == "PearsonCorrelationCoefficientList")
            {
                metric = new Metric(PearsonCorrelationCoefficientList);
            }
            else
            {
                metric = new Metric(EuclideanMetric);
            }
        }

        private void classifyObjects(Dictionary<List<int>, int> dictionaryX, Dictionary<List<int>, int>dictionaryY, Metric metric)
        {
            foreach (KeyValuePair<List<int>,int> pairX in dictionaryX)
            {
                foreach (KeyValuePair<List<int>,int> pairY in dictionaryY)
                {
                    metric(pairX.Key, pairY.Key);
                }
            }
        }
    }
}
