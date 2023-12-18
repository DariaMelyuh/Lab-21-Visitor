namespace Lab21
{
    public class CountSectionVisitor : Visitor
    {
        public int SectionCount { get; private set; }

        public override void Visit(IComponent component)
        {
            if (component is Section section)
            {
                SectionCount++;
            }
        }

        public object GetResult()
        {
            return SectionCount;
        }
    }
}
