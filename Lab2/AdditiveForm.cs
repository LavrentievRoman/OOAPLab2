using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2
{
    public partial class AdditiveForm : Form
    {
        MainForm mainForm;
        public AdditiveForm(MainForm mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            mainForm.pizza = new PizzaSize(sizeComboBox.Text, mainForm.pizza);
            mainForm.pizza = new PizzaDoughType(doughTypeComboBox.Text, mainForm.pizza);

            if (mozzarellaCheckBox.Checked) mainForm.pizza = new AddMozzarella(mainForm.pizza);
            if (baconCheckBox.Checked) mainForm.pizza = new AddBacon(mainForm.pizza);
            if (chickenCheckBox.Checked) mainForm.pizza = new AddChicken(mainForm.pizza);
            if (tomatoesСheckBox.Checked) mainForm.pizza = new AddTomatoes(mainForm.pizza);
            if (hotPepperCheckBox.Checked) mainForm.pizza = new AddHotPepper(mainForm.pizza);

            mainForm.chequeGridView.Rows.Add(mainForm.pizza.Name, mainForm.pizza.GetCost(), mainForm.pizza.Description);

            int cost = Convert.ToInt32(mainForm.costTextBox.Text);

            cost += mainForm.pizza.GetCost();

            mainForm.costTextBox.Text = Convert.ToString(cost);

            this.Close();
        }
    }
}
