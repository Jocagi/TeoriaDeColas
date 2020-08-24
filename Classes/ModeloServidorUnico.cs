using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModeloDeColas.Classes
{
    public class ModeloServidorUnico
    {
        public static double Ls(double lambda, double mu) 
        {
            return lambda / (mu - lambda);
        }

        public static double Ws(double lambda, double mu)
        {
            return 1 / (mu - lambda);
        }

        public static double Lq(double lambda, double mu)
        {
            return (Math.Pow(lambda, 2)) / (mu*(mu - lambda));
        }

        public static double Wq(double lambda, double mu)
        {
            return lambda / (mu * (mu - lambda));
        }

        public static double p(double lambda, double mu)
        {
            return lambda / mu;
        }

        public static double P0(double lambda, double mu)
        {
            return 1 - (lambda / mu);
        }

        public static double Pn(double lambda, double mu, int unidades)
        {
            return Math.Pow( (lambda / mu) , unidades + 1);
        }
    }
}
