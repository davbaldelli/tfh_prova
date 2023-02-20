
using Assets.Scripts.Enemies.Effects;

namespace Assets.Scripts.Enemies
{
    public class CowboySlayer : Enemy
    {
        EnemyEffect[] effects = new EnemyEffect[1] { new VeryEvil() };

        public EnemyEffect[] getEnemyEffects()
        {
            return effects;
        }

        public int slotsCount()
        {
            return 3;
        }
    }

}

