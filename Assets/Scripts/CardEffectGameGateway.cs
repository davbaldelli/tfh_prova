using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class CardEffectGameGateway : MonoBehaviour
{
    public abstract void addLife(int amount);

    public abstract void moultiplyAttack(int amount);

    public abstract void drawCard();
}
