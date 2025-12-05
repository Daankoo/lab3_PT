using Microsoft.VisualStudio.TestTools.UnitTesting;
using PizzaBuilderDemo;

namespace Builder.Tests
{
    [TestClass]
    public class PizzaBuilderTests
    {
        [TestMethod]
        public void FullCheesePizza_ShouldContainDoughSauceCheese()
        {
            var director = new PizzaDirector();
            var builder = new CheesePizzaBuilder();
            director.Builder = builder;

            director.BuildFullFeaturedPizza();
            var pizza = builder.GetPizza();
            var description = pizza.ListIngredients();

            Assert.AreEqual("Pizza with: Dough, Tomato sauce, Cheese\n", description);
        }

        [TestMethod]
        public void BasicCheesePizza_ShouldContainOnlyDoughAndSauce()
        {
            var director = new PizzaDirector();
            var builder = new CheesePizzaBuilder();
            director.Builder = builder;

            director.BuildBasicPizza();
            var pizza = builder.GetPizza();
            var description = pizza.ListIngredients();

            Assert.AreEqual("Pizza with: Dough, Tomato sauce\n", description);
        }

        [TestMethod]
        public void FullPepperoniPizza_ShouldContainDoughSauceCheesePepperoni()
        {
            var director = new PizzaDirector();
            var builder = new PepperoniPizzaBuilder();
            director.Builder = builder;

            director.BuildFullFeaturedPizza();
            var pizza = builder.GetPizza();
            var description = pizza.ListIngredients();

            Assert.AreEqual("Pizza with: Dough, Tomato sauce, Cheese, Pepperoni\n", description);
        }

        [TestMethod]
        public void BasicPepperoniPizza_ShouldContainOnlyDoughAndSauce()
        {
            var director = new PizzaDirector();
            var builder = new PepperoniPizzaBuilder();
            director.Builder = builder;

            director.BuildBasicPizza();
            var pizza = builder.GetPizza();
            var description = pizza.ListIngredients();

            Assert.AreEqual("Pizza with: Dough, Tomato sauce\n", description);
        }

        [TestMethod]
        public void GetPizza_ShouldResetBuilderState()
        {
            var director = new PizzaDirector();
            var builder = new CheesePizzaBuilder();
            director.Builder = builder;

            director.BuildBasicPizza();
            var firstPizza = builder.GetPizza();
            var firstDescription = firstPizza.ListIngredients();

            var secondPizza = builder.GetPizza();
            var secondDescription = secondPizza.ListIngredients();

            Assert.AreEqual("Pizza with: Dough, Tomato sauce\n", firstDescription);
            Assert.AreEqual("Pizza has no ingredients.\n", secondDescription);
        }

        [TestMethod]
        public void EmptyPizza_ShouldHaveNoIngredientsMessage()
        {
            var pizza = new Pizza();

            var description = pizza.ListIngredients();

            Assert.AreEqual("Pizza has no ingredients.\n", description);
        }
    }
}
