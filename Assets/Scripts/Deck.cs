using Assets.Scripts.Cards;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.Scripts
{
    [CreateAssetMenu]
    public class Deck : ScriptableObject
    {
        Stack<Card> cards = new Stack<Card>();

        public Card getCardFromTop()
        {
            return cards.Pop();
        }

        public void addCardToTop(Card card)
        {
            cards.Push(card);
        }
    }
}