namespace Lab21
{
    public class CountVeganVisitor : Visitor
    {
        public int VeganCount { get; private set; }

        public override void Visit(IComponent component)
        {
            if (component is MenuItem menuItem && menuItem.IsVegan)
            {
                VeganCount++;
            }
        }

        public object GetResult()
        {
            return VeganCount;
        }
    }
}
