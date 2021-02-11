namespace Facade
{
    public class ComputerFacade
    {
        public Computer _computer;
        public ComputerFacade(Computer computer) => _computer = computer;

        public void TurnOn()
        {
            _computer.WriteHard();
            _computer.ReadOs();
            _computer.ShowDisplay();
        }

        public void TurnOff()
        {
            _computer.ResetHard();
            _computer.CleanRam();
            _computer.DisableDisplay();
        }
    }
}