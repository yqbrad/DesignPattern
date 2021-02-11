namespace Proxy
{
    public class SecretDoor
    {
        private IDoor _door;
        public SecretDoor(IDoor door) => _door = door;

        public void Open(string key)
        {
            if (key == "key")
                _door.Open();
            else
                System.Console.WriteLine("key is incorrect");
        }

        public void Close() => _door.Close();
    }
}