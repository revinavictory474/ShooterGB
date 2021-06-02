using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Person 
{
    public int Age;
    public string BirthDate;
    public string Name;
    public IdInfo IdInfo;

    public Person ShallowCopy()
    {
        return (Person)this.MemberwiseClone();
    }

    public Person DeepCopy()
    {
        Person clone = (Person)this.MemberwiseClone();
        clone.IdInfo = new IdInfo(IdInfo.IdNumber);
        clone.Name = String.Copy(Name);
        return clone;
    }
}
