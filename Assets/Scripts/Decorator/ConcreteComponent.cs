using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConcreteComponent : Component
{
    public override string Operation()
    {
        return "Конкретный компонент";
    }
}
