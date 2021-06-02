using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObserverB : IObserver
{
    public void Update(ISubject subject)
    {
        if ((subject as Subject).State == 0 || (subject as Subject).State >= 2)
        {
            Debug.Log("ObserverB: среагировал на событие.");
        }
    }
}
