using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStats : MonoBehaviour
{

    public float MaxHealth;
    public float Regeneration;

    public float PhysDamage;
    public float MagDamage;

    public float Speed =1.0f;

    public float PhysResistance;
    public float MagResistance;

    public BaseCharData baseCharData;

    private void Awake()
    {
        Speed += baseCharData.baseSpeed;
    }
}

