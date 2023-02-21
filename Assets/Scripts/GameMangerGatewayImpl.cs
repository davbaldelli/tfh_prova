using Cards;

public class GameMangerGatewayImpl : GameManagerGateway
{
    PlayerData playerData;
    EnemyData enemyData;

    public GameMangerGatewayImpl(PlayerData playerData, EnemyData enemyData)
    {
        this.playerData = playerData;
        this.enemyData = enemyData;
    }

    public void drawCards()
    {
        if (playerData.hand.Count < playerData.handCount)
        {
            for (int i = 0; i < playerData.handCount - playerData.hand.Count; i++)
                playerData.playerDeck.Pop();
        }
    }

    public void finishTurn()
    {
        //do stuff
    }

    public void startGame()
    {
        for (int i = 0; i < playerData.handCount; i++)
        {
            playerData.hand.Add(playerData.playerDeck.Pop());
        }
    }

}