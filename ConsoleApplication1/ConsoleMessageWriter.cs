using System;

namespace ConsoleApplication1
{
   public class ConsoleMessageWriter : IMessageWriter
    {
        public void Write(string message)
        {
            Console.WriteLine(message);
            Console.ReadLine();
        }
    }
}
