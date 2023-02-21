using Cards;
using System.Collections.Generic;

public class PlayerData
{
    public int health;
    public float attackMultiplier;
    public float defenseMultiplier;
    public int handCount;
    public Stack<Card> playerDeck;
    public Stack<Card> discardDeck = new Stack<Card>();
    public List<Card> hand = new List<Card>();

    public PlayerData(int health, float attackMultiplier, float defenseMultiplier, Stack<Card> playerDeck, int handCount)
    {
        this.health = health;
        this.attackMultiplier = attackMultiplier;
        this.defenseMultiplier = defenseMultiplier;
        this.playerDeck = playerDeck;
        this.handCount = handCount;
    }


}
