using System.Collections.Generic;

namespace GeneratingPatterns
{
    public interface IBuilder
    {
        void AddTomatoes();
        void AddOnion();
        void AddCheese();
        Pizza GetPizza();
    }

    public class Pizza
    {
        public List<string> parts = new List<string>();
        public string Cheese { get; private set; }

        public void AddPart(string part)
        {
            parts.Add(part);
        }

        public void AddCheese()
        {
            Cheese = "cheese";
        }

    }

    public class Builder : IBuilder
    {
        private Pizza _pizza = new Pizza();
        public void AddCheese()
        {
            _pizza.AddCheese();
        }

        public void AddOnion()
        {
            _pizza.AddPart("onion");
        }
        public void AddTomatoes()
        {
            _pizza.AddPart("Tomatoes");
        }

        public Pizza GetPizza()
        {
            return _pizza;
        }
    }

    public class Director
    {
        private IBuilder _builder;

        public Director(IBuilder builder)
        {
            _builder = builder;
        }

        public Pizza Create()
        {
            _builder.AddCheese();
            _builder.AddOnion();
            _builder.AddTomatoes();
            return _builder.GetPizza();
        }
    }
}
