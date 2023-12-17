namespace Lab21
{
    public interface IVisitor
    {
        void Visit(Menu menu);
        void Visit(Section section);
        void Visit(MenuItem menuItem);
        void Visit(Dish dish);
        object GetResult();
    }
}
