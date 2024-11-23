using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "New char", menuName = "ScriptableObjects/Character", order = 1)]
public class BaseCharData : ScriptableObject
{
    public float baseMaxHealth;
    public float baseRegeneration;

    public float basePhysDamage;
    public float baseMagDamage;

    public float baseSpeed;

    public float basePhysResistance;
    public float baseMagResistance;
}
