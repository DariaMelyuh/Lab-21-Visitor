namespace Lab21
{
    public abstract class IComponent
    {
        public List<IComponent> _components = new List<IComponent>();
        public int i;
        public abstract void Add(IComponent component);
        public abstract void Print();
        public abstract void Remove(IComponent component);
        public abstract void Accept(Visitor visitor);

        public IComponent Next()
        {
            if (!_components[i].IsNext())
            {
                i++;
            }

            if (_components.Count == i)
            {
                i++;
                return this;
            }

            return _components[i].IsNext() ? _components[i].Next() : throw new Exception("Конец");
        }

        public bool IsNext()
        {
            return _components.Count >= i;
        }
    }
}
