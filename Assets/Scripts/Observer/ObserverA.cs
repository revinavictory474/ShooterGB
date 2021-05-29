using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObserverA : IObserver
{
    public void Update(ISubject subject)
    {
        if ((subject as Subject).State < 3)
        {
            Debug.Log("ObserverA: среагировал на событие.");
        }
    }
}
