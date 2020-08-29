using System;

namespace Duck
{
  public class MuteQuack : IQuackBehavior
  {
    public void quack()
    {
      Console.WriteLine("<< Silence >>");
    }
  }
}