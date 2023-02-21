using Assets.Scripts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

[CreateAssetMenu(fileName ="Card", menuName ="Card/Card")]
public class CardObject : ScriptableObject, Card
{
    public List<ActiveCardEffectObject> activeEffects = new List<ActiveCardEffectObject>();
    public List<PassiveCardEffectObject> passiveEffects = new List<PassiveCardEffectObject>();
    public int life;

    public CardEffect[] getActiveEffects()
    {
        return activeEffects.ToArray();
    }

    public CardEffect[] getPassiveEffects()
    {
        return passiveEffects.ToArray();
    }
}

