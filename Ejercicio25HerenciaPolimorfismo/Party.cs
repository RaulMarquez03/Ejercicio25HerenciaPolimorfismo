using Ejercicio25HerenciaPolimorfismo;

using System;
using System.Windows.Forms;
 namespace Ejercicio25HerenciaPolimorfismo;
public class Party { 

    public int NumberPeople { get; set; }
	public double DecorationCost { get; set; }
    public bool LuxuryOption { get; set; }
    public double FixedPersonCost { get; set; }



    public void Constructor(int numberPeople, double decorationCost, bool luxuryOption, double fixedPersonCost)
    {
        NumberPeople= numberPeople;
        DecorationCost= decorationCost;
        LuxuryOption= luxuryOption;
        FixedPersonCost= fixedPersonCost;
    }
    public virtual double CalculateCost()
    {
        return NumberPeople * FixedPersonCost + DecorationCost;
    }
}
