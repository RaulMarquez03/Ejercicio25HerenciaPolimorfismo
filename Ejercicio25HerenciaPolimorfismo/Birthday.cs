using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio25HerenciaPolimorfismo
{
    internal class Birthday:Party
    {
        public string textCake { get; set; }

        public double CostCake()
        {
            double cost = 0;

            if (NumberPeople <= 8)
            {
                cost = 40;
            }
            else
            {
                cost = 75;
            }

            int numLetras = textCake.Length;

            if (numLetras <= 16 && NumberPeople <= 8)
            {
                cost += numLetras * 0.25;
            }
            else if (numLetras <= 40 && NumberPeople > 8)
            {
                cost += numLetras * 0.25;
            }

            return cost;
        }

        public double CalculateCostDecoracion()
        {
            double cost = 0;

            if (LuxuryOption) 
            {
                cost = 15 * NumberPeople;
            }
            else
            {
                cost = 7.5 * NumberPeople;
            }

            return cost;
        }

        public override double CalculateCost()
        {
            double costTotal = base.CalculateCost() + CostCake() + CalculateCostDecoracion();
            return costTotal;
        }
    
    }

}
