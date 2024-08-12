using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class AttackMode 
{
    [SerializeField] private string name;
    [SerializeField] private float damage;
    [SerializeField] private bool isPercentage;

    public string getName()
    {
        return name;
    }

    public float getDamage()
    {
        return damage;
    }

    public bool getIsPercentage()
    {
        return isPercentage;
    }
    
}
