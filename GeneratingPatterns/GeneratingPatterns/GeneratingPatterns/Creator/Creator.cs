namespace GeneratingPatterns
{
    public interface IProduct
    {
        string Name { get; set; }
    }
    public interface ICreator
    {
        IProduct Create();
    }

    public class ProductA : IProduct
    {
        public string Name { get; set; }
    }
    public class ProductB : IProduct
    {
        public string Name { get; set; }
    }

    public class ProductA_Creator : ICreator
    {
        public IProduct Create()
        {
            return new ProductA() { Name = "A" };
        }
    }
    public class ProductB_Creator : ICreator
    {
        public IProduct Create()
        {
            return new ProductB() { Name = "B" };
        }
    }
}
