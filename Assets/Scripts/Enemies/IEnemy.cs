using Enemies.Effects;

namespace Enemies
{
    interface IEnemy
    {
        public string enemyName { get; }
        public int slots { get; }
        public int life { get; }
        public IEnemyEffect[] effects { get; }

        public Sign sign { get; }

    }
}