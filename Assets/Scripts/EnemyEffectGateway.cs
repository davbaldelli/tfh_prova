using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Scripts
{
    public interface EnemyEffectGateway
    {
        public void doEvilStuff(int amount);

        public void doEvenMoreEvilStuff();

        public void makeThePlayerCry();
    }
}
