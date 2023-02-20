using Assets.Scripts;

public interface Card
{
    public CardEffect[] getPassiveEffects();
    public CardEffect[] getActiveEffects();
}
