using System;

namespace Duck
{
  public class Quack : IQuackBehavior
  {
    public void quack()
    {
      Console.WriteLine("Quack");
    }
  }
}