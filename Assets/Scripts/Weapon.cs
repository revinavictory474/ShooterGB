using System.Collections;
using UnityEngine;


public class Weapon : IWeapon
{
    private int _damage;

    public int Damage { get => _damage; set => _damage = value; }
}
