using Assets.Scripts;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rage : CardEffect
{
    public override void callEffect(CardEffectGameGateway gateway)
    {
        gateway.moultiplyAttack(20);
    }
}
