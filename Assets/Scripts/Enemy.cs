namespace Assets.Scripts
{
    interface Enemy
    {
        public string enemyName { get; }
        public int slots { get; }
        public int life { get; }
        public EnemyEffect[] effects { get; }

    }
}
