using Assets.Scripts;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Rage", menuName = "Card/ActiveEffect/Rage")]
public class Rage : ActiveCardEffectObject
{
    public override void callEffect(CardEffectGateway gateway)
    {
        gateway.addAttackMult(0.2f);
    }
}
