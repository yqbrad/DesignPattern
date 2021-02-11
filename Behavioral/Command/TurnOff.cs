namespace Command
{
    public class TurnOff : ICommand
    {
        private Lamp _lamp;
        public TurnOff(Lamp lamp) => _lamp = lamp;

        public void Execute() => _lamp.TurnOff();

        public void Redo() => Execute();

        public void Undo() => _lamp.TurnOn();
    }
}