using UnityEngine;

namespace Enemies.Effects
{
    [CreateAssetMenu(fileName = "VeryEvil", menuName = "Enemy/Effect/VeryEvil")]
    public class VeryEvil : EnemyEffectObject
    {
        [SerializeField]
        int evilness;

        public override void callEffect(IEnemyEffectGateway gateway)
        {
            gateway.doEvilStuff(evilness);
        }
    }
}