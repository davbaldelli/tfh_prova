using Cards;
using System.Collections.Generic;

public class PlayerData
{
    public int health;
    public float attackMultiplier;
    public float defenseMultiplier;
    public int handCount;
    public Stack<ICard> playerDeck;
    public Stack<ICard> discardDeck = new Stack<ICard>();
    public List<ICard> hand = new List<ICard>();

    public PlayerData(int health, float attackMultiplier, float defenseMultiplier, Stack<ICard> playerDeck, int handCount)
    {
        this.health = health;
        this.attackMultiplier = attackMultiplier;
        this.defenseMultiplier = defenseMultiplier;
        this.playerDeck = playerDeck;
        this.handCount = handCount;
    }


}
