using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2
{
    public partial class MenuForm : Form
    {
        private MainForm mainForm;

        public MenuForm(MainForm mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;
        }

        private void bavarianPizzaButton_Click(object sender, EventArgs e)
        {
            mainForm.pizza = new BavarianPizza();

            AdditiveForm additiveForm = new AdditiveForm(mainForm);

            additiveForm.Show();

            this.Close();
        }

        private void cheezePizzaButton_Click(object sender, EventArgs e)
        {
            mainForm.pizza = new CheezePizza();

            AdditiveForm additiveForm = new AdditiveForm(mainForm);

            additiveForm.Show();

            this.Close();
        }

        private void PepperoniPizzaButton_Click(object sender, EventArgs e)
        {
            mainForm.pizza = new PepperoniPizza();

            AdditiveForm additiveForm = new AdditiveForm(mainForm);

            additiveForm.Show();

            this.Close();
        }

        private void meatPizzaButton_Click(object sender, EventArgs e)
        {
            mainForm.pizza = new MeatPizza();

            AdditiveForm additiveForm = new AdditiveForm(mainForm);

            additiveForm.Show();

            this.Close();
        }
    }
}
