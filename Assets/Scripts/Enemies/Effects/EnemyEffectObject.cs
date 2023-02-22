using UnityEngine;

namespace Enemies.Effects
{
    public abstract class EnemyEffectObject : ScriptableObject, IEnemyEffect
    {
        public abstract void callEffect(IEnemyEffectGateway gateway);
    }
}