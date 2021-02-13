namespace Visitor
{
    public interface IStore
    {
        void Visit(IVisitor visitor);
    }
}