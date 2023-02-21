
using Assets.Scripts.Enemies.Effects;
using System;
using UnityEngine;

namespace Assets.Scripts.Enemies
{
    [Serializable]
    public class CowboySlayer : Enemy
    {
        [SerializeField]
        VeryEvil evilEffect;

        [SerializeField]
        int _slots = 0;

        [SerializeField]
        int _life = 100;

        public EnemyEffect[] getEnemyEffects()
        {
            return new EnemyEffect[] {evilEffect};
        }

        public int slotsCount()
        {
            return _slots;
        }

        public int life()
        {
            return _life;
        }
    }

}

