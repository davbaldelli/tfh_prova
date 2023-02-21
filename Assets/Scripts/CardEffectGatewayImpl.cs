using Cards.Effects;

public class CardEffectGatewayImpl : CardEffectGateway
{

    PlayerData playerData;

    public CardEffectGatewayImpl(PlayerData playerData)
    {
        this.playerData = playerData;
    }

    public void addLife(int amount)
    {
        playerData.health += amount;
    }

    public void drawCard()
    {
        playerData.hand.Add(playerData.discardDeck.Pop());
    }

    public void addAttackMult(float amount)
    {
        playerData.attackMultiplier += amount;
    }

    public void addDefenseMult(float amount)
    {
        playerData.defenseMultiplier += amount;
    }
}