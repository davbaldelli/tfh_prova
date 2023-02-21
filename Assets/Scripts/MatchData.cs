using Cards;
using System.Collections.Generic;

public class MatchData
{
    public int playerHealth;
    public float playerAttackMultiplier = 1;
    public float playerDefenseMultiplier = 1;
    public int playerHandCardsCount;
    public int enemyHealth;
    public Stack<Card> playerDeck;
    public Stack<Card> discardDeck = new Stack<Card>();
    public List<Card> playerHand = new List<Card>();

    public MatchData(int playerHealth, int enemyHealth, Card[] cards, int playerHandCardsCount)
    {
        this.playerHealth = playerHealth;
        this.enemyHealth = enemyHealth;
        this.playerDeck = new Stack<Card>(cards);
        this.playerHandCardsCount = playerHandCardsCount;
    }
}