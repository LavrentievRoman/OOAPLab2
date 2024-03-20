using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    public abstract class PizzaDecorator : Pizza
    {
        protected Pizza pizza;

        public PizzaDecorator(string name, string discriotion, Pizza pizza) : base(name, discriotion)
        {
            this.pizza = pizza;
        }
    }

    public class PizzaSize : PizzaDecorator
    {
        private string size;

        public PizzaSize(string size, Pizza pizza) : base(pizza.Name, pizza.Description + size, pizza)
        { 
            this.size = size;
        }

        public override int GetCost()
        {
            if (size == "Средняя")
                return pizza.GetCost() + 200;
            if (size == "Большая")
                return pizza.GetCost() + 400;

            return pizza.GetCost();

        }
    }

    public class PizzaDoughType : PizzaDecorator
    {
        public PizzaDoughType(string type, Pizza pizza) : base(pizza.Name, pizza.Description + ", " + type, pizza)
        { }

        public override int GetCost()
        {
            return pizza.GetCost();
        }
    }

    public class AddMozzarella : PizzaDecorator
    {
        public AddMozzarella(Pizza pizza) : base(pizza.Name, pizza.Description + ", с моцареллой", pizza)
        {}

        public override int GetCost()
        {
            return pizza.GetCost() + 60;
        }
    }

    public class AddChicken : PizzaDecorator
    {
        public AddChicken(Pizza pizza) : base(pizza.Name, pizza.Description + ", с курицей", pizza)
        { }

        public override int GetCost()
        {
            return pizza.GetCost() + 60;
        }
    }

    public class AddBacon : PizzaDecorator
    {
        public AddBacon(Pizza pizza) : base(pizza.Name, pizza.Description + ", с беконом", pizza)
        { }

        public override int GetCost()
        {
            return pizza.GetCost() + 60;
        }
    }

    public class AddTomatoes : PizzaDecorator
    {
        public AddTomatoes(Pizza pizza) : base(pizza.Name, pizza.Description + ", с помидорами", pizza)
        { }

        public override int GetCost()
        {
            return pizza.GetCost() + 60;
        }
    }

    public class AddHotPepper : PizzaDecorator
    {
        public AddHotPepper(Pizza pizza) : base(pizza.Name, pizza.Description + ", с острым перцем", pizza)
        { }

        public override int GetCost()
        {
            return pizza.GetCost() + 60;
        }
    }
}