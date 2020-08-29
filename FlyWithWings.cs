using System;

namespace Duck
{
  public class FlyWithWings : IFlyBehavior
  {
    public void fly()
    {
      Console.WriteLine("I'm flying!!");
    }
  }
}