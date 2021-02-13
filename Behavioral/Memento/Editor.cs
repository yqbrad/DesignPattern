namespace Memento
{
    public class Editor
    {
        private string _content;
        private EditorMemento _memento;
        public string Content { get => _content; }

        public Editor() => _memento = new EditorMemento(string.Empty);

        public void Type(string words) => _content = string.Concat(_content, " + ", words);

        public void Save() => _memento = new EditorMemento(Content);

        public void Restore() => _content = _memento.Content;
    }
}