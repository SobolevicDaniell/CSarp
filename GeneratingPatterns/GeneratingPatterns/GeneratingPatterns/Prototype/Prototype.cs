namespace GeneratingPatterns
{
    class ClonableClass : IClonable
    {
        public string Name { get; set; }

        public IClonable Clone()
        {
            return new ClonableClass() { Name = Name };
        }
    }
    interface IClonable
    {
        string Name { get; set; }
        IClonable Clone();
    }

    
}
