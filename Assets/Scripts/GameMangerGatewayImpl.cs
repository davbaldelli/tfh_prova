using Cards;

public class GameMangerGatewayImpl : GameManagerGateway
{
    MatchData matchData;
    PlayerStats playerStats;

    public GameMangerGatewayImpl(MatchData matchData, PlayerStats playerStats)
    {
        this.matchData = matchData;
        this.playerStats = playerStats;
    }

    public void drawCards()
    {
        if (matchData.playerHand.Count < matchData.playerHandCardsCount)
        {
            for (int i = 0; i < matchData.playerHandCardsCount - matchData.playerHand.Count; i++)
                matchData.playerDeck.Pop();
        }
    }

    public void finishTurn()
    {
        //do stuff
    }

    public void startGame()
    {
        //shuffle cards then insert them

        foreach (Card card in playerStats.StartingDeck)
        {
            matchData.playerDeck.Push(card);
        }

        for (int i = 0; i < matchData.playerHandCardsCount; i++)
        {
            matchData.playerHand.Add(matchData.playerDeck.Pop());
        }
    }

}