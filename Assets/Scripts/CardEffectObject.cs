using Assets.Scripts;
using UnityEngine;


public abstract class ActiveCardEffectObject : ScriptableObject, ActiveCardEffect
{
    public abstract void callEffect(CardEffectGateway gateway);
}

public abstract class PassiveCardEffectObject : ScriptableObject, PassiveCardEffect
{
    public abstract void callEffect(CardEffectGateway gateway);
}

