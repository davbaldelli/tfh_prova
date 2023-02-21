using Assets.Scripts;
using System;
using UnityEngine;

[CreateAssetMenu(fileName = "VeryEvil", menuName = "Enemy/Effect/VeryEvil")]
public class VeryEvil : EnemyEffectObject
{
    [SerializeField]
    int evilness;

    public override void callEffect(EnemyEffectGateway gateway)
    {
        gateway.doEvilStuff(evilness);
    }
}