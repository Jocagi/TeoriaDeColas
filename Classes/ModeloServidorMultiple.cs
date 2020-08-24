using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace ModeloDeColas.Classes
{
    class ModeloServidorMultiple
    {
        public static double Ls(double lambda, double mu, int servidores)
        {
            return ( ( (lambda * mu * Math.Pow(lambda/mu, servidores)) / (Factorial(servidores - 1) * Math.Pow(servidores*mu - lambda, 2)) ) 
                   * P0(lambda, mu, servidores) ) + (lambda/mu) ;
        }

        public static double Ws(double lambda, double mu, int servidores)
        {
            return Ls(lambda, mu, servidores) / lambda ;
        }

        public static double Lq(double lambda, double mu, int servidores)
        {
            return Ls(lambda, mu, servidores) - (lambda/mu) ;
        }

        public static double Wq(double lambda, double mu, int servidores)
        {
            return Lq(lambda, mu, servidores) / lambda;
        }

        public static double p(double lambda, double mu, int servidores)
        {
            return lambda / (servidores * mu);
        }

        public static double P0(double lambda, double mu, int servidores)
        {
            double sum = 0;

            for (int n = 0; n <= servidores - 1; n++)
            {
                sum += (1 / Factorial(n)) * Math.Pow((lambda / mu), n);
            }

            return 1 / (sum + 
                ((1.0 / Factorial(servidores)) * Math.Pow(lambda / mu , servidores) * ((servidores * mu)/(servidores * mu - lambda)) )); 
        }

        public static double Pn(double lambda, double mu, int servidores, int unidades)
        {
            if (unidades >= 0 && unidades <= servidores)
            {
                return P0(lambda, mu, servidores) *
                        (Math.Pow(lambda/mu, unidades) / Factorial(unidades));
            }
            else if (unidades >= servidores)
            {
                return P0(lambda, mu, servidores) *
                        (Math.Pow(lambda / mu, unidades) / (Factorial(servidores) * Math.Pow(servidores, unidades - servidores)) );
            }
            else
            {
                return 0;
            }
        }

        private static int Factorial(int n) 
        {
            if (n == 0)
            {
                return 1;
            }
            else
            {
                return n * Factorial(n - 1);
            }
        }
    }
}
