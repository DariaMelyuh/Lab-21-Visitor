namespace Lab21
{
    public class ObjectStruct
    {
        private IComponent _root;

        public ObjectStruct(IComponent root)
        {
            if (root == null)
            {
                throw new ArgumentNullException(nameof(root), "Недопустимое значение");
            }
            _root = root;
        }

        public void Accept(IVisitor visitor)
        {
            _root.Accept(visitor);
        }
    }
}
