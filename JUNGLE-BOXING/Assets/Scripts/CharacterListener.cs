using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterListener : MonoBehaviour
{
    [SerializeField] private AttackMode[] attackModes;
    
    private CharacterController2D _character2D;

    private void Awake()
    {
        _character2D = GetComponentInParent<CharacterController2D>();
    }

    private AttackMode GetAttackMode(string name)
    {
        foreach (AttackMode attackMode in attackModes)
        {
            if (attackMode.getName().Equals(name, System.StringComparison.OrdinalIgnoreCase))
            {
                return attackMode;
            }
        }
        return null;
    }
    public void OnPunch()
    {
        AttackMode attackMode = GetAttackMode("OnPunch");
        _character2D.Punch(attackMode.getDamage(), attackMode.getIsPercentage());
    }
    public void OnSuper()
    {
        AttackMode attackMode = GetAttackMode("OnSuper");
        _character2D.Super(attackMode.getDamage(), attackMode.getIsPercentage());
    }
}
