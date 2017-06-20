using System;

namespace ConsoleApplication1
{
  public  class Salutation
  {
      private readonly IMessageWriter writer;

      public Salutation(IMessageWriter writer)
      {
          if (writer == null)
          {
              throw new ArgumentNullException(nameof(writer));
          }
          this.writer = writer;
      }

      public void Exclaim()
      {
          writer.Write("Hello DI!");
      }
  }
}
