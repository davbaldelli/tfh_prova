using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Scripts.Enemies.Effects
{
    class VeryEvil : EnemyEffect
    {
        public void callEffect(EnemyEffectGateway gateway)
        {
            gateway.doEvilStuff();
        }
    }
}
