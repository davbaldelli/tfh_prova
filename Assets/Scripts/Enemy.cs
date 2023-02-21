namespace Assets.Scripts
{
    interface Enemy
    {
        public int slotsCount();
        public int life();
        public EnemyEffect[] getEnemyEffects();

    }
}
