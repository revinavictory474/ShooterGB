using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProgramPrototype : MonoBehaviour
{
    void Update()
    {
        Person person1 = new Person();

        person1.Age = 42;
        person1.BirthDate = ("01.01.1997");
        person1.Name = "Боба Фетт";
        person1.IdInfo = new IdInfo(999);

        Person person2 = person1.DeepCopy();

        Debug.Log("person1");
        DisplayValues(person1);

        Debug.Log("person2");
        DisplayValues(person2);


        person1.Age = 32;
        person1.BirthDate = ("08.06.2014");
        person1.Name = "Энакин Скайуокер";
        person1.IdInfo.IdNumber = 666;


        Debug.Log("person1");
        DisplayValues(person1);

        Debug.Log("person2");
        DisplayValues(person2);

    }

    public static void DisplayValues(Person p)
    {
        Debug.Log($"Имя: {p.Name}, Возраст: {p.Age}, Дата рождения: {p.BirthDate}");
        Debug.Log($"Номер: {p.IdInfo.IdNumber}");
    }
}
