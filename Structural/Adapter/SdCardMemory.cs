namespace Adapter
{
    public class SdCardMemory
    {
        public void ConnectToDevice() => System.Console.WriteLine("Slow Connect");

        public void Send() => System.Console.WriteLine("Slow Sending Data");

        public void GetData() => System.Console.WriteLine("Slow Geting Data");
    }
}