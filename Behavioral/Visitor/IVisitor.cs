namespace Visitor
{
    public interface IVisitor
    {
        void Accept(IStore store);
    }
}