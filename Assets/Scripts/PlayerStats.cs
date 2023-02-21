using System.Collections.Generic;
using UnityEngine;

namespace Assets.Scripts
{
    [CreateAssetMenu]
    public class PlayerStats : ScriptableObject
    {
        public int life;
        public float attackMult;
        public List<Card> deck = new List<Card>();
    }
}