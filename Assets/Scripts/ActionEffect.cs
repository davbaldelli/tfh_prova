using Assets.Scripts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

public abstract class ActionEffect : ScriptableObject, CardEffect
{
    public abstract void callEffect(CardEffectGateway gateway);
}

