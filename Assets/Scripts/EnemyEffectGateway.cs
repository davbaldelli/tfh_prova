using Enemies.Effects;

public class EnemyEffectGateway : IEnemyEffectGateway
{
    EnemyData enemyData;
    PlayerData playerData;

    public EnemyEffectGateway(EnemyData enemyData, PlayerData playerData)
    {
        this.enemyData = enemyData;
        this.playerData = playerData;   
    }

    public void doEvenMoreEvilStuff()
    {
        enemyData.enemyHealth = 10000;
    }

    public void doEvilStuff(int amount)
    {
        enemyData.enemyHealth = amount;
    }

    public void makeThePlayerCry()
    {
        playerData.attackMultiplier = 0.5f;
    }
}
