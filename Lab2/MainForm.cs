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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        public Pizza pizza;

        private void addButton_Click(object sender, EventArgs e)
        {
            MenuForm menu = new MenuForm(this);

            menu.Show();
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            chequeGridView.Rows.Clear();

            costTextBox.Text = "0"; 
        }
    }
}
