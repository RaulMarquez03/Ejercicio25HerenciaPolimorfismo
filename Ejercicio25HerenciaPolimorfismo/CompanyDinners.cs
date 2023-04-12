using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio25HerenciaPolimorfismo
{
    public class CompanyDinners: Party
    {
        public bool HealthyOption { get; set; }

        public double CalculateCostDecoracion()
        {
            double cost = 0;

            if (LuxuryOption)
            {
                cost = 15 * NumberPeople + 50;
            }
            else
            {
                cost = 7.5 * NumberPeople + 30;
            }

            return cost;
        }

        public void AddHealthyOption()
        {
            HealthyOption = true;
            FixedPersonCost = 5;
        }

        public override double CalculateCost()
        {
            

             if (HealthyOption)
            {
               double cost = (base.CalculateCost() + CalculateCostDecoracion()) ;
                cost *= 0.95;
                return cost;
            }
            else
            {
                double CostNotHealty = base.CalculateCost() +  CalculateCostDecoracion();
                return CostNotHealty;
            }
           
            
        }


    }
}
