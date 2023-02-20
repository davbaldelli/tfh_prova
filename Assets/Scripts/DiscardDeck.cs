using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

namespace Assets.Scripts
{
    [CreateAssetMenu]
    public class DiscardDeck : ScriptableObject
    {
        Stack<Card> cards = new Stack<Card>();
    }
}