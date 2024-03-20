using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    public abstract class Pizza
    {
        public string Name { get; protected set; }
        public string Description { get; protected set; } = string.Empty;

        public Pizza(string name, string description)
        {
            this.Name = name;
            this.Description = description;
        }

        public abstract int GetCost();
    }

    public class BavarianPizza : Pizza
    {
        public BavarianPizza() : base("Баварская пицца", "")
        { }

        public override int GetCost()
        {
            return 500;
        }
    }

    public class CheezePizza : Pizza
    {
        public CheezePizza() : base("Сырная пицца", "")
        { }

        public override int GetCost()
        {
            return 300;
        }
    }

    public class PepperoniPizza : Pizza
    {
        public PepperoniPizza() : base("Пицца пеперони", "")
        { }

        public override int GetCost()
        {
            return 450;
        }
    }

    public class MeatPizza : Pizza
    {
        public MeatPizza() : base("Мясная пицца", "")
        { }

        public override int GetCost()
        {
            return 500;
        }
    }
}