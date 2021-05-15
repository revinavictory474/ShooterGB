using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConcreteDecorator: Decorator
{
    public ConcreteDecorator(Component comp) : base(comp)
    {
    }

    public override string Operation()
    {
        return $"ConcreteDecorator({base.Operation()})";
    }
}
