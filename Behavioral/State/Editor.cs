namespace State
{
    public class Editor
    {
        private IWritingState _state;

        public Editor() => _state = new DefaultWrite();
        
        public void SetState(IWritingState state) => _state = state;
        
        public void Write(string word) => _state.Write(word);
    }
}