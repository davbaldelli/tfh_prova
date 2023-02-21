using Cards;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class PlayerStats : ScriptableObject
{
    public int life;
    public float attackMult = 1;
    public float defenseMult = 1;
    public List<CardObject> StartingDeck = new List<CardObject>();
}