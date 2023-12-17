namespace Lab21
{
    public class CountSectionVisitor : IVisitor
    {
        public int SectionCount { get; private set; }

        public void Visit(Menu menu)
        {
            SectionCount++;
            foreach (var component in menu.GetComponents())
            {
                component.Accept(this);
            }
        }

        public void Visit(Section section)
        {
            SectionCount++;
            foreach (var component in section.GetComponents())
            {
                component.Accept(this);
            }
        }

        public void Visit(MenuItem menuItem)
        {
            
        }

        public void Visit(Dish dish)
        {
            
        }

        public object GetResult()
        {
            return SectionCount;
        }
    }
}
