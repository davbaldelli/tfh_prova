using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Scripts
{
    public class EnemyEffectGatewayImpl : EnemyEffectGateway
    {
        EnemyData enemyData;
        PlayerStats playerStats;

        public EnemyEffectGatewayImpl(EnemyData enemyData, PlayerStats playerStats)
        {
            this.enemyData = enemyData;
            this.playerStats = playerStats;
        }

        public void doEvenMoreEvilStuff()
        {
            enemyData.life = 10000;
        }

        public void doEvilStuff()
        {
            enemyData.life = 1000;
        }

        public void makeThePlayerCry()
        {
            playerStats.attackMult = 0.5f;
        }
    }
}
