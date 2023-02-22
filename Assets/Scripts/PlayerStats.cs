using Cards;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class PlayerStats : ScriptableObject
{
    public int life;
    public float attackMult = 1;
    public float defenseMult = 1;
    public int heandCardsCount = 5;
    public List<CardObject> startingDeckTemplate = new List<CardObject>();

    public List<ICard> getStartingDeck()
    {
        List<ICard> deck = new List<ICard>();
        foreach(CardObject cardTemplate in startingDeckTemplate)
        {
            deck.Add(new Card(cardTemplate));
        }
        return deck;
    }

}