using Assets.Scripts;
using System;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "TestAction", menuName = "Action")]
public class Action : ScriptableObject
{
    [SerializeField]
    private List<ActionEffect> activeEffects = new List<ActionEffect>();
}

