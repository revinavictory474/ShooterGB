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
        person1.Name = "���� ����";
        person1.IdInfo = new IdInfo(999);

        Person person2 = person1.DeepCopy();

        Debug.Log("person1");
        DisplayValues(person1);

        Debug.Log("person2");
        DisplayValues(person2);


        person1.Age = 32;
        person1.BirthDate = ("08.06.2014");
        person1.Name = "������ ���������";
        person1.IdInfo.IdNumber = 666;


        Debug.Log("person1");
        DisplayValues(person1);

        Debug.Log("person2");
        DisplayValues(person2);

    }

    public static void DisplayValues(Person p)
    {
        Debug.Log($"���: {p.Name}, �������: {p.Age}, ���� ��������: {p.BirthDate}");
        Debug.Log($"�����: {p.IdInfo.IdNumber}");
    }
}
