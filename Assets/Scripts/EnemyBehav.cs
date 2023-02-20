using Assets.Scripts.Enemies;
using System.Collections;
using UnityEngine;

namespace Assets.Scripts
{
    public class EnemyBehav : MonoBehaviour
    {
        EnemyEffectGateway gateway;
        CowboySlayer slayer = new CowboySlayer();

        [SerializeField]
        EnemyData enemyData;
        [SerializeField]
        PlayerStats playerStats;

        // Use this for initialization
        void Start()
        {
            gateway = new EnemyEffectGatewayImpl(enemyData, playerStats);
            foreach(EnemyEffect effect in slayer.getEnemyEffects())
            {
                effect.callEffect(gateway);
            }
        }
    }
}