using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProgramDecorator : MonoBehaviour
{
    void Update()
    {
        Client client = new Client();

        var simple = new ConcreteComponent();
        Debug.Log("������� ���������");
        client.ClientCode(simple);

        
        ConcreteDecorator decorator = new ConcreteDecorator(simple);
        Debug.Log("������������� ���������");
        client.ClientCode(decorator);
    }
}
