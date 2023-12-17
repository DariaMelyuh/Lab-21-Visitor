namespace Lab21
{
    public class CountVeganVisitor : IVisitor
    {
        public int VeganCount { get; private set; }

        public void Visit(Menu menu)
        {
            foreach (var component in menu.GetComponents())
            {
                component.Accept(this);
            }
        }

        public void Visit(Section section)
        {
            VeganCount += section.VeganCount;
        }

        public void Visit(MenuItem menuItem)
        {
            if (menuItem.IsVegan)
            {
                VeganCount++;
            }
        }

        public void Visit(Dish dish)
        {
           
        }

        public object GetResult()
        {
            return VeganCount;
        }
    }


}
