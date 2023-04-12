namespace Ejercicio25HerenciaPolimorfismo
{
    public partial class Form1 : Form
    {
        public static Form1 Instance { get; private set; }

        public Form1()
        {
            InitializeComponent();
            Instance = this;
            
        }
       

       

            private void button1_Click(object sender, EventArgs e)
             {
                 CompanyDinners cena = new CompanyDinners();
                 if (checkBox1.Checked == true)
                 {
                     cena.Constructor((int)numericUpDown1.Value, cena.CalculateCostDecoracion(), true, 25);
                 }
                 else
                 {
                     cena.Constructor((int)numericUpDown1.Value, cena.CalculateCostDecoracion(), false, 25);
                 }

                 if (checkBox2.Checked == true)
                 {
                     cena.AddHealthyOption();
                 }
                 textBox1.Text = cena.CalculateCost().ToString() + '€';
             }

             private void button2_Click(object sender, EventArgs e)
             {
                 Birthday cumple = new Birthday();
                 if (checkBox3.Checked == true)
                 {
                     cumple.Constructor((int)numericUpDown2.Value, cumple.CalculateCostDecoracion(), true, 25);
                 }
                 else
                 {
                     cumple.Constructor((int)numericUpDown2.Value, cumple.CalculateCostDecoracion(), false, 25);
                 }
                 cumple.textCake = textBox3.Text;
                 textBox2.Text = cumple.CalculateCost().ToString();
             }
    }

}