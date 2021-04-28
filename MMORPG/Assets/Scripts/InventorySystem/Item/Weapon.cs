using System;
using UnityEngine;

public enum WeaponType {Sword, Axe, Staff};
public class Weapon : Equipment
{

    public int baseWeaponDamage;

    public Weapon(WeaponObject weapon) : base(weapon)
    {

    }
}

