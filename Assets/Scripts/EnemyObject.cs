using Assets.Scripts;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Enemy", menuName = "Enemy/Enemy")]
public class EnemyObject : ScriptableObject, Enemy
{
    public List<EnemyEffectObject> effects = new List<EnemyEffectObject>();
    public int lifeAmount;
    public int slots;

    public EnemyEffect[] getEnemyEffects()
    {
        return effects.ToArray();
    }

    public int life()
    {
        return lifeAmount;
    }

    public int slotsCount()
    {
        return slots;
    }
}
