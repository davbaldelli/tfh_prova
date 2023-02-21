using System.Collections.Generic;
using UnityEngine;
using Enemies.Effects;

namespace Enemies
{
    [CreateAssetMenu(fileName = "Enemy", menuName = "Enemy/Enemy")]
    public class EnemyObject : ScriptableObject, Enemy
    {
        [SerializeField]
        List<EnemyEffectObject> _effects = new List<EnemyEffectObject>();
        [SerializeField]
        int _life;
        [SerializeField]
        int _slots;
        [SerializeField]
        string _name;
        [SerializeField]
        Sign _sign;

        public int slots => _slots;

        public int life => _life;

        public EnemyEffect[] effects => _effects.ToArray();

        public string enemyName => _name;

        public Sign sign => _sign;
    }
}