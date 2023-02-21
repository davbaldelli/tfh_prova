using Enemies.Effects;

public class EnemyEffectGatewayImpl : EnemyEffectGateway
{
    MatchData matchData;

    public EnemyEffectGatewayImpl(MatchData matchData)
    {
        this.matchData = matchData;
    }

    public void doEvenMoreEvilStuff()
    {
        matchData.enemyHealth = 10000;
    }

    public void doEvilStuff(int amount)
    {
        matchData.enemyHealth = amount;
    }

    public void makeThePlayerCry()
    {
        matchData.playerAttackMultiplier = 0.5f;
    }
}
