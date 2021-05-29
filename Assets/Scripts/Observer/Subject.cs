using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class Subject : ISubject
{
    public int State { get; set; } = -0;

    private List<IObserver> _observers = new List<IObserver>();

    public void Attach(IObserver observer)
    {
        Debug.Log("Subject: Attached an observer.");
        this._observers.Add(observer);
    }

    public void Detach(IObserver observer)
    {
        this._observers.Remove(observer);
        Debug.Log("Subject: Detached an observer.");
    }

    public void Notify()
    {
        Debug.Log("Subject: Notifying observers...");

        foreach (var observer in _observers)
        {
            observer.Update(this);
        }
    }

    public void SomeBusinessLogic()
    {
        Debug.Log("\nSubject: I'm doing something important.");
        this.State = new Random().Next(0, 10);

        Thread.Sleep(15);

        Debug.Log("Subject: My state has just changed to: " + this.State);
        this.Notify();
    }
}
