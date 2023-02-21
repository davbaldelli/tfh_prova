using Assets.Scripts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

[CreateAssetMenu(fileName = "TestEffect", menuName = "Effect")]
public class BraveHeart : ActionEffect
{
    [SerializeField]
    private int amount;

    public override void callEffect(CardEffectGateway gateway)
    {
        gateway.addLife(amount);
    }
}

