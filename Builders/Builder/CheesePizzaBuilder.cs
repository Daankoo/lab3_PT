using Builder.Product;

namespace Builder.Builders
{
    public class CheesePizzaBuilder : IPizzaBuilder
    {
        private Pizza _pizza = new Pizza();

        public CheesePizzaBuilder()
        {
            Reset();
        }

        public void Reset()
        {
            _pizza = new Pizza();
        }

        public void AddDough()
        {
            _pizza.Add("Dough");
        }

        public void AddSauce()
        {
            _pizza.Add("Tomato sauce");
        }

        public void AddToppings()
        {
            _pizza.Add("Cheese");
        }

        public Pizza GetPizza()
        {
            Pizza result = _pizza;
            Reset();
            return result;
        }
    }
}

