namespace Memento
{
    public class EditorMemento
    {
        public string Content { get; private set; }

        public EditorMemento(string content) => Content = content;
    }
}