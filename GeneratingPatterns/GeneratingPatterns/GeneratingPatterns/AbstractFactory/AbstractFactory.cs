namespace GeneratingPatterns
{
    public interface IPizza { }
    public interface IBurger { }
    public interface IFoodFactory
    {
        IPizza CreatePizza();
        IBurger CreateBurger();
    }
    public class AmericanPizza : IPizza { }
    public class AmericanBurger : IBurger { }
    public class RussiaPizza : IPizza { }
    public class RussiaBurger : IBurger { }

    public class AmericanFoodFactory : IFoodFactory
    {
        public IBurger CreateBurger()
        {
            return new AmericanBurger();
        }

        public IPizza CreatePizza()
        {
            return new AmericanPizza();
        }
    }

    public class RussiaFoodFactory : IFoodFactory
    {
        public IBurger CreateBurger()
        {
            return new RussiaBurger();
        }

        public IPizza CreatePizza()
        {
            return new RussiaPizza();
        }
    }
}
