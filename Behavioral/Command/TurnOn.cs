namespace Command
{
    public class TurnOn : ICommand
    {
        private Lamp _lamp;
        public TurnOn(Lamp lamp) => _lamp = lamp;

        public void Execute() => _lamp.TurnOn();

        public void Redo() => Execute();

        public void Undo() => _lamp.TurnOff();
    }
}