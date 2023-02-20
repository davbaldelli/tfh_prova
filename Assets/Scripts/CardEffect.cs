using System.Collections;
using UnityEngine;
using UnityEngine.Events;

namespace Assets.Scripts
{
    public abstract class CardEffect : MonoBehaviour
    {
        //we should define a type that describes when the effect should be raised
        //or maybe we should create different subclasses
        public abstract void callEffect(CardEffectGameGateway gateway);
    }
}