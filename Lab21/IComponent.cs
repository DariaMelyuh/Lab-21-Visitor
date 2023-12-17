namespace Lab21
{
    public abstract class IComponent
    {
        public abstract void Add(IComponent component);
        public abstract void Print();
        public abstract void Remove(IComponent component);
        public abstract void Accept(IVisitor visitor);
    }
}
