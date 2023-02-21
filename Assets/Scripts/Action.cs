using Assets.Scripts;
using System;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "TestAction", menuName = "Action")]
public class Action : ScriptableObject, Card
{
    [SerializeField]
    private List<ActionEffect> activeEffects = new List<ActionEffect>();
    [SerializeField]
    private List<ActionEffect> passiveEffects = new List<ActionEffect>();

    public CardEffect[] getActiveEffects()
    {
        return activeEffects.ToArray();
    }

    public CardEffect[] getPassiveEffects()
    {
        return passiveEffects.ToArray();
    }
}

