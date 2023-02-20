using System.Collections;
using UnityEngine;

namespace Assets.Scripts
{
    [CreateAssetMenu]
    public class PlayerStats : ScriptableObject
    {
        public int life;
        public int attackMult;
        public Card[] hand;
    }
}