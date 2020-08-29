using System;

namespace Duck
{
  public abstract class Duck
  {
    public IFlyBehavior flyBehavior;
    public IQuackBehavior quackBehavior;
    public abstract void display();
    public void performFly()
    {
      flyBehavior.fly();
    }
    public void performQuack()
    {
      quackBehavior.quack();
    }
    public void swim()
    {
      Console.WriteLine("All ducks float, even decoys!");
    }
  }
}