using Assets.Scripts;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rage : ActiveCardEffect
{
    public void callEffect(CardEffectGateway gateway)
    {
        gateway.addAttackMult(0.2f);
    }
}
