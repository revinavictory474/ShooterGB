using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Client 
{
    public void ClientCode(Component component)
    {
        Debug.Log($"Результат: " + component.Operation());
    }
}
