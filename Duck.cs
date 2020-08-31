using System;

namespace Duck
{
  public abstract class Duck
  {
    public IFlyBehavior flyBehavior;
    public IQuackBehavior quackBehavior;
    public void setFlyBehavior(IFlyBehavior fb)
    {
      flyBehavior = fb;
    }

    public void setQuakBehavior(IQuackBehavior qb)
    {
      quackBehavior = qb;
    }
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