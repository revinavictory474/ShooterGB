using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test 
{
    static void Main(string[] args)
    {
        var subject = new Subject();
        var observerA = new ObserverA();
        subject.Attach(observerA);

        var observerB = new ObserverB();
        subject.Attach(observerB);

        subject.SomeBusinessLogic();
        subject.SomeBusinessLogic();

        subject.Detach(observerB);

        subject.SomeBusinessLogic();
    }
}
