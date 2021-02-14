using System;

namespace TemplateMethod
{
    public class AppBuilder: Builder
    {
        public override void Compile() => Console.WriteLine("Compile");

        public override void Test() => Console.WriteLine("Test");

        public override void Deploy() => Console.WriteLine("Deploy");
    }
}