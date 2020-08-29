using System;

namespace Duck
{
  public class Squeak : IQuackBehavior
  {
    public void quack()
    {
      Console.WriteLine("Squeak");
    }
  }
}